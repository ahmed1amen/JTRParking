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
            dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";

            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            User selectedUser;
            int user_id = 0;
            if (comboBox1.SelectedItem != null)
            {

                selectedUser = (User)comboBox1.SelectedItem;
                user_id = selectedUser.Id;

                // Use the selected user as needed
            }

            // Select parkings within the specified time range
            // var parkingsWithinTimeRange = parkings.Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime).ToList();
            using (var context = new JTRDbContext())
            {

                List<Parking> parkings = context.Parkings
                    .Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime)
                    .Where(p => p.CreatedBy == (ulong)user_id).ToList();

                if (parkings.Count != 0)
                {
                    decimal totalAmount = parkings.Sum(p => p.Amount);
                    materialLabel3.Text = totalAmount.ToString();

                }
                else
                    MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
        }
    }
}
