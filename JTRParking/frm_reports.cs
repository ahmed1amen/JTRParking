using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTRParking
{
    public partial class frm_reports : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frm_reports()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme=new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500)


        }


        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void frm_reports_Load(object sender, EventArgs e)
        {

            using (var context = new JTRDbContext())
            {
                comboBox1.DataSource = context.Users.ToList();
                comboBox1.DisplayMember = "name";
            }


            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/dd/yyyy HH:mm:ss";


            dateTimePickerStart.Value = DateTime.Today.AddHours(8).AddMinutes(20);
            dateTimePickerEnd.Value = DateTime.Today.AddDays(1).AddHours(8).AddMinutes(19).AddSeconds(59);




        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            User selectedUser;
            ulong user_id = 0;
            if (comboBox1.SelectedItem != null && materialCheckbox1.Checked == false)
            {

                selectedUser = (User)comboBox1.SelectedItem;
                user_id = selectedUser.Id;

                // Use the selected user as needed
            }

            // Select parkings within the specified time range
            // var parkingsWithinTimeRange = parkings.Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime).ToList();
            using (var context = new JTRDbContext())
            {
                IQueryable<Parking> query = context.Parkings
                     .Where(p => p.OutTime >= startTime && p.CreatedAt <= endTime);

                if (materialCheckbox1.Checked == false)
                    query.Where(p => p.CreatedBy ==  user_id).ToList();


                List<Parking> parkings = query.ToList();
                if (parkings.Count != 0)
                {
                    lbl_motor_count.Text = " Tota Car : " + parkings.Where(p => p.VehicleType == "Car").Count().ToString();
                    lbl_car_count.Text = " Tota Motor : " + parkings.Where(p => p.VehicleType == "Motor").Count().ToString();
                    lbl_total_amount.Text = " Total Amount : " + parkings.Sum(p => p.Amount);
                }
                else
                    MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = !materialCheckbox1.Checked;
        }
    }
}
