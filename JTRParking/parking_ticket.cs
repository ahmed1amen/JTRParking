using BarcodeStandard;
using JTRParking.Classes;
using JTRParking.Database;
using JTRParking.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace JTRParking
{
    public partial class parking_ticket : Form
    {
        public Parking Parking { get; set; }
        public bool AutoPrint = false;
        public parking_ticket()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PaperSize = new PaperSize("Custom", (int)(80 / 25.4 * 100), (int)(100 / 25.4 * 100)); // Converting millimeters to hundredths of an inch
            e.PageSettings.Landscape = false; // Set to true if landscape orientation is desired

            e.Graphics.DrawImage(memoryImage, 0, 0);

        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc,
            int nXSrc, int nYSrc, int dwRop);

        private Bitmap memoryImage;

        private void PrintForm()
        {
            Graphics mygraphics = tableLayoutPanel2.CreateGraphics();
            Size s = tableLayoutPanel2.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, tableLayoutPanel2.ClientRectangle.Width, tableLayoutPanel2.ClientRectangle.Height, dc1, 0,
                0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }


        public void parking_ticket_Load(object sender, EventArgs e)
        {
            string parking_ticket_header_title = AppSingleton.Instance.current_settings
                .Where(s => s.Key == "parking_ticket_header_title").FirstOrDefault().Value;
            string parking_ticket_header_sub_title = AppSingleton.Instance.current_settings
                .Where(s => s.Key == "parking_ticket_header_sub_title").FirstOrDefault().Value;
            lbl_parking_ticket_header_title.Text = parking_ticket_header_title;
            lbl_parking_ticket_header_sub_title.Text = parking_ticket_header_sub_title;


            Barcode b = new Barcode();
            b.IncludeLabel = true;
            var img = b.Encode(BarcodeStandard.Type.Code128, Parking.Barcode, SKColors.Black, SKColors.White, 290, 120);
            pictureBox1.Image = Image.FromStream(img.Encode().AsStream());
            lbl_DriverName.Text = Parking.DriverName;
            lbl_DriverMobile.Text = Parking.DriverMobile;
            lbl_VehicleType.Text = Parking.VehicleType + " - " + Parking.Id;
            lbl_InTime.Text = Parking.InTime.ToString("MM/dd/yyyy HH:mm:ss tt");
            lbl_OutTime.Text = Parking.OutTime.ToString();
            lbl_TotalHours.Text = "-";
            if (Parking.OutTime != null)
            {

                TimeSpan duration = Parking.OutTime.Value - Parking.InTime;
                int totalHoursParked = (int)Math.Ceiling(duration.TotalHours);
                lbl_TotalHours.Text = totalHoursParked.ToString() + " h";

            }
            lbl_Amount.Text = Parking.Amount.ToString();

            btn_endParking.Visible = false;

            if (Parking.Status == Parking.ParkingStatus.PENDING)
            {
                btn_endParking.Visible = true;
                btn_endParking.BackColor = Color.Yellow;

                tableLayoutPanel2.RowStyles[7].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[7].Height = 0;

                tableLayoutPanel2.RowStyles[8].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[8].Height = 0;

                tableLayoutPanel2.RowStyles[9].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[9].Height = 0;

            }

            if (AppSingleton.Instance.current_user.Role == User.UserRole.EMPLOYEE_IN)
            {
                btn_endParking.Enabled = false;
                if (this.AutoPrint)
                    timer1.Start();
            }


        }

        public void button2_Click(object sender, EventArgs e)
        {

            PrintForm();

            //  printPreviewDialog1.ShowDialog();
            printDocument1.Print();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btn_endParking_Click(object sender, EventArgs e)
        {
            decimal first_hour_rate = decimal.Parse(AppSingleton.Instance.current_settings
                .Where(s => s.Key == "first_hour_rate").FirstOrDefault().Value);
            decimal hourly_rate = decimal.Parse(AppSingleton.Instance.current_settings
                .Where(s => s.Key == "hourly_rate").FirstOrDefault().Value);
            string currency_symbol = AppSingleton.Instance.current_settings.Where(s => s.Key == "currency_symbol")
                .FirstOrDefault().Value;

            Parking.OutTime = DateTime.Now;

            TimeSpan duration = Parking.OutTime.Value - Parking.InTime;
            // int totalHoursParked = (int)Math.Ceiling(duration.TotalHours);


            // Calculate total hours parked, considering first 5 minutes of each hour as free
            int totalHoursParked = (int)duration.TotalHours;
            int remainingMinutes = duration.Minutes;

            if (remainingMinutes > 5)
            {
                totalHoursParked += 1;
            }

            decimal rate = 0;


            rate += first_hour_rate;
            if (totalHoursParked > 1)
            {
                rate += (totalHoursParked - 1) * hourly_rate;
            }


            Parking.Amount = rate;
            Parking.Status = Parking.ParkingStatus.COMPLETED;
            Parking.CreatedBy = (ulong)AppSingleton.Instance.current_user.Id;
            lbl_TotalHours.Text = totalHoursParked.ToString() + " h";
            if (totalHoursParked > 0)

                lbl_Amount.Text = rate.ToString() + " " + currency_symbol;
            else
            {
                lbl_Amount.Text = "0 " + currency_symbol;
                Parking.Amount = 0;
            }

            lbl_OutTime.Text = Parking.OutTime.ToString();


            tableLayoutPanel2.RowStyles[7].SizeType = SizeType.Absolute;
            tableLayoutPanel2.RowStyles[7].Height = 60;

            tableLayoutPanel2.RowStyles[8].SizeType = SizeType.Absolute;
            tableLayoutPanel2.RowStyles[8].Height = 60;

            tableLayoutPanel2.RowStyles[9].SizeType = SizeType.Absolute;
            tableLayoutPanel2.RowStyles[9].Height = 60;



            using (var context = new JTRDbContext())
            {
                context.Parkings.Update(Parking);
                context.SaveChanges();
            }

            btn_endParking.Visible = false;
            btn_endParking.BackColor = Color.Yellow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.button2.PerformClick();
        }
    }
}






//// Assuming you have defined first_hour_rate and hourly_rate variables

//Parking.OutTime = DateTime.Now;

//// Add a 10-minute grace period
//DateTime gracePeriodOutTime = Parking.OutTime.Value.AddMinutes(10);

//// Calculate the duration considering the grace period
//TimeSpan duration = gracePeriodOutTime - Parking.InTime;

//// If the duration is negative (i.e., the grace period exceeds the InTime), set it to zero
//if (duration.TotalMinutes < 0)
//{
//    duration = TimeSpan.Zero;
//}

//// Calculate the total hours parked, including the first hour
//int totalHoursParked = (int)Math.Ceiling(duration.TotalHours);

//decimal rate = 0;

//if (totalHoursParked > 0)
//{
//    // Add the rate for the first hour
//    rate += first_hour_rate;

//    // If parked for more than one hour, add the additional hourly rate
//    if (totalHoursParked > 1)
//    {
//        rate += (totalHoursParked - 1) * hourly_rate;
//    }
//}