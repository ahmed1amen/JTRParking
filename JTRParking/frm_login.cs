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
