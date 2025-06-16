namespace JTRParking
{
    partial class frm_shift_control
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
            btnStartShift = new MaterialSkin.Controls.MaterialButton();
            timePickerShift = new DateTimePicker();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnStartShift
            // 
            btnStartShift.AutoSize = false;
            btnStartShift.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStartShift.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStartShift.Depth = 0;
            btnStartShift.HighEmphasis = true;
            btnStartShift.Icon = null;
            btnStartShift.Location = new Point(95, 124);
            btnStartShift.Margin = new Padding(4, 6, 4, 6);
            btnStartShift.MouseState = MaterialSkin.MouseState.HOVER;
            btnStartShift.Name = "btnStartShift";
            btnStartShift.NoAccentTextColor = Color.Empty;
            btnStartShift.Size = new Size(150, 36);
            btnStartShift.TabIndex = 0;
            btnStartShift.Text = "Start Shift";
            btnStartShift.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStartShift.UseAccentColor = false;
            btnStartShift.UseVisualStyleBackColor = true;
            btnStartShift.Click += btnStartShift_Click;
            // 
            // timePickerShift
            // 
            timePickerShift.Format = DateTimePickerFormat.Time;
            timePickerShift.Location = new Point(283, 129);
            timePickerShift.Name = "timePickerShift";
            timePickerShift.ShowUpDown = true;
            timePickerShift.Size = new Size(150, 23);
            timePickerShift.TabIndex = 1;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(95, 187);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(150, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "End Shift";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(283, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(150, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // frm_shift_control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(517, 275);
            Controls.Add(dateTimePicker1);
            Controls.Add(materialButton1);
            Controls.Add(timePickerShift);
            Controls.Add(btnStartShift);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_shift_control";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shift Control";
            TopMost = true;
            Load += frm_shift_control_Load;
            ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialButton btnStartShift;
        private System.Windows.Forms.DateTimePicker timePickerShift;

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DateTimePicker dateTimePicker1;
    }
}