namespace JTRParking
{
    partial class frm_dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "Car", "Hassan" }, -1);
            imageList1 = new ImageList(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tab_home = new TabPage();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            parking1 = new Components.Parking();
            lbl_welcome_user = new Label();
            tab_history = new TabPage();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            lv_parking_history = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label4 = new Label();
            tab_settings = new TabPage();
            groupBox3 = new GroupBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txt_settings_currency_symbol = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            txt_settings_hourly_rate = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            txt_settings_first_hour_rate = new MaterialSkin.Controls.MaterialTextBox2();
            btn_update_settings = new MaterialSkin.Controls.MaterialButton();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            materialTabControl1.SuspendLayout();
            tab_home.SuspendLayout();
            groupBox1.SuspendLayout();
            tab_history.SuspendLayout();
            tab_settings.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "settings.png");
            imageList1.Images.SetKeyName(1, "home.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tab_home);
            materialTabControl1.Controls.Add(tab_history);
            materialTabControl1.Controls.Add(tab_settings);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(22, 106);
            materialTabControl1.Margin = new Padding(2);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1462, 835);
            materialTabControl1.TabIndex = 1;
            // 
            // tab_home
            // 
            tab_home.BackColor = Color.White;
            tab_home.Controls.Add(materialListView1);
            tab_home.Controls.Add(groupBox1);
            tab_home.Controls.Add(lbl_welcome_user);
            tab_home.ImageKey = "home.png";
            tab_home.Location = new Point(4, 39);
            tab_home.Margin = new Padding(2);
            tab_home.Name = "tab_home";
            tab_home.Padding = new Padding(2);
            tab_home.Size = new Size(1454, 792);
            tab_home.TabIndex = 0;
            tab_home.Text = "Home";
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            materialListView1.Location = new Point(695, 84);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(727, 559);
            materialListView1.TabIndex = 4;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            materialListView1.SelectedIndexChanged += materialListView1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(parking1);
            groupBox1.Location = new Point(81, 84);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(555, 559);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Park";
            // 
            // button1
            // 
            button1.Location = new Point(121, 320);
            button1.Name = "button1";
            button1.Size = new Size(222, 98);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // parking1
            // 
            parking1.Location = new Point(5, 26);
            parking1.Margin = new Padding(3, 4, 3, 4);
            parking1.Name = "parking1";
            parking1.Size = new Size(459, 243);
            parking1.TabIndex = 0;
            // 
            // lbl_welcome_user
            // 
            lbl_welcome_user.AutoSize = true;
            lbl_welcome_user.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_welcome_user.Location = new Point(503, 17);
            lbl_welcome_user.Name = "lbl_welcome_user";
            lbl_welcome_user.Size = new Size(278, 46);
            lbl_welcome_user.TabIndex = 0;
            lbl_welcome_user.Text = "Welcome : USER";
            // 
            // tab_history
            // 
            tab_history.BackColor = Color.White;
            tab_history.Controls.Add(materialButton2);
            tab_history.Controls.Add(lv_parking_history);
            tab_history.Controls.Add(label4);
            tab_history.ImageKey = "settings.png";
            tab_history.Location = new Point(4, 39);
            tab_history.Margin = new Padding(2);
            tab_history.Name = "tab_history";
            tab_history.Padding = new Padding(2);
            tab_history.Size = new Size(1454, 792);
            tab_history.TabIndex = 1;
            tab_history.Text = "History";
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.BackColor = SystemColors.Control;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton2.ForeColor = SystemColors.ControlText;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(177, 670);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(119, 38);
            materialButton2.TabIndex = 31;
            materialButton2.Text = "Refresh";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            // 
            // lv_parking_history
            // 
            lv_parking_history.AutoSizeTable = false;
            lv_parking_history.BackColor = Color.FromArgb(255, 255, 255);
            lv_parking_history.BorderStyle = BorderStyle.None;
            lv_parking_history.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lv_parking_history.Depth = 0;
            lv_parking_history.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lv_parking_history.FullRowSelect = true;
            lv_parking_history.Location = new Point(77, 123);
            lv_parking_history.MinimumSize = new Size(200, 100);
            lv_parking_history.MouseLocation = new Point(-1, -1);
            lv_parking_history.MouseState = MaterialSkin.MouseState.OUT;
            lv_parking_history.Name = "lv_parking_history";
            lv_parking_history.OwnerDraw = true;
            lv_parking_history.Size = new Size(1359, 538);
            lv_parking_history.TabIndex = 5;
            lv_parking_history.UseCompatibleStateImageBehavior = false;
            lv_parking_history.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Vehicle Type";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Driver Name";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Driver Mobile";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "In Time";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Out Time";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Amount";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Status";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "CreatedBy";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "ModifiedBy";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "CreatedAt";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 150;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(575, 29);
            label4.Name = "label4";
            label4.Size = new Size(270, 46);
            label4.TabIndex = 1;
            label4.Text = "Parking History";
            // 
            // tab_settings
            // 
            tab_settings.Controls.Add(groupBox3);
            tab_settings.Controls.Add(groupBox2);
            tab_settings.Location = new Point(4, 39);
            tab_settings.Name = "tab_settings";
            tab_settings.Padding = new Padding(3);
            tab_settings.Size = new Size(1454, 792);
            tab_settings.TabIndex = 3;
            tab_settings.Text = "Settings";
            tab_settings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialButton1);
            groupBox3.Location = new Point(765, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(408, 339);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Manage";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = SystemColors.Control;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton1.ForeColor = SystemColors.ControlText;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(130, 131);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(119, 38);
            materialButton1.TabIndex = 30;
            materialButton1.Text = "User Manager";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_settings_currency_symbol);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_settings_hourly_rate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_settings_first_hour_rate);
            groupBox2.Controls.Add(btn_update_settings);
            groupBox2.Location = new Point(159, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 339);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 212);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 29;
            label3.Text = "Currency Symbol";
            // 
            // txt_settings_currency_symbol
            // 
            txt_settings_currency_symbol.AnimateReadOnly = false;
            txt_settings_currency_symbol.BackgroundImageLayout = ImageLayout.None;
            txt_settings_currency_symbol.CharacterCasing = CharacterCasing.Normal;
            txt_settings_currency_symbol.Depth = 0;
            txt_settings_currency_symbol.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_currency_symbol.HideSelection = true;
            txt_settings_currency_symbol.LeadingIcon = null;
            txt_settings_currency_symbol.Location = new Point(136, 196);
            txt_settings_currency_symbol.MaxLength = 32767;
            txt_settings_currency_symbol.MouseState = MaterialSkin.MouseState.OUT;
            txt_settings_currency_symbol.Name = "txt_settings_currency_symbol";
            txt_settings_currency_symbol.PasswordChar = '\0';
            txt_settings_currency_symbol.PrefixSuffixText = null;
            txt_settings_currency_symbol.ReadOnly = false;
            txt_settings_currency_symbol.RightToLeft = RightToLeft.No;
            txt_settings_currency_symbol.SelectedText = "";
            txt_settings_currency_symbol.SelectionLength = 0;
            txt_settings_currency_symbol.SelectionStart = 0;
            txt_settings_currency_symbol.ShortcutsEnabled = true;
            txt_settings_currency_symbol.Size = new Size(269, 48);
            txt_settings_currency_symbol.TabIndex = 28;
            txt_settings_currency_symbol.TabStop = false;
            txt_settings_currency_symbol.TextAlign = HorizontalAlignment.Left;
            txt_settings_currency_symbol.TrailingIcon = null;
            txt_settings_currency_symbol.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 27;
            label2.Text = "Hourly Rate";
            // 
            // txt_settings_hourly_rate
            // 
            txt_settings_hourly_rate.AnimateReadOnly = false;
            txt_settings_hourly_rate.BackgroundImageLayout = ImageLayout.None;
            txt_settings_hourly_rate.CharacterCasing = CharacterCasing.Normal;
            txt_settings_hourly_rate.Depth = 0;
            txt_settings_hourly_rate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_hourly_rate.HideSelection = true;
            txt_settings_hourly_rate.LeadingIcon = null;
            txt_settings_hourly_rate.Location = new Point(136, 108);
            txt_settings_hourly_rate.MaxLength = 32767;
            txt_settings_hourly_rate.MouseState = MaterialSkin.MouseState.OUT;
            txt_settings_hourly_rate.Name = "txt_settings_hourly_rate";
            txt_settings_hourly_rate.PasswordChar = '\0';
            txt_settings_hourly_rate.PrefixSuffixText = null;
            txt_settings_hourly_rate.ReadOnly = false;
            txt_settings_hourly_rate.RightToLeft = RightToLeft.No;
            txt_settings_hourly_rate.SelectedText = "";
            txt_settings_hourly_rate.SelectionLength = 0;
            txt_settings_hourly_rate.SelectionStart = 0;
            txt_settings_hourly_rate.ShortcutsEnabled = true;
            txt_settings_hourly_rate.Size = new Size(269, 48);
            txt_settings_hourly_rate.TabIndex = 26;
            txt_settings_hourly_rate.TabStop = false;
            txt_settings_hourly_rate.TextAlign = HorizontalAlignment.Left;
            txt_settings_hourly_rate.TrailingIcon = null;
            txt_settings_hourly_rate.UseSystemPasswordChar = false;
            txt_settings_hourly_rate.KeyPress += text_allow_decimal_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 25;
            label1.Text = "First Hour Rate";
            // 
            // txt_settings_first_hour_rate
            // 
            txt_settings_first_hour_rate.AnimateReadOnly = false;
            txt_settings_first_hour_rate.BackgroundImageLayout = ImageLayout.None;
            txt_settings_first_hour_rate.CharacterCasing = CharacterCasing.Normal;
            txt_settings_first_hour_rate.Depth = 0;
            txt_settings_first_hour_rate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_first_hour_rate.HideSelection = true;
            txt_settings_first_hour_rate.LeadingIcon = null;
            txt_settings_first_hour_rate.Location = new Point(136, 28);
            txt_settings_first_hour_rate.MaxLength = 32767;
            txt_settings_first_hour_rate.MouseState = MaterialSkin.MouseState.OUT;
            txt_settings_first_hour_rate.Name = "txt_settings_first_hour_rate";
            txt_settings_first_hour_rate.PasswordChar = '\0';
            txt_settings_first_hour_rate.PrefixSuffixText = null;
            txt_settings_first_hour_rate.ReadOnly = false;
            txt_settings_first_hour_rate.RightToLeft = RightToLeft.No;
            txt_settings_first_hour_rate.SelectedText = "";
            txt_settings_first_hour_rate.SelectionLength = 0;
            txt_settings_first_hour_rate.SelectionStart = 0;
            txt_settings_first_hour_rate.ShortcutsEnabled = true;
            txt_settings_first_hour_rate.Size = new Size(269, 48);
            txt_settings_first_hour_rate.TabIndex = 5;
            txt_settings_first_hour_rate.TabStop = false;
            txt_settings_first_hour_rate.TextAlign = HorizontalAlignment.Left;
            txt_settings_first_hour_rate.TrailingIcon = null;
            txt_settings_first_hour_rate.UseSystemPasswordChar = false;
            txt_settings_first_hour_rate.KeyPress += text_allow_decimal_KeyPress;
            // 
            // btn_update_settings
            // 
            btn_update_settings.AutoSize = false;
            btn_update_settings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_update_settings.BackColor = SystemColors.Control;
            btn_update_settings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_update_settings.Depth = 0;
            btn_update_settings.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_update_settings.ForeColor = SystemColors.ControlText;
            btn_update_settings.HighEmphasis = true;
            btn_update_settings.Icon = null;
            btn_update_settings.Location = new Point(159, 281);
            btn_update_settings.Margin = new Padding(4, 6, 4, 6);
            btn_update_settings.MouseState = MaterialSkin.MouseState.HOVER;
            btn_update_settings.Name = "btn_update_settings";
            btn_update_settings.NoAccentTextColor = Color.Empty;
            btn_update_settings.Size = new Size(119, 38);
            btn_update_settings.TabIndex = 24;
            btn_update_settings.Text = "Update";
            btn_update_settings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_update_settings.UseAccentColor = false;
            btn_update_settings.UseVisualStyleBackColor = false;
            btn_update_settings.Click += btn_update_settings_Click;
            // 
            // frm_dashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1505, 948);
            Controls.Add(materialTabControl1);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerUseColors = true;
            Margin = new Padding(2);
            Name = "frm_dashboard";
            Padding = new Padding(0, 64, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashbaord";
            Load += frm_dashboard_Load;
            materialTabControl1.ResumeLayout(false);
            tab_home.ResumeLayout(false);
            tab_home.PerformLayout();
            groupBox1.ResumeLayout(false);
            tab_history.ResumeLayout(false);
            tab_settings.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tab_history;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TabPage tab_settings;
        private MaterialSkin.Controls.MaterialTextBox2 txt_settings_first_hour_rate;
        private MaterialSkin.Controls.MaterialButton btn_update_settings;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 txt_settings_currency_symbol;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_settings_hourly_rate;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label lbl_welcome_user;
        private GroupBox groupBox1;
        private Button button1;
        private Components.Parking parking1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private Label label4;
        private MaterialSkin.Controls.MaterialListView lv_parking_history;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

