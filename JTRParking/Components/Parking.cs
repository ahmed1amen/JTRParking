using BarcodeStandard;
using JTRParking.Database;
using JTRParking.Models;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using JTRParking.Classes;

namespace JTRParking.Components
{
    public partial class Parking : UserControl
    {
        public Models.User CurrentUser;
        public Parking()
        {
            InitializeComponent();
        }

        private void Parking_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            using (var context = new JTRDbContext())
            {
                DateTime now = DateTime.Now;

                context.Parkings.Add(new Models.Parking
                {
                    VehicleType = combo_vehicle_type.SelectedText,
                    DriverName = txt_driver_name.Text,
                    DriverMobile = txt_driver_phone.Text,
                    Barcode = now.ToString("yyyyMMddHHmmss") + AppSingleton.Instance.current_user.Id.ToString(),
                    InTime = DateTime.Now,
                    //  OutTime = "",
                    Amount = 0,
                    Status = Models.Parking.ParkingStatus.PENDING,
                    CreatedBy = (ulong)AppSingleton.Instance.current_user.Id,
                    CreatedAt = DateTime.Now,
                });

            }
            MessageBox.Show("Parking Successfully Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
