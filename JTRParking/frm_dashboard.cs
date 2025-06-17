using BarcodeStandard;
using JTRParking.Classes;
using JTRParking.Components;
using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using SkiaSharp;
using System;
using System.Xml.Linq;

namespace JTRParking
{
    public partial class frm_dashboard : MaterialForm
    {

        int current_screen_h = 0;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frm_dashboard()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme=new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500)

            parking1.ParkingAdded += ParkingComponent_OnParkingAdded;
            this.current_screen_h = Screen.GetWorkingArea(this).Height;

        }



        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome_user.Text = "Welcome : " + AppSingleton.Instance.current_user.Name;

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";

            // Set dateTimePickerStart to the start of today (00:00:00)
            dateTimePickerStart.Value = DateTime.Today;

            // Set dateTimePickerEnd to the end of today (23:59:59)
            dateTimePickerEnd.Value = DateTime.Today.AddDays(1).AddTicks(-1);


            LoadSettings();
            LoadParking();
            ManageRules();

            lv_parking_history.GridLines = true;

            if (AppSingleton.Instance.current_user.Role == (Models.User.UserRole.EMPLOYEE_OUT | Models.User.UserRole.ADMIN))
                timer3.Start();

            if (AppSingleton.Instance.current_user.Role == Models.User.UserRole.ADMIN)
                btn_end_my_shift.Hide();


        }

        private void text_allow_decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a decimal digit, backspace, or decimal separator
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true; // Suppress the key press
            }

            // Check for multiple decimal separators
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Suppress the key press
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true; // Suppress the key press
            }
        }




        void LoadSettings()
        {



            foreach (Setting setting in AppSingleton.Instance.current_settings)
            {

                switch (setting.Key)

                {
                    case "first_hour_rate":
                        {
                            txt_settings_first_hour_rate.Text = setting.Value;
                            break;
                        }
                    case "hourly_rate":
                        {
                            txt_settings_hourly_rate.Text = setting.Value;
                            break;
                        }
                    case "allowed_minutes":
                        {
                            txt_allowed_minutes.Text = setting.Value;
                            break;
                        }
                    case "currency_symbol":
                        {
                            txt_settings_currency_symbol.Text = setting.Value;
                            break;
                        }

                    case "parking_ticket_header_title":
                        {
                            txt_settings_parking_ticket_header_title.Text = setting.Value;
                            break;
                        }

                    case "parking_ticket_header_sub_title":
                        {
                            txt_settings_parking_ticket_header_sub_title.Text = setting.Value;
                            break;
                        }


                }



            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //    Linear barcode = new Linear();
            //   barcode.Type = BarcodeType.CODE11;
            //    barcode.Data = materialTextBox21.Text;
            //   barcode.drawBarcode("barcode");
            //pictureBox2.Image

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parking_ticket parking_Ticket = new parking_ticket();
            parking_Ticket.Show();
        }

        private void btn_update_settings_Click(object sender, EventArgs e)
        {
            if (AppSingleton.Instance.current_user.Role != Models.User.UserRole.ADMIN)
            {
                MessageBox.Show("Only Admin Can Update ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new JTRDbContext())
            {
                List<Setting> settings = context.Settings.ToList();

                foreach (Setting setting in settings)
                {

                    switch (setting.Key)

                    {
                        case "first_hour_rate":
                            {

                                setting.Value = txt_settings_first_hour_rate.Text;
                                if (setting.Value == "")
                                    setting.Value = "0";
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }
                        case "hourly_rate":
                            {
                                setting.Value = txt_settings_hourly_rate.Text;
                                if (setting.Value == "")
                                    setting.Value = "0";
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }
                        case "allowed_minutes":
                            {
                                setting.Value = txt_allowed_minutes.Text;
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }
                        case "currency_symbol":
                            {
                                setting.Value = txt_settings_currency_symbol.Text;
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }

                        case "parking_ticket_header_title":
                            {
                                setting.Value = txt_settings_parking_ticket_header_title.Text;
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }

                        case "parking_ticket_header_sub_title":
                            {
                                setting.Value = txt_settings_parking_ticket_header_sub_title.Text;
                                context.Update(setting);
                                context.SaveChanges();
                                break;
                            }

                    }

                }

            }
            MessageBox.Show("Settings Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppSingleton.Instance.refreshSettings();
            LoadSettings();


        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

            frm_users frm_Users = new frm_users();
            frm_Users.ShowDialog(this);

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void materialButton3_Click(object sender, EventArgs e)
        {
            LoadParking();
        }



        void LoadParking()
        {


            using (var context = new JTRDbContext())
            {
                List<Parking> parkings = context.Parkings.Where(p => p.Status == Parking.ParkingStatus.PENDING).ToList();
                if (parkings.Count != myListView.Items.Count)
                {
                    myListView.Clear();

                    foreach (Parking parking in parkings)
                    {

                        int imageIndex = 0;
                        if (parking.VehicleType == "Car")
                            imageIndex = 1;

                        ListViewItem item = new ListViewItem(parking.DriverName + " - " + parking.Id, imageIndex);
                        item.SubItems.Add(parking.Id.ToString());

                        myListView.Items.Add(item);


                    }
                    groupBox_manage_parking.Text = "Manage Parking " + " - (" + myListView.Items.Count + ")";

                }
            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;

            lv_parking_history.Items.Clear();
            lv_parking_history.GridLines = true;
            using (var context = new JTRDbContext())
            {
                List<Parking> parkings = context.Parkings
                    .Where(p => p.OutTime >= startTime && p.OutTime <= endTime).ToList();

                lbl_total_amount.Text = " Total Amount : " + parkings.Sum(p => p.Amount) + " Total Cars : " + parkings.Count;
                foreach (Parking parking in parkings)
                {
                    ListViewItem item = new ListViewItem(parking.Id.ToString());
                    item.SubItems.Add(parking.VehicleType);
                    item.SubItems.Add(parking.DriverName);
                    item.SubItems.Add(parking.DriverMobile);
                    item.SubItems.Add(parking.InTime.ToString());
                    item.SubItems.Add(parking.OutTime.ToString());
                    item.SubItems.Add(parking.Amount.ToString());
                    item.SubItems.Add(parking.Status.ToString());
                    item.SubItems.Add(parking.CreatedBy.ToString());
                    item.SubItems.Add(parking.CreatedAt.ToString());
                    lv_parking_history.Items.Add(item);

                }
                lv_parking_history.Refresh();
                lv_parking_history.View = View.Details;

            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                using (var context = new JTRDbContext())
                {

                    Parking parking = context.Parkings.Where(p => p.Barcode == txt_barcode.Text).FirstOrDefault();

                    if (parking != null)
                    {
                        parking_ticket ParkingTicket = new parking_ticket();
                        ParkingTicket.Parking = parking;
                        ParkingTicket.Height = this.current_screen_h - (int)(this.current_screen_h * 0.1);
                        ParkingTicket.ShowDialog(this);
                    }
                    else
                        MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_barcode.Clear();

                }
            }
        }



        private void myListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (myListView.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = myListView.SelectedItems[0];
                Parking parking;
                using (var context = new JTRDbContext())
                {
                    ulong id = ulong.Parse(selectedItem.SubItems[1].Text);
                    parking = context.Parkings.Where(p => p.Id == id).FirstOrDefault();

                }

                parking_ticket ParkingTicket = new parking_ticket();
                ParkingTicket.Parking = parking;
                ParkingTicket.Height = this.current_screen_h - (int)(this.current_screen_h * 0.1);
                ParkingTicket.ShowDialog(this);
                ParkingTicket.AutoPrint = false;
                LoadParking();

            }



        }

        private void ParkingComponent_OnParkingAdded(object sender, Parking parking)
        {

            MessageBox.Show("Parking Successfully Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);


            parking_ticket ParkingTicket = new parking_ticket();
            ParkingTicket.Parking = parking;
            ParkingTicket.Height = this.current_screen_h - (int)(this.current_screen_h * 0.1);
            if (AppSingleton.Instance.current_user.Role == Models.User.UserRole.EMPLOYEE_IN)
                ParkingTicket.AutoPrint = true;

            ParkingTicket.ShowDialog(this);
            LoadParking();



        }



        void ManageRules()
        {

            if (AppSingleton.Instance.current_user.Role == Models.User.UserRole.ADMIN)
                return;

            materialTabControl1.TabPages.Remove(tab_settings);
            materialTabControl1.TabPages.Remove(tab_history);
            materialTabControl1.Refresh();

            if (AppSingleton.Instance.current_user.Role == Models.User.UserRole.EMPLOYEE_IN)
            {
                groupBox_add_parking.Enabled = true;
                groupBox_find_vehicle.Enabled = false;
                groupBox_manage_parking.Enabled = true;

            }
            else if (AppSingleton.Instance.current_user.Role == Models.User.UserRole.EMPLOYEE_OUT)
            {
                groupBox_add_parking.Enabled = false;
                groupBox_find_vehicle.Enabled = true;
                groupBox_manage_parking.Enabled = true;

            }

        }

        private void materialButton4_Click_1(object sender, EventArgs e)
        {
            frm_reports frmReports = new frm_reports();
            frmReports.ShowDialog(this);
        }

        private void timer_date_now_Tick(object sender, EventArgs e)
        {
            lbl_date_time_now.Text = DateTime.Now.ToString("MM/dd/yyyy") + "\n" + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.LoadParking();
        }

        private void parking1_Load(object sender, EventArgs e)
        {

        }

        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_end_my_shift_Click(object sender, EventArgs e)
        {
            frm_shift_control shiftControl = new frm_shift_control();
            shiftControl.lbl_message.Text = "End Your Shift.";
            shiftControl.btnStartShift.Text = "End My Shift";
            this.Hide();
            shiftControl.Show();
        }
    }

}
