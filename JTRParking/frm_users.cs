using JTRParking.Database;
using JTRParking.Models;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using User = JTRParking.Models.User;

namespace JTRParking
{
    public partial class frm_users : MaterialForm
    {
        enum CRUD_OPERATION
        {
            CREATE = 0, UPDATE = 1, DELETE = 2
        }

        void UserCrud(User user, CRUD_OPERATION operation)
        {
            if (user.Username == "admin")
                return;



            using (var context = new JTRDbContext())
            {


                switch (operation)
                {

                    case CRUD_OPERATION.CREATE:
                        {
                            context.Users.Add(user);
                            break;
                        }

                    case CRUD_OPERATION.UPDATE:
                        {
                            context.Update(user);

                            break;
                        }

                    case CRUD_OPERATION.DELETE:
                        {
                            context.Remove(user);
                            break;
                        }


                }

                context.SaveChanges();
                refreshData();



            }


        }
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frm_users()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme=new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500)
        }
        IEnumerable<User> users;
        User SelectedUser = new User();
        private void frm_users_Load(object sender, EventArgs e)
        {
            materialComboBox2.DataSource = Enum.GetValues(typeof(User.UserRole));
            refreshData();
        }




        void refreshData()
        {

            listViewUsers.Items.Clear();
            txt_id.Text = SelectedUser.Id.ToString();
            txt_name.Text = SelectedUser.Name;
            txt_username.Text = SelectedUser.Username;
            txt_password.Text = SelectedUser.Password;
            materialComboBox2.SelectedIndex = 0;

            listViewUsers.GridLines = true;
            User.UserRole userRole;

            using (var context = new JTRDbContext())
            {
                users = context.Users.ToList();
                foreach (User user in users)
                {
                    ListViewItem item = new ListViewItem(user.Id.ToString());
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(user.Username);
                    item.SubItems.Add(user.Password);
                    item.SubItems.Add(user.Role.ToString());
                    listViewUsers.Items.Add(item);
                }


            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (var context = new JTRDbContext())
            {

                if (MessageBox.Show("are you sure to Delete this user: " + txt_name.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    UserCrud(context.Users.FirstOrDefault(u => u.Id == int.Parse(txt_id.Text)), CRUD_OPERATION.DELETE);

                    MessageBox.Show("user successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                }

            }

        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {

                User.UserRole userRole;


                // Get the selected ListViewItem
                ListViewItem selectedItem = listViewUsers.SelectedItems[0];
                txt_id.Text = selectedItem.SubItems[0].Text; // Assuming Id is in the first column
                txt_name.Text = selectedItem.SubItems[1].Text; // Assuming Name is in the second column
                txt_username.Text = selectedItem.SubItems[2].Text; // Assuming Username is in the third column
                txt_password.Text = selectedItem.SubItems[3].Text; // Assuming Password is in the fourth column
                Enum.TryParse<User.UserRole>(selectedItem.SubItems[4].Text, out userRole);

                materialComboBox2.SelectedItem = userRole;

                SelectedUser.Id = int.Parse(selectedItem.SubItems[0].Text);
                SelectedUser.Name = selectedItem.SubItems[1].Text;
                SelectedUser.Username = selectedItem.SubItems[2].Text;
                SelectedUser.Password = selectedItem.SubItems[3].Text;

                Enum.TryParse<User.UserRole>(materialComboBox2.SelectedValue.ToString(), out userRole);

                SelectedUser.Role = userRole;


                materialComboBox2.Refresh();



            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            frm_users_Load(null, null);
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is MaterialTextBox2)
                {
                    ((MaterialTextBox2)control).Clear();
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("are you sure to add this user: " + txt_name.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.UserRole userRole;
                Enum.TryParse<User.UserRole>(materialComboBox2.SelectedValue.ToString(), out userRole);

                User user = new User
                {
                    Name = txt_name.Text,
                    Username = txt_username.Text,
                    Password = txt_password.Text,
                    Role = userRole


                };

                UserCrud(user, CRUD_OPERATION.CREATE);
                MessageBox.Show("User Successfully Created", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("are you sure to Update this user: " + txt_name.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listViewUsers.Items.Clear();
                User.UserRole userRole;
                Enum.TryParse<User.UserRole>(materialComboBox2.SelectedValue.ToString(), out userRole);

                SelectedUser.Name = txt_name.Text;
                SelectedUser.Username = txt_username.Text;
                SelectedUser.Password = txt_password.Text;
                SelectedUser.Role = userRole;

                UserCrud(SelectedUser, CRUD_OPERATION.UPDATE);
                MessageBox.Show("user successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
            }


        }
    }
}
