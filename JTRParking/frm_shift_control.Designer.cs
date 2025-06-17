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
            lbl_message = new MaterialSkin.Controls.MaterialLabel();
            lbl_timenow = new LinkLabel();
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
            btnStartShift.Location = new Point(188, 286);
            btnStartShift.Margin = new Padding(4, 6, 4, 6);
            btnStartShift.MouseState = MaterialSkin.MouseState.HOVER;
            btnStartShift.Name = "btnStartShift";
            btnStartShift.NoAccentTextColor = Color.Empty;
            btnStartShift.Size = new Size(282, 58);
            btnStartShift.TabIndex = 0;
            btnStartShift.Text = "Start My Shift";
            btnStartShift.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStartShift.UseAccentColor = false;
            btnStartShift.UseVisualStyleBackColor = true;
            btnStartShift.Click += btnStartShift_Click;
            // 
            // timePickerShift
            // 
            timePickerShift.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            timePickerShift.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            timePickerShift.Format = DateTimePickerFormat.Time;
            timePickerShift.Location = new Point(161, 238);
            timePickerShift.Name = "timePickerShift";
            timePickerShift.ShowUpDown = true;
            timePickerShift.Size = new Size(244, 39);
            timePickerShift.TabIndex = 1;
            // 
            // lbl_message
            // 
            lbl_message.Depth = 0;
            lbl_message.Dock = DockStyle.Top;
            lbl_message.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbl_message.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lbl_message.HighEmphasis = true;
            lbl_message.Location = new Point(3, 64);
            lbl_message.Margin = new Padding(2, 0, 2, 0);
            lbl_message.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(613, 153);
            lbl_message.TabIndex = 7;
            lbl_message.Text = "Message";
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_timenow
            // 
            lbl_timenow.AutoSize = true;
            lbl_timenow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_timenow.Location = new Point(413, 245);
            lbl_timenow.Name = "lbl_timenow";
            lbl_timenow.Size = new Size(97, 25);
            lbl_timenow.TabIndex = 8;
            lbl_timenow.TabStop = true;
            lbl_timenow.Text = "Time Now";
            lbl_timenow.LinkClicked += lbl_timenow_LinkClicked;
            // 
            // frm_shift_control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(619, 362);
            Controls.Add(lbl_timenow);
            Controls.Add(lbl_message);
            Controls.Add(timePickerShift);
            Controls.Add(btnStartShift);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_shift_control";
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shift Control";
            TopMost = true;
            Load += frm_shift_control_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.DateTimePicker timePickerShift;

        #endregion

        public MaterialSkin.Controls.MaterialLabel lbl_message;
        private LinkLabel lbl_timenow;
        public MaterialSkin.Controls.MaterialButton btnStartShift;
    }
}