using MaterialSkin;
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
    public partial class frm_shift_control : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frm_shift_control()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void frm_shift_control_Load(object sender, EventArgs e)
        {

        }

        private void btnStartShift_Click(object sender, EventArgs e)
        {
            // Example: Access the selected time from the time picker
            var selectedTime = timePickerShift.Value.TimeOfDay;
            MessageBox.Show($"Shift started at {selectedTime}");
        }
    }
}
