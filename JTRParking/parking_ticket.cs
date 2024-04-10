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
        public parking_ticket()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        private Bitmap memoryImage;
        private void PrintForm()
        {

            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

        }


        private void parking_ticket_Load(object sender, EventArgs e)
        {
            Barcode b = new Barcode();
            b.IncludeLabel = true;
            var img = b.Encode(BarcodeStandard.Type.Code128, Parking.Barcode, SKColors.Black, SKColors.White, 290, 120);
            pictureBox1.Image = Image.FromStream(img.Encode().AsStream());
            lbl_DriverName.Text = Parking.DriverName;
            lbl_DriverMobile.Text = Parking.DriverMobile;
            lbl_InTime.Text = Parking.InTime.ToString();
            lbl_OutTime.Text = Parking.OutTime.ToString();
            lbl_TotalHours.Text = "5h";
            lbl_Amount.Text = Parking.Amount.ToString();

            btn_endParking.Visible = false;

            if (Parking.Status == Parking.ParkingStatus.PENDING)
            {
                btn_endParking.Visible = true;
                btn_endParking.BackColor = Color.Yellow;

                tableLayoutPanel2.RowStyles[6].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[6].Height = 0;

                tableLayoutPanel2.RowStyles[7].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[7].Height = 0;

                tableLayoutPanel2.RowStyles[8].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[8].Height = 0;




            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            this.Refresh();
            //  printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Recipt",100,300);
            PrintForm();
            tableLayoutPanel1.Visible = true;
            this.Refresh();
            printPreviewDialog1.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_endParking_Click(object sender, EventArgs e)
        {
            decimal first_hour_rate = decimal.Parse(AppSingleton.Instance.current_settings.Where(s => s.Key == "first_hour_rate").FirstOrDefault().Value);
            decimal hourly_rate = decimal.Parse(AppSingleton.Instance.current_settings.Where(s => s.Key == "hourly_rate").FirstOrDefault().Value);
            string currency_symbol = AppSingleton.Instance.current_settings.Where(s => s.Key == "currency_symbol").FirstOrDefault().Value;

             

            //

            Parking.OutTime = DateTime.Now;


            TimeSpan duration = Parking.OutTime.Value - Parking.InTime;
            int totalHoursParked = (int)Math.Ceiling(duration.TotalHours);

            decimal rate = 0;

            if (totalHoursParked > 0)
            {
                rate += first_hour_rate;
                rate += (totalHoursParked - 1) * hourly_rate;

                Parking.Amount = rate;
                Parking.Status = Parking.ParkingStatus.COMPLETED;

                lbl_TotalHours.Text = totalHoursParked.ToString() + " h";
                lbl_Amount.Text = rate.ToString() + " " + currency_symbol;
                lbl_OutTime.Text = Parking.OutTime.ToString();


                tableLayoutPanel2.RowStyles[6].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[6].Height = 60;

                tableLayoutPanel2.RowStyles[7].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[7].Height = 60;

                tableLayoutPanel2.RowStyles[8].SizeType = SizeType.Absolute;
                tableLayoutPanel2.RowStyles[8].Height = 60;



            }

            using (var context = new JTRDbContext())
            {
                context.Parkings.Update(Parking);
                context.SaveChanges();
            }

                 btn_endParking.Visible = false;
                  btn_endParking.BackColor = Color.Yellow;

            }





        }
}
