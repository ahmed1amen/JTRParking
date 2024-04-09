namespace JTRParking
{
    partial class frm_users
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
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            txt_username = new MaterialSkin.Controls.MaterialTextBox2();
            txt_name = new MaterialSkin.Controls.MaterialTextBox2();
            txt_id = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            listViewUsers = new MaterialSkin.Controls.MaterialListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialComboBox2
            // 
            materialComboBox2.AutoResize = false;
            materialComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox2.Depth = 0;
            materialComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox2.DropDownHeight = 174;
            materialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox2.DropDownWidth = 121;
            materialComboBox2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox2.FormattingEnabled = true;
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Items.AddRange(new object[] { "admin", "employee" });
            materialComboBox2.Location = new Point(97, 517);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(375, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 455);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 30;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 535);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 31;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 375);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 29;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 293);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 28;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 207);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // txt_password
            // 
            txt_password.AnimateReadOnly = false;
            txt_password.BackgroundImageLayout = ImageLayout.None;
            txt_password.CharacterCasing = CharacterCasing.Normal;
            txt_password.Depth = 0;
            txt_password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_password.HideSelection = true;
            txt_password.LeadingIcon = null;
            txt_password.Location = new Point(97, 440);
            txt_password.MaxLength = 32767;
            txt_password.MouseState = MaterialSkin.MouseState.OUT;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '\0';
            txt_password.PrefixSuffixText = null;
            txt_password.ReadOnly = false;
            txt_password.RightToLeft = RightToLeft.No;
            txt_password.SelectedText = "";
            txt_password.SelectionLength = 0;
            txt_password.SelectionStart = 0;
            txt_password.ShortcutsEnabled = true;
            txt_password.Size = new Size(375, 48);
            txt_password.TabIndex = 26;
            txt_password.TabStop = false;
            txt_password.TextAlign = HorizontalAlignment.Left;
            txt_password.TrailingIcon = null;
            txt_password.UseSystemPasswordChar = false;
            // 
            // txt_username
            // 
            txt_username.AnimateReadOnly = false;
            txt_username.BackgroundImageLayout = ImageLayout.None;
            txt_username.CharacterCasing = CharacterCasing.Normal;
            txt_username.Depth = 0;
            txt_username.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_username.HideSelection = true;
            txt_username.LeadingIcon = null;
            txt_username.Location = new Point(97, 359);
            txt_username.MaxLength = 32767;
            txt_username.MouseState = MaterialSkin.MouseState.OUT;
            txt_username.Name = "txt_username";
            txt_username.PasswordChar = '\0';
            txt_username.PrefixSuffixText = null;
            txt_username.ReadOnly = false;
            txt_username.RightToLeft = RightToLeft.No;
            txt_username.SelectedText = "";
            txt_username.SelectionLength = 0;
            txt_username.SelectionStart = 0;
            txt_username.ShortcutsEnabled = true;
            txt_username.Size = new Size(375, 48);
            txt_username.TabIndex = 25;
            txt_username.TabStop = false;
            txt_username.TextAlign = HorizontalAlignment.Left;
            txt_username.TrailingIcon = null;
            txt_username.UseSystemPasswordChar = false;
            // 
            // txt_name
            // 
            txt_name.AnimateReadOnly = false;
            txt_name.BackgroundImageLayout = ImageLayout.None;
            txt_name.CharacterCasing = CharacterCasing.Normal;
            txt_name.Depth = 0;
            txt_name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_name.HideSelection = true;
            txt_name.LeadingIcon = null;
            txt_name.Location = new Point(97, 278);
            txt_name.MaxLength = 32767;
            txt_name.MouseState = MaterialSkin.MouseState.OUT;
            txt_name.Name = "txt_name";
            txt_name.PasswordChar = '\0';
            txt_name.PrefixSuffixText = null;
            txt_name.ReadOnly = false;
            txt_name.RightToLeft = RightToLeft.No;
            txt_name.SelectedText = "";
            txt_name.SelectionLength = 0;
            txt_name.SelectionStart = 0;
            txt_name.ShortcutsEnabled = true;
            txt_name.Size = new Size(375, 48);
            txt_name.TabIndex = 24;
            txt_name.TabStop = false;
            txt_name.TextAlign = HorizontalAlignment.Left;
            txt_name.TrailingIcon = null;
            txt_name.UseSystemPasswordChar = false;
            // 
            // txt_id
            // 
            txt_id.AnimateReadOnly = false;
            txt_id.BackgroundImageLayout = ImageLayout.None;
            txt_id.CharacterCasing = CharacterCasing.Normal;
            txt_id.Depth = 0;
            txt_id.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_id.HideSelection = true;
            txt_id.LeadingIcon = null;
            txt_id.Location = new Point(97, 197);
            txt_id.MaxLength = 32767;
            txt_id.MouseState = MaterialSkin.MouseState.OUT;
            txt_id.Name = "txt_id";
            txt_id.PasswordChar = '\0';
            txt_id.PrefixSuffixText = null;
            txt_id.ReadOnly = true;
            txt_id.RightToLeft = RightToLeft.No;
            txt_id.SelectedText = "";
            txt_id.SelectionLength = 0;
            txt_id.SelectionStart = 0;
            txt_id.ShortcutsEnabled = true;
            txt_id.Size = new Size(375, 48);
            txt_id.TabIndex = 23;
            txt_id.TabStop = false;
            txt_id.TextAlign = HorizontalAlignment.Left;
            txt_id.TrailingIcon = null;
            txt_id.UseSystemPasswordChar = false;
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
            materialButton2.Location = new Point(16, 636);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(119, 38);
            materialButton2.TabIndex = 22;
            materialButton2.Text = "Add";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            materialButton2.Click += materialButton2_Click;
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
            materialButton1.Location = new Point(384, 636);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(119, 38);
            materialButton1.TabIndex = 21;
            materialButton1.Text = "Delete";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = SystemColors.Control;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton3.ForeColor = SystemColors.ControlText;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(200, 636);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(119, 38);
            materialButton3.TabIndex = 20;
            materialButton3.Text = "Update";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = false;
            materialButton3.Click += materialButton3_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Username";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Password ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Role";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.BackColor = SystemColors.Control;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton4.ForeColor = SystemColors.ControlText;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(1142, 87);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(119, 38);
            materialButton4.TabIndex = 33;
            materialButton4.Text = "Refresh";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = false;
            materialButton4.Click += materialButton4_Click;
            // 
            // listViewUsers
            // 
            listViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewUsers.AutoSizeTable = false;
            listViewUsers.BackColor = Color.FromArgb(255, 255, 255);
            listViewUsers.BorderStyle = BorderStyle.None;
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewUsers.Depth = 0;
            listViewUsers.FullRowSelect = true;
            listViewUsers.ImeMode = ImeMode.NoControl;
            listViewUsers.Location = new Point(511, 148);
            listViewUsers.MinimumSize = new Size(200, 100);
            listViewUsers.MouseLocation = new Point(-1, -1);
            listViewUsers.MouseState = MaterialSkin.MouseState.OUT;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.OwnerDraw = true;
            listViewUsers.Size = new Size(751, 526);
            listViewUsers.Sorting = SortOrder.Ascending;
            listViewUsers.TabIndex = 19;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            listViewUsers.SelectedIndexChanged += listViewUsers_SelectedIndexChanged;
            // 
            // materialButton5
            // 
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.BackColor = SystemColors.Control;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialButton5.ForeColor = SystemColors.ControlText;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(402, 162);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(101, 26);
            materialButton5.TabIndex = 34;
            materialButton5.Text = "Reset";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = false;
            materialButton5.Click += materialButton5_Click;
            // 
            // frm_users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1268, 725);
            Controls.Add(materialButton5);
            Controls.Add(listViewUsers);
            Controls.Add(materialButton4);
            Controls.Add(materialComboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(materialButton3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Manager";
            Load += frm_users_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_username;
        private MaterialSkin.Controls.MaterialTextBox2 txt_name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_id;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialListView listViewUsers;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialButton materialButton5;
    }
}