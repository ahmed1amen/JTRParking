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


        }



        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome_user.Text = "Welcome : " + AppSingleton.Instance.current_user.Name;
            LoadSettings();
            LoadParking();


            lv_parking_history.GridLines = true;

            //pictureBox1.BackgroundImage = Image.FromStream(img.Encode().AsStream());



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
                    case "currency_symbol":
                        {
                            txt_settings_currency_symbol.Text = setting.Value;
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
            if (AppSingleton.Instance.current_user.Role != 0)
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
                        case "currency_symbol":
                            {
                                setting.Value = txt_settings_currency_symbol.Text;
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

            myListView.Clear();
            using (var context = new JTRDbContext())
            {
                List<Parking> parkings = context.Parkings.Where(p => p.Status == Parking.ParkingStatus.PENDING).ToList();

                foreach (Parking parking in parkings)
                {

                    int imageIndex = 0;
                    if (parking.VehicleType == "Car")
                        imageIndex = 1;

                    ListViewItem item = new ListViewItem(parking.DriverName + " - " + parking.Id, imageIndex);
                    item.SubItems.Add(parking.Id.ToString());

                    myListView.Items.Add(item);

                }

            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            lv_parking_history.Items.Clear();
            lv_parking_history.GridLines = true;
            using (var context = new JTRDbContext())
            {
                List<Parking> parkings = context.Parkings.ToList();

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
                        ParkingTicket.ShowDialog(this);
                    }
                    else
                        MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);



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
                ParkingTicket.ShowDialog(this);
                LoadParking();

            }



        }

        private void ParkingComponent_OnParkingAdded(object sender, Parking parking)
        {

            MessageBox.Show("Parking Successfully Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadParking();
            parking_ticket ParkingTicket = new parking_ticket();
            ParkingTicket.Parking = parking;
            ParkingTicket.ShowDialog(this);
            LoadParking();

        }




    }

}
