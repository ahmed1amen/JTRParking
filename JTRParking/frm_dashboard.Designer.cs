using MaterialSkin.Controls;

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
            imageList1 = new ImageList(components);
            materialTabControl1 = new MaterialTabControl();
            tab_home = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_welcome_user = new MaterialLabel();
            lbl_date_time_now = new MaterialLabel();
            groupBox_find_vehicle = new GroupBox();
            txt_barcode = new MaterialTextBox2();
            groupBox_add_parking = new GroupBox();
            parking1 = new JTRParking.Components.ParkingComponent();
            groupBox_manage_parking = new GroupBox();
            btn_end_my_shift = new MaterialButton();
            materialButton3 = new MaterialButton();
            myListView = new ListView();
            contextMenuStrip1 = new MaterialContextMenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem1 = new ToolStripMenuItem();
            parking_imageList = new ImageList(components);
            tab_history = new TabPage();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            lbl_total_amount = new MaterialLabel();
            materialButton2 = new MaterialButton();
            lv_parking_history = new MaterialListView();
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
            materialLabel1 = new MaterialLabel();
            materialButton4 = new MaterialButton();
            tab_settings = new TabPage();
            groupBox2 = new GroupBox();
            materialExpansionPanel2 = new MaterialExpansionPanel();
            materialButton1 = new MaterialButton();
            materialExpansionPanel1 = new MaterialExpansionPanel();
            label4 = new Label();
            txt_allowed_minutes = new MaterialTextBox2();
            txt_settings_parking_ticket_header_sub_title = new MaterialMultiLineTextBox2();
            label6 = new Label();
            label5 = new Label();
            txt_settings_parking_ticket_header_title = new MaterialTextBox2();
            label3 = new Label();
            btn_update_settings = new MaterialButton();
            txt_settings_currency_symbol = new MaterialTextBox2();
            txt_settings_first_hour_rate = new MaterialTextBox2();
            label2 = new Label();
            label1 = new Label();
            txt_settings_hourly_rate = new MaterialTextBox2();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            timer_date_now = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            materialTabControl1.SuspendLayout();
            tab_home.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox_find_vehicle.SuspendLayout();
            groupBox_add_parking.SuspendLayout();
            groupBox_manage_parking.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tab_history.SuspendLayout();
            tab_settings.SuspendLayout();
            groupBox2.SuspendLayout();
            materialExpansionPanel2.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "history.png");
            imageList1.Images.SetKeyName(2, "settings.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tab_home);
            materialTabControl1.Controls.Add(tab_history);
            materialTabControl1.Controls.Add(tab_settings);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(0, 51);
            materialTabControl1.Margin = new Padding(2);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1231, 710);
            materialTabControl1.TabIndex = 1;
            // 
            // tab_home
            // 
            tab_home.BackColor = Color.White;
            tab_home.Controls.Add(tableLayoutPanel1);
            tab_home.Controls.Add(groupBox_find_vehicle);
            tab_home.Controls.Add(groupBox_add_parking);
            tab_home.Controls.Add(groupBox_manage_parking);
            tab_home.ImageKey = "home.png";
            tab_home.Location = new Point(4, 39);
            tab_home.Margin = new Padding(2);
            tab_home.Name = "tab_home";
            tab_home.Padding = new Padding(2);
            tab_home.Size = new Size(1223, 667);
            tab_home.TabIndex = 0;
            tab_home.Text = "Home";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.90244F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.09756F));
            tableLayoutPanel1.Controls.Add(lbl_welcome_user, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_date_time_now, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1219, 70);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // lbl_welcome_user
            // 
            lbl_welcome_user.Depth = 0;
            lbl_welcome_user.Dock = DockStyle.Fill;
            lbl_welcome_user.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_welcome_user.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lbl_welcome_user.HighEmphasis = true;
            lbl_welcome_user.Location = new Point(2, 0);
            lbl_welcome_user.Margin = new Padding(2, 0, 2, 0);
            lbl_welcome_user.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_welcome_user.Name = "lbl_welcome_user";
            lbl_welcome_user.Size = new Size(579, 70);
            lbl_welcome_user.TabIndex = 6;
            lbl_welcome_user.Text = "Welcome : Admin";
            // 
            // lbl_date_time_now
            // 
            lbl_date_time_now.Depth = 0;
            lbl_date_time_now.Dock = DockStyle.Fill;
            lbl_date_time_now.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbl_date_time_now.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lbl_date_time_now.HighEmphasis = true;
            lbl_date_time_now.Location = new Point(585, 0);
            lbl_date_time_now.Margin = new Padding(2, 0, 2, 0);
            lbl_date_time_now.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_date_time_now.Name = "lbl_date_time_now";
            lbl_date_time_now.Size = new Size(632, 70);
            lbl_date_time_now.TabIndex = 7;
            lbl_date_time_now.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox_find_vehicle
            // 
            groupBox_find_vehicle.Controls.Add(txt_barcode);
            groupBox_find_vehicle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_find_vehicle.Location = new Point(10, 93);
            groupBox_find_vehicle.Margin = new Padding(2);
            groupBox_find_vehicle.Name = "groupBox_find_vehicle";
            groupBox_find_vehicle.Padding = new Padding(2);
            groupBox_find_vehicle.Size = new Size(451, 86);
            groupBox_find_vehicle.TabIndex = 26;
            groupBox_find_vehicle.TabStop = false;
            groupBox_find_vehicle.Text = "Find Vehicle";
            // 
            // txt_barcode
            // 
            txt_barcode.AnimateReadOnly = false;
            txt_barcode.BackgroundImageLayout = ImageLayout.None;
            txt_barcode.CharacterCasing = CharacterCasing.Normal;
            txt_barcode.Depth = 0;
            txt_barcode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_barcode.HideSelection = false;
            txt_barcode.Hint = "Enter Barcode To Search";
            txt_barcode.LeadingIcon = (Image)resources.GetObject("txt_barcode.LeadingIcon");
            txt_barcode.Location = new Point(14, 32);
            txt_barcode.Margin = new Padding(2);
            txt_barcode.MaxLength = 32767;
            txt_barcode.MouseState = MaterialSkin.MouseState.OUT;
            txt_barcode.Name = "txt_barcode";
            txt_barcode.PasswordChar = '\0';
            txt_barcode.PrefixSuffixText = null;
            txt_barcode.ReadOnly = false;
            txt_barcode.RightToLeft = RightToLeft.No;
            txt_barcode.SelectedText = "";
            txt_barcode.SelectionLength = 0;
            txt_barcode.SelectionStart = 0;
            txt_barcode.ShortcutsEnabled = true;
            txt_barcode.Size = new Size(408, 48);
            txt_barcode.TabIndex = 27;
            txt_barcode.TabStop = false;
            txt_barcode.TextAlign = HorizontalAlignment.Center;
            txt_barcode.TrailingIcon = null;
            txt_barcode.UseSystemPasswordChar = false;
            txt_barcode.Click += materialTextBox21_Click;
            txt_barcode.KeyDown += materialTextBox21_KeyDown;
            // 
            // groupBox_add_parking
            // 
            groupBox_add_parking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox_add_parking.Controls.Add(parking1);
            groupBox_add_parking.Location = new Point(10, 179);
            groupBox_add_parking.Margin = new Padding(2);
            groupBox_add_parking.Name = "groupBox_add_parking";
            groupBox_add_parking.Padding = new Padding(2);
            groupBox_add_parking.Size = new Size(451, 476);
            groupBox_add_parking.TabIndex = 3;
            groupBox_add_parking.TabStop = false;
            groupBox_add_parking.Text = "Park";
            // 
            // parking1
            // 
            parking1.Dock = DockStyle.Fill;
            parking1.Location = new Point(2, 18);
            parking1.Margin = new Padding(2, 3, 2, 3);
            parking1.Name = "parking1";
            parking1.Size = new Size(447, 456);
            parking1.TabIndex = 0;
            parking1.Load += parking1_Load;
            // 
            // groupBox_manage_parking
            // 
            groupBox_manage_parking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_manage_parking.Controls.Add(btn_end_my_shift);
            groupBox_manage_parking.Controls.Add(materialButton3);
            groupBox_manage_parking.Controls.Add(myListView);
            groupBox_manage_parking.Location = new Point(465, 105);
            groupBox_manage_parking.Margin = new Padding(2);
            groupBox_manage_parking.Name = "groupBox_manage_parking";
            groupBox_manage_parking.Padding = new Padding(2);
            groupBox_manage_parking.Size = new Size(746, 548);
            groupBox_manage_parking.TabIndex = 27;
            groupBox_manage_parking.TabStop = false;
            groupBox_manage_parking.Text = "Manage Parking";
            // 
            // btn_end_my_shift
            // 
            btn_end_my_shift.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_end_my_shift.AutoSize = false;
            btn_end_my_shift.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_end_my_shift.BackColor = SystemColors.Control;
            btn_end_my_shift.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_end_my_shift.Depth = 0;
            btn_end_my_shift.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_end_my_shift.ForeColor = SystemColors.ControlText;
            btn_end_my_shift.HighEmphasis = true;
            btn_end_my_shift.Icon = null;
            btn_end_my_shift.Location = new Point(6, 495);
            btn_end_my_shift.Margin = new Padding(3, 5, 3, 5);
            btn_end_my_shift.MouseState = MaterialSkin.MouseState.HOVER;
            btn_end_my_shift.Name = "btn_end_my_shift";
            btn_end_my_shift.NoAccentTextColor = Color.Empty;
            btn_end_my_shift.Size = new Size(112, 38);
            btn_end_my_shift.TabIndex = 26;
            btn_end_my_shift.Text = "End My Shift";
            btn_end_my_shift.Type = MaterialButton.MaterialButtonType.Contained;
            btn_end_my_shift.UseAccentColor = true;
            btn_end_my_shift.UseVisualStyleBackColor = false;
            btn_end_my_shift.Click += btn_end_my_shift_Click;
            // 
            // materialButton3
            // 
            materialButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = SystemColors.Control;
            materialButton3.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton3.ForeColor = SystemColors.ControlText;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(617, 495);
            materialButton3.Margin = new Padding(3, 5, 3, 5);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(126, 38);
            materialButton3.TabIndex = 25;
            materialButton3.Text = "Refresh";
            materialButton3.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = true;
            materialButton3.UseVisualStyleBackColor = false;
            materialButton3.Click += materialButton3_Click;
            // 
            // myListView
            // 
            myListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myListView.BackColor = Color.FloralWhite;
            myListView.BorderStyle = BorderStyle.None;
            myListView.ContextMenuStrip = contextMenuStrip1;
            myListView.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            myListView.LargeImageList = parking_imageList;
            myListView.Location = new Point(6, 27);
            myListView.Margin = new Padding(2);
            myListView.MultiSelect = false;
            myListView.Name = "myListView";
            myListView.Size = new Size(737, 461);
            myListView.SmallImageList = parking_imageList;
            myListView.TabIndex = 5;
            myListView.UseCompatibleStateImageBehavior = false;
            myListView.SelectedIndexChanged += myListView_SelectedIndexChanged;
            myListView.MouseDoubleClick += myListView_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            contextMenuStrip1.Depth = 0;
            contextMenuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, testToolStripMenuItem1 });
            contextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(200, 72);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(199, 34);
            testToolStripMenuItem.Text = "Show Info";
            // 
            // testToolStripMenuItem1
            // 
            testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            testToolStripMenuItem1.Size = new Size(199, 34);
            testToolStripMenuItem1.Text = "End Parking";
            // 
            // parking_imageList
            // 
            parking_imageList.ColorDepth = ColorDepth.Depth32Bit;
            parking_imageList.ImageStream = (ImageListStreamer)resources.GetObject("parking_imageList.ImageStream");
            parking_imageList.TransparentColor = Color.Transparent;
            parking_imageList.Images.SetKeyName(0, "motor.png");
            parking_imageList.Images.SetKeyName(1, "car.png");
            // 
            // tab_history
            // 
            tab_history.BackColor = Color.White;
            tab_history.Controls.Add(dateTimePickerStart);
            tab_history.Controls.Add(dateTimePickerEnd);
            tab_history.Controls.Add(label7);
            tab_history.Controls.Add(label8);
            tab_history.Controls.Add(lbl_total_amount);
            tab_history.Controls.Add(materialButton2);
            tab_history.Controls.Add(lv_parking_history);
            tab_history.Controls.Add(materialLabel1);
            tab_history.Controls.Add(materialButton4);
            tab_history.ImageKey = "history.png";
            tab_history.Location = new Point(4, 39);
            tab_history.Margin = new Padding(2);
            tab_history.Name = "tab_history";
            tab_history.Padding = new Padding(2);
            tab_history.Size = new Size(1223, 667);
            tab_history.TabIndex = 1;
            tab_history.Text = "History";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(189, 638);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(152, 23);
            dateTimePickerStart.TabIndex = 35;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(374, 638);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(152, 23);
            dateTimePickerEnd.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(147, 643);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 37;
            label7.Text = "From";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(349, 643);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 38;
            label8.Text = "To";
            // 
            // lbl_total_amount
            // 
            lbl_total_amount.Depth = 0;
            lbl_total_amount.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbl_total_amount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lbl_total_amount.HighEmphasis = true;
            lbl_total_amount.Location = new Point(566, 630);
            lbl_total_amount.Margin = new Padding(2, 0, 2, 0);
            lbl_total_amount.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_total_amount.Name = "lbl_total_amount";
            lbl_total_amount.Size = new Size(438, 40);
            lbl_total_amount.TabIndex = 34;
            lbl_total_amount.TextAlign = ContentAlignment.TopCenter;
            lbl_total_amount.UseAccent = true;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.BackColor = SystemColors.Control;
            materialButton2.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton2.ForeColor = SystemColors.ControlText;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(5, 634);
            materialButton2.Margin = new Padding(3, 5, 3, 5);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(128, 33);
            materialButton2.TabIndex = 31;
            materialButton2.Text = "Refresh";
            materialButton2.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            materialButton2.Click += materialButton2_Click;
            // 
            // lv_parking_history
            // 
            lv_parking_history.AutoSizeTable = false;
            lv_parking_history.BackColor = Color.FromArgb(255, 255, 255);
            lv_parking_history.BorderStyle = BorderStyle.None;
            lv_parking_history.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lv_parking_history.Depth = 0;
            lv_parking_history.Dock = DockStyle.Top;
            lv_parking_history.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lv_parking_history.FullRowSelect = true;
            lv_parking_history.Location = new Point(2, 26);
            lv_parking_history.Margin = new Padding(2);
            lv_parking_history.MinimumSize = new Size(160, 80);
            lv_parking_history.MouseLocation = new Point(-1, -1);
            lv_parking_history.MouseState = MaterialSkin.MouseState.OUT;
            lv_parking_history.Name = "lv_parking_history";
            lv_parking_history.OwnerDraw = true;
            lv_parking_history.Size = new Size(1219, 599);
            lv_parking_history.TabIndex = 3;
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(2, 2);
            materialLabel1.Margin = new Padding(2, 0, 2, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(138, 24);
            materialLabel1.TabIndex = 32;
            materialLabel1.Text = "Parking History";
            materialLabel1.UseAccent = true;
            // 
            // materialButton4
            // 
            materialButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.BackColor = SystemColors.Control;
            materialButton4.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton4.ForeColor = SystemColors.ControlText;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(1108, 626);
            materialButton4.Margin = new Padding(3, 5, 3, 5);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(112, 33);
            materialButton4.TabIndex = 33;
            materialButton4.Text = "Reports";
            materialButton4.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = false;
            materialButton4.Click += materialButton4_Click_1;
            // 
            // tab_settings
            // 
            tab_settings.Controls.Add(groupBox2);
            tab_settings.ImageKey = "settings.png";
            tab_settings.Location = new Point(4, 39);
            tab_settings.Margin = new Padding(2);
            tab_settings.Name = "tab_settings";
            tab_settings.Padding = new Padding(2);
            tab_settings.Size = new Size(1223, 667);
            tab_settings.TabIndex = 3;
            tab_settings.Text = "Settings";
            tab_settings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(materialExpansionPanel2);
            groupBox2.Controls.Add(materialExpansionPanel1);
            groupBox2.Location = new Point(22, 36);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1173, 588);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // materialExpansionPanel2
            // 
            materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel2.CancelButtonText = "";
            materialExpansionPanel2.Controls.Add(materialButton1);
            materialExpansionPanel2.Depth = 0;
            materialExpansionPanel2.Description = "";
            materialExpansionPanel2.ExpandHeight = 547;
            materialExpansionPanel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel2.Location = new Point(776, 14);
            materialExpansionPanel2.Margin = new Padding(13);
            materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel2.Name = "materialExpansionPanel2";
            materialExpansionPanel2.Padding = new Padding(19, 51, 19, 13);
            materialExpansionPanel2.ShowCollapseExpand = false;
            materialExpansionPanel2.Size = new Size(382, 547);
            materialExpansionPanel2.TabIndex = 31;
            materialExpansionPanel2.Title = "Manage";
            materialExpansionPanel2.ValidationButtonText = "";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = SystemColors.Control;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton1.ForeColor = SystemColors.ControlText;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(22, 61);
            materialButton1.Margin = new Padding(3, 5, 3, 5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(125, 57);
            materialButton1.TabIndex = 30;
            materialButton1.Text = "User Manager";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click_1;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "";
            materialExpansionPanel1.Controls.Add(label4);
            materialExpansionPanel1.Controls.Add(txt_allowed_minutes);
            materialExpansionPanel1.Controls.Add(txt_settings_parking_ticket_header_sub_title);
            materialExpansionPanel1.Controls.Add(label6);
            materialExpansionPanel1.Controls.Add(label5);
            materialExpansionPanel1.Controls.Add(txt_settings_parking_ticket_header_title);
            materialExpansionPanel1.Controls.Add(label3);
            materialExpansionPanel1.Controls.Add(btn_update_settings);
            materialExpansionPanel1.Controls.Add(txt_settings_currency_symbol);
            materialExpansionPanel1.Controls.Add(txt_settings_first_hour_rate);
            materialExpansionPanel1.Controls.Add(label2);
            materialExpansionPanel1.Controls.Add(label1);
            materialExpansionPanel1.Controls.Add(txt_settings_hourly_rate);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "";
            materialExpansionPanel1.ExpandHeight = 539;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(11, 34);
            materialExpansionPanel1.Margin = new Padding(16);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(19, 51, 19, 13);
            materialExpansionPanel1.ShowCollapseExpand = false;
            materialExpansionPanel1.Size = new Size(484, 539);
            materialExpansionPanel1.TabIndex = 30;
            materialExpansionPanel1.Title = "General Settings";
            materialExpansionPanel1.ValidationButtonText = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 36;
            label4.Text = "Allowed Minutes \r\nAfter First Hour";
            // 
            // txt_allowed_minutes
            // 
            txt_allowed_minutes.AnimateReadOnly = false;
            txt_allowed_minutes.BackgroundImageLayout = ImageLayout.None;
            txt_allowed_minutes.CharacterCasing = CharacterCasing.Normal;
            txt_allowed_minutes.Depth = 0;
            txt_allowed_minutes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_allowed_minutes.HideSelection = true;
            txt_allowed_minutes.LeadingIcon = null;
            txt_allowed_minutes.Location = new Point(177, 154);
            txt_allowed_minutes.Margin = new Padding(2);
            txt_allowed_minutes.MaxLength = 32767;
            txt_allowed_minutes.MouseState = MaterialSkin.MouseState.OUT;
            txt_allowed_minutes.Name = "txt_allowed_minutes";
            txt_allowed_minutes.PasswordChar = '\0';
            txt_allowed_minutes.PrefixSuffixText = null;
            txt_allowed_minutes.ReadOnly = false;
            txt_allowed_minutes.RightToLeft = RightToLeft.No;
            txt_allowed_minutes.SelectedText = "";
            txt_allowed_minutes.SelectionLength = 0;
            txt_allowed_minutes.SelectionStart = 0;
            txt_allowed_minutes.ShortcutsEnabled = true;
            txt_allowed_minutes.Size = new Size(244, 48);
            txt_allowed_minutes.TabIndex = 35;
            txt_allowed_minutes.TabStop = false;
            txt_allowed_minutes.TextAlign = HorizontalAlignment.Left;
            txt_allowed_minutes.TrailingIcon = null;
            txt_allowed_minutes.UseSystemPasswordChar = false;
            // 
            // txt_settings_parking_ticket_header_sub_title
            // 
            txt_settings_parking_ticket_header_sub_title.AnimateReadOnly = false;
            txt_settings_parking_ticket_header_sub_title.BackgroundImageLayout = ImageLayout.None;
            txt_settings_parking_ticket_header_sub_title.CharacterCasing = CharacterCasing.Normal;
            txt_settings_parking_ticket_header_sub_title.Depth = 0;
            txt_settings_parking_ticket_header_sub_title.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_parking_ticket_header_sub_title.HideSelection = true;
            txt_settings_parking_ticket_header_sub_title.Location = new Point(177, 323);
            txt_settings_parking_ticket_header_sub_title.Margin = new Padding(2);
            txt_settings_parking_ticket_header_sub_title.MaxLength = 32767;
            txt_settings_parking_ticket_header_sub_title.MouseState = MaterialSkin.MouseState.OUT;
            txt_settings_parking_ticket_header_sub_title.Name = "txt_settings_parking_ticket_header_sub_title";
            txt_settings_parking_ticket_header_sub_title.PasswordChar = '\0';
            txt_settings_parking_ticket_header_sub_title.ReadOnly = false;
            txt_settings_parking_ticket_header_sub_title.ScrollBars = ScrollBars.None;
            txt_settings_parking_ticket_header_sub_title.SelectedText = "";
            txt_settings_parking_ticket_header_sub_title.SelectionLength = 0;
            txt_settings_parking_ticket_header_sub_title.SelectionStart = 0;
            txt_settings_parking_ticket_header_sub_title.ShortcutsEnabled = true;
            txt_settings_parking_ticket_header_sub_title.Size = new Size(245, 94);
            txt_settings_parking_ticket_header_sub_title.TabIndex = 34;
            txt_settings_parking_ticket_header_sub_title.TabStop = false;
            txt_settings_parking_ticket_header_sub_title.TextAlign = HorizontalAlignment.Left;
            txt_settings_parking_ticket_header_sub_title.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(2, 356);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 33;
            label6.Text = "Ticket Header SubTitle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 279);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 31;
            label5.Text = "Ticket Header Title";
            // 
            // txt_settings_parking_ticket_header_title
            // 
            txt_settings_parking_ticket_header_title.AnimateReadOnly = false;
            txt_settings_parking_ticket_header_title.BackgroundImageLayout = ImageLayout.None;
            txt_settings_parking_ticket_header_title.CharacterCasing = CharacterCasing.Normal;
            txt_settings_parking_ticket_header_title.Depth = 0;
            txt_settings_parking_ticket_header_title.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_parking_ticket_header_title.HideSelection = true;
            txt_settings_parking_ticket_header_title.LeadingIcon = null;
            txt_settings_parking_ticket_header_title.Location = new Point(178, 265);
            txt_settings_parking_ticket_header_title.Margin = new Padding(2);
            txt_settings_parking_ticket_header_title.MaxLength = 32767;
            txt_settings_parking_ticket_header_title.MouseState = MaterialSkin.MouseState.OUT;
            txt_settings_parking_ticket_header_title.Name = "txt_settings_parking_ticket_header_title";
            txt_settings_parking_ticket_header_title.PasswordChar = '\0';
            txt_settings_parking_ticket_header_title.PrefixSuffixText = null;
            txt_settings_parking_ticket_header_title.ReadOnly = false;
            txt_settings_parking_ticket_header_title.RightToLeft = RightToLeft.No;
            txt_settings_parking_ticket_header_title.SelectedText = "";
            txt_settings_parking_ticket_header_title.SelectionLength = 0;
            txt_settings_parking_ticket_header_title.SelectionStart = 0;
            txt_settings_parking_ticket_header_title.ShortcutsEnabled = true;
            txt_settings_parking_ticket_header_title.Size = new Size(244, 48);
            txt_settings_parking_ticket_header_title.TabIndex = 30;
            txt_settings_parking_ticket_header_title.TabStop = false;
            txt_settings_parking_ticket_header_title.TextAlign = HorizontalAlignment.Left;
            txt_settings_parking_ticket_header_title.TrailingIcon = null;
            txt_settings_parking_ticket_header_title.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 220);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 29;
            label3.Text = "Currency Symbol";
            // 
            // btn_update_settings
            // 
            btn_update_settings.AutoSize = false;
            btn_update_settings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_update_settings.BackColor = SystemColors.Control;
            btn_update_settings.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_update_settings.Depth = 0;
            btn_update_settings.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_update_settings.ForeColor = SystemColors.ControlText;
            btn_update_settings.HighEmphasis = true;
            btn_update_settings.Icon = null;
            btn_update_settings.Location = new Point(159, 483);
            btn_update_settings.Margin = new Padding(3, 5, 3, 5);
            btn_update_settings.MouseState = MaterialSkin.MouseState.HOVER;
            btn_update_settings.Name = "btn_update_settings";
            btn_update_settings.NoAccentTextColor = Color.Empty;
            btn_update_settings.Size = new Size(116, 44);
            btn_update_settings.TabIndex = 24;
            btn_update_settings.Text = "SAVE";
            btn_update_settings.Type = MaterialButton.MaterialButtonType.Contained;
            btn_update_settings.UseAccentColor = true;
            btn_update_settings.UseVisualStyleBackColor = false;
            btn_update_settings.Click += btn_update_settings_Click;
            // 
            // txt_settings_currency_symbol
            // 
            txt_settings_currency_symbol.AnimateReadOnly = false;
            txt_settings_currency_symbol.BackgroundImageLayout = ImageLayout.None;
            txt_settings_currency_symbol.CharacterCasing = CharacterCasing.Normal;
            txt_settings_currency_symbol.Depth = 0;
            txt_settings_currency_symbol.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_currency_symbol.HideSelection = true;
            txt_settings_currency_symbol.LeadingIcon = null;
            txt_settings_currency_symbol.Location = new Point(178, 206);
            txt_settings_currency_symbol.Margin = new Padding(2);
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
            txt_settings_currency_symbol.Size = new Size(244, 48);
            txt_settings_currency_symbol.TabIndex = 28;
            txt_settings_currency_symbol.TabStop = false;
            txt_settings_currency_symbol.TextAlign = HorizontalAlignment.Left;
            txt_settings_currency_symbol.TrailingIcon = null;
            txt_settings_currency_symbol.UseSystemPasswordChar = false;
            // 
            // txt_settings_first_hour_rate
            // 
            txt_settings_first_hour_rate.AnimateReadOnly = false;
            txt_settings_first_hour_rate.BackgroundImageLayout = ImageLayout.None;
            txt_settings_first_hour_rate.CharacterCasing = CharacterCasing.Normal;
            txt_settings_first_hour_rate.Depth = 0;
            txt_settings_first_hour_rate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_first_hour_rate.HideSelection = true;
            txt_settings_first_hour_rate.LeadingIcon = null;
            txt_settings_first_hour_rate.Location = new Point(178, 41);
            txt_settings_first_hour_rate.Margin = new Padding(2);
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
            txt_settings_first_hour_rate.Size = new Size(244, 48);
            txt_settings_first_hour_rate.TabIndex = 5;
            txt_settings_first_hour_rate.TabStop = false;
            txt_settings_first_hour_rate.TextAlign = HorizontalAlignment.Left;
            txt_settings_first_hour_rate.TrailingIcon = null;
            txt_settings_first_hour_rate.UseSystemPasswordChar = false;
            txt_settings_first_hour_rate.KeyPress += text_allow_decimal_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 27;
            label2.Text = "Hourly Rate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 25;
            label1.Text = "First Hour Rate";
            // 
            // txt_settings_hourly_rate
            // 
            txt_settings_hourly_rate.AnimateReadOnly = false;
            txt_settings_hourly_rate.BackgroundImageLayout = ImageLayout.None;
            txt_settings_hourly_rate.CharacterCasing = CharacterCasing.Normal;
            txt_settings_hourly_rate.Depth = 0;
            txt_settings_hourly_rate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_settings_hourly_rate.HideSelection = true;
            txt_settings_hourly_rate.LeadingIcon = null;
            txt_settings_hourly_rate.Location = new Point(178, 100);
            txt_settings_hourly_rate.Margin = new Padding(2);
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
            txt_settings_hourly_rate.Size = new Size(244, 48);
            txt_settings_hourly_rate.TabIndex = 26;
            txt_settings_hourly_rate.TabStop = false;
            txt_settings_hourly_rate.TextAlign = HorizontalAlignment.Left;
            txt_settings_hourly_rate.TrailingIcon = null;
            txt_settings_hourly_rate.UseSystemPasswordChar = false;
            txt_settings_hourly_rate.KeyPress += text_allow_decimal_KeyPress;
            // 
            // timer_date_now
            // 
            timer_date_now.Enabled = true;
            timer_date_now.Interval = 1000;
            timer_date_now.Tick += timer_date_now_Tick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            // 
            // timer3
            // 
            timer3.Interval = 3000;
            timer3.Tick += timer3_Tick;
            // 
            // frm_dashboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1233, 763);
            Controls.Add(materialTabControl1);
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerUseColors = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frm_dashboard";
            Padding = new Padding(0, 51, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashbaord";
            WindowState = FormWindowState.Maximized;
            Load += frm_dashboard_Load;
            materialTabControl1.ResumeLayout(false);
            tab_home.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_find_vehicle.ResumeLayout(false);
            groupBox_add_parking.ResumeLayout(false);
            groupBox_manage_parking.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tab_history.ResumeLayout(false);
            tab_history.PerformLayout();
            tab_settings.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            materialExpansionPanel2.ResumeLayout(false);
            materialExpansionPanel2.PerformLayout();
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private GroupBox groupBox_add_parking;
        private Components.ParkingComponent parking1;
        private ImageList parking_imageList;
        private ListView myListView;
        private MaterialSkin.Controls.MaterialLabel lbl_welcome_user;
        private GroupBox groupBox_find_vehicle;
        private MaterialSkin.Controls.MaterialTextBox2 txt_barcode;
        private MaterialContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem1;
        private MaterialButton materialButton3;
        private MaterialExpansionPanel materialExpansionPanel1;
        private MaterialExpansionPanel materialExpansionPanel2;
        private Label label6;
        private Label label5;
        private MaterialTextBox2 txt_settings_parking_ticket_header_title;
        private MaterialMultiLineTextBox2 txt_settings_parking_ticket_header_sub_title;
        private GroupBox groupBox_manage_parking;
        private MaterialLabel materialLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialLabel lbl_date_time_now;
        private System.Windows.Forms.Timer timer_date_now;
        private MaterialListView lv_parking_history;
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
        private MaterialButton materialButton2;
        private MaterialButton materialButton4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label label4;
        private MaterialTextBox2 txt_allowed_minutes;
        private MaterialLabel lbl_total_amount;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label7;
        private Label label8;
        private MaterialButton btn_end_my_shift;
    }
}

