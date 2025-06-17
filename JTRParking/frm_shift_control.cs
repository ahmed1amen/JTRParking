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
using JTRParking.Classes;
using JTRParking.Database;
using JTRParking.Models;

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
            var selectedTime = timePickerShift.Value.TimeOfDay;
            var currentUser = AppSingleton.Instance.current_user;
            if (currentUser == null)
            {
                MessageBox.Show("No user found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new JTRDbContext())
            {
                if (btnStartShift.Text == "Start My Shift")
                {
                    // Close all previous open shifts for this user
                    var previousShifts = context.Shifts.Where(s => s.UserId == currentUser.Id && s.Status == ShiftStatus.OPEN).ToList();
                    foreach (var shift in previousShifts)
                    {
                        shift.Status = ShiftStatus.CLOSED;
                        shift.EndTime = DateTime.Now.TimeOfDay;
                    }
                    context.SaveChanges();

                    // Determine shift name based on selected time
                    string shiftName = selectedTime < new TimeSpan(15, 0, 0) ? "Morning Shift" : "Evening Shift";
                    // Create new open shift
                    var newShift = new Shift
                    {
                        UserId = currentUser.Id,
                        StartTime = selectedTime,
                        Status = ShiftStatus.OPEN,
                        Name = shiftName
                    };
                    context.Shifts.Add(newShift);
                    context.SaveChanges();

                    MessageBox.Show($"Shift started at {timePickerShift.Value}", "Shift Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else // Close shift logic
                {
                    // Find the open shift for this user
                    var openShift = context.Shifts.FirstOrDefault(s => s.UserId == currentUser.Id && s.Status == ShiftStatus.OPEN);
                    if (openShift != null)
                    {
                        openShift.Status = ShiftStatus.CLOSED;
                        openShift.EndTime = timePickerShift.Value.TimeOfDay;
                        context.SaveChanges();
                        MessageBox.Show($"Shift closed at {DateTime.Now}", "Shift Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("No open shift found to close.", "No Open Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void lbl_timenow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timePickerShift.Value = DateTime.Now;
        }
    }
}
