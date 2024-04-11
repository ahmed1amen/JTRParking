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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(110, 85);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(319, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(110, 118);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(319, 27);
            dateTimePickerEnd.TabIndex = 1;
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
            materialButton1.Location = new Point(486, 85);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(166, 60);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Search";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 88);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 121);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // frm_reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(705, 834);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materialButton1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            FormBorderStyle = FormBorderStyle.Sizable;
            FormStyle = FormStyles.ActionBar_48;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_reports";
            Padding = new Padding(3, 72, 3, 3);
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

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
        private Label label2;
    }
}