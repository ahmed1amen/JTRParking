namespace JTRParking
{
    partial class frm_reports
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
            label4 = new Label();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lbl_stats = new MaterialSkin.Controls.MaterialLabel();
            label5 = new Label();
            label6 = new Label();
            comboBoxShifts = new MaterialSkin.Controls.MaterialComboBox();
            comboBoxUsers = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(139, 255);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Shifts";
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(592, 101);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(53, 37);
            materialCheckbox1.TabIndex = 12;
            materialCheckbox1.Text = "All";
            materialCheckbox1.TextAlign = ContentAlignment.TopCenter;
            materialCheckbox1.UseVisualStyleBackColor = true;
            materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(592, 236);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(145, 45);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Search";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(192, 152);
            dateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(370, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(192, 197);
            dateTimePickerEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(370, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 114);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 156);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 201);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // lbl_stats
            // 
            lbl_stats.Depth = 0;
            lbl_stats.Dock = DockStyle.Bottom;
            lbl_stats.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbl_stats.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lbl_stats.HighEmphasis = true;
            lbl_stats.Location = new Point(3, 399);
            lbl_stats.Margin = new Padding(2, 0, 2, 0);
            lbl_stats.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_stats.Name = "lbl_stats";
            lbl_stats.Size = new Size(857, 335);
            lbl_stats.TabIndex = 15;
            lbl_stats.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(103, 306);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 16;
            label5.Text = "Shift Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Chocolate;
            label6.Location = new Point(199, 306);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 17;
            label6.Text = "-";
            // 
            // comboBoxShifts
            // 
            comboBoxShifts.AutoResize = false;
            comboBoxShifts.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxShifts.Depth = 0;
            comboBoxShifts.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxShifts.DropDownHeight = 174;
            comboBoxShifts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShifts.DropDownWidth = 121;
            comboBoxShifts.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxShifts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxShifts.FormattingEnabled = true;
            comboBoxShifts.IntegralHeight = false;
            comboBoxShifts.ItemHeight = 43;
            comboBoxShifts.Location = new Point(199, 236);
            comboBoxShifts.MaxDropDownItems = 4;
            comboBoxShifts.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxShifts.Name = "comboBoxShifts";
            comboBoxShifts.Size = new Size(363, 49);
            comboBoxShifts.StartIndex = 0;
            comboBoxShifts.TabIndex = 18;
            comboBoxShifts.SelectedIndexChanged += comboBoxShifts_SelectedIndexChanged;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.AutoResize = false;
            comboBoxUsers.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxUsers.Depth = 0;
            comboBoxUsers.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxUsers.DropDownHeight = 174;
            comboBoxUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsers.DropDownWidth = 121;
            comboBoxUsers.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxUsers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.IntegralHeight = false;
            comboBoxUsers.ItemHeight = 43;
            comboBoxUsers.Location = new Point(192, 97);
            comboBoxUsers.MaxDropDownItems = 4;
            comboBoxUsers.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(363, 49);
            comboBoxUsers.StartIndex = 0;
            comboBoxUsers.TabIndex = 19;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // frm_reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(863, 736);
            Controls.Add(comboBoxUsers);
            Controls.Add(comboBoxShifts);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_stats);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(materialButton1);
            Controls.Add(label1);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label3);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(materialCheckbox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            FormStyle = FormStyles.ActionBar_48;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_reports";
            Padding = new Padding(3, 54, 3, 2);
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reports";
            TopMost = true;
            Load += frm_reports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private MaterialSkin.Controls.MaterialLabel lbl_stats;
        private Label label5;
        private Label label6;
        private MaterialSkin.Controls.MaterialComboBox comboBoxShifts;
        private MaterialSkin.Controls.MaterialComboBox comboBoxUsers;
    }
}