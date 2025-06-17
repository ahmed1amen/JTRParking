using JTRParking.Classes;
using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using static JTRParking.Models.User;

namespace JTRParking
{

    public partial class frm_login : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frm_login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme=new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500)
        }



        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            using (var context = new JTRDbContext())
            {
             

                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                    if (password == user.Password)
                    {
                        List<Setting> settings = context.Settings.ToList();
                        AppSingleton.Instance.current_settings = settings;
                        AppSingleton.Instance.current_user = user;

                        // Check if not admin, then check shifts
                        if (user.Role != UserRole.ADMIN)
                        {
                            // Check for any open shift for any employee with the same role before login
                            var anyOpenShift = context.Shifts
                                .Where(s => s.Status == ShiftStatus.OPEN && s.UserId != user.Id)
                                .Join(context.Users, s => s.UserId, u => u.Id, (s, u) => new { Shift = s, User = u })
                                .FirstOrDefault(x => x.User.Role == user.Role);
                            if (anyOpenShift != null)
                            {
                                string employeeName = anyOpenShift.User != null ? anyOpenShift.User.Name : "Unknown";
                                MessageBox.Show($"There is an open shift for employee: {employeeName}. Please end this shift before anyone can log in.", "Open Shift Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            
                            // Check for open shift for this user
                            var openShift = context.Shifts.FirstOrDefault(s => s.UserId == user.Id && s.Status == ShiftStatus.OPEN);
                            if (openShift == null)
                            {
                                MessageBox.Show("No open shift found for this user. Please start your shift.", "Shift Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                // Optionally, show shift control form
                                frm_shift_control shiftControl = new frm_shift_control();
                                shiftControl.lbl_message.Text = "Please start your shift before proceeding.";
                                shiftControl.ShowDialog();
                                return;
                            }
                        }

                        frm_dashboard frm_Dashboard = new frm_dashboard();
                        frm_Dashboard.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Error Password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Invalid Username Or Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
