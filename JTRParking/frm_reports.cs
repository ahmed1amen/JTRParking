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

            // Select parkings within the specified time range
            // var parkingsWithinTimeRange = parkings.Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime).ToList();
            using (var context = new JTRDbContext())
            {

                List<Parking> parkings = context.Parkings.Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime).ToList();

                if (parkings.Count != 0)
                {



                }
                else
                    MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
        }
    }
}
