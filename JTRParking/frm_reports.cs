using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using User = JTRParking.Models.User;

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
                comboBoxUsers.DataSource = context.Users.ToList();
                comboBoxUsers.DisplayMember = "Name";

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
            if (comboBoxUsers.SelectedItem != null && materialCheckbox1.Checked == false)
            {

                selectedUser = (User)comboBoxUsers.SelectedItem;
                user_id = selectedUser.Id;

                // Use the selected user as needed
            }

            // Select parkings within the specified time range
            // var parkingsWithinTimeRange = parkings.Where(p => p.CreatedAt >= startTime && p.CreatedAt <= endTime).ToList();
            using (var context = new JTRDbContext())
            {
                IQueryable<Parking> query = context.Parkings;
                //  .Where(p => p.OutTime >= startTime && p.CreatedAt <= endTime);

                if (materialCheckbox1.Checked == false)
                    query.Where(p => p.CreatedBy == user_id).ToList();


                List<Parking> parkings = query.ToList();
                if (parkings.Count != 0)
                {
                    lbl_stats.Text =
                        $"  Total C.A For Today: {context.Parkings.Where(p => p.CreatedAt == DateTime.Now.Date).ToList().Sum(p => p.Amount)} \n"+
                        $"  Tota Car : {parkings.Where(p => p.VehicleType == "Car").Count()} \n" +
                        $"  Tota Motor: {parkings.Where(p => p.VehicleType == "Motor").Count()} \n" +
                        $"  Total Amount: {parkings.Sum(p => p.Amount)} \n";
                }
                else
                    MessageBox.Show("Not Found!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxUsers.Enabled = !materialCheckbox1.Checked;
        }

        private void comboBoxShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShifts.SelectedItem != null)
            {
                var selectedObj = comboBoxShifts.SelectedItem;
                var type = selectedObj.GetType();
                var shiftProp = type.GetProperty("Shift");
                if (shiftProp != null)
                {
                    var shiftValue = shiftProp.GetValue(selectedObj);
                    if (shiftValue is Shift selectedShift && selectedShift != null)
                    {
                        label6.Text = $"CreatedAt : {selectedShift.CreatedAt:dd/MM/yyyy} Start : {selectedShift.StartTime:hh\\:mm\\:ss} - End : {selectedShift.EndTime:hh\\:mm\\:ss}";
                    }
                }
                else if (selectedObj is Shift selectedShift && selectedShift != null)
                {
                    label6.Text = $"CreatedAt : {selectedShift.CreatedAt:dd/MM/yyyy} Start : {selectedShift.StartTime:hh\\:mm\\:ss} - End : {selectedShift.EndTime:hh\\:mm\\:ss}";
                }
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new JTRDbContext())
            {
                if (comboBoxUsers.SelectedItem != null && materialCheckbox1.Checked == false)
                {
                    User selectedUser = (User)comboBoxUsers.SelectedItem;
                    DateTime startTime = dateTimePickerStart.Value;
                    DateTime endTime = dateTimePickerEnd.Value;
                    var shifts = context.Shifts
                        .Where(s => s.UserId == selectedUser.Id && s.CreatedAt >= startTime && s.CreatedAt <= endTime)
                        .ToList();
                    var displayList = shifts.Select(s => new
                    {
                        Shift = s,
                        DisplayText = $"{s.CreatedAt:dd/MM/yyyy} - {s.Name}"
                    }).ToList();
                    comboBoxShifts.DataSource = displayList;
                    comboBoxShifts.DisplayMember = "DisplayText";
                    comboBoxShifts.ValueMember = "Shift";
                    comboBoxShifts.Refresh();
                }
            }
        }
    }

}
