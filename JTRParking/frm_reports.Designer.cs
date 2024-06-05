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
            label3 = new Label();
            comboBox1 = new ComboBox();
            lbl_car_count = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lbl_total_amount = new MaterialSkin.Controls.MaterialLabel();
            lbl_motor_count = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(125, 171);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(384, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(125, 239);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(384, 27);
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
            materialButton1.Location = new Point(558, 150);
            materialButton1.Margin = new Padding(5);
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
            label1.Location = new Point(62, 178);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 244);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 5;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 108);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "User";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(384, 49);
            comboBox1.TabIndex = 11;
            // 
            // lbl_car_count
            // 
            lbl_car_count.Depth = 0;
            lbl_car_count.Dock = DockStyle.Fill;
            lbl_car_count.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_car_count.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lbl_car_count.HighEmphasis = true;
            lbl_car_count.Location = new Point(2, 390);
            lbl_car_count.Margin = new Padding(2, 0, 2, 0);
            lbl_car_count.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_car_count.Name = "lbl_car_count";
            lbl_car_count.Size = new Size(844, 100);
            lbl_car_count.TabIndex = 12;
            lbl_car_count.Text = "Total Cars : ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_total_amount, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl_motor_count, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_car_count, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 72);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(848, 740);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 384);
            panel1.TabIndex = 14;
            // 
            // lbl_total_amount
            // 
            lbl_total_amount.Depth = 0;
            lbl_total_amount.Dock = DockStyle.Fill;
            lbl_total_amount.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_total_amount.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lbl_total_amount.HighEmphasis = true;
            lbl_total_amount.Location = new Point(2, 590);
            lbl_total_amount.Margin = new Padding(2, 0, 2, 0);
            lbl_total_amount.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_total_amount.Name = "lbl_total_amount";
            lbl_total_amount.Size = new Size(844, 150);
            lbl_total_amount.TabIndex = 14;
            lbl_total_amount.Text = "Tota Amount : ";
            // 
            // lbl_motor_count
            // 
            lbl_motor_count.Depth = 0;
            lbl_motor_count.Dock = DockStyle.Fill;
            lbl_motor_count.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_motor_count.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lbl_motor_count.HighEmphasis = true;
            lbl_motor_count.Location = new Point(2, 490);
            lbl_motor_count.Margin = new Padding(2, 0, 2, 0);
            lbl_motor_count.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_motor_count.Name = "lbl_motor_count";
            lbl_motor_count.Size = new Size(844, 100);
            lbl_motor_count.TabIndex = 13;
            lbl_motor_count.Text = "Total Motor : ";
            // 
            // frm_reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(854, 815);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_car_count;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lbl_total_amount;
        private MaterialSkin.Controls.MaterialLabel lbl_motor_count;
        private Panel panel1;
    }
}