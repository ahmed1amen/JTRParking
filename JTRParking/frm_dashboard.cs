using BarcodeStandard;
using JTRParking.Classes;
using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
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

        }



        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            lbl_welcome_user.Text = "Welcome : " + AppSingleton.Instance.current_user.Name;
            LoadSettings();
            Barcode b = new Barcode();
            b.IncludeLabel = true;
            var img = b.Encode(BarcodeStandard.Type.Code128, "038000356216", SKColors.Black, SKColors.White, 290, 120);

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


            using (var context = new JTRDbContext())
            {
                List<Setting> settings = context.Settings.ToList();

                foreach (Setting setting in settings)
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
    }
}
