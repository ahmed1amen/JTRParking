namespace JTRParking
{
    partial class parking_ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parking_ticket));
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btn_endParking = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            tableLayoutPanel2 = new TableLayoutPanel();
            label15 = new Label();
            lbl_Amount = new Label();
            label13 = new Label();
            lbl_TotalHours = new Label();
            lbl_OutTime = new Label();
            label10 = new Label();
            lbl_InTime = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl_DriverName = new Label();
            label4 = new Label();
            lbl_VehicleType = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbl_DriverMobile = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "ParkingTicket";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btn_endParking
            // 
            btn_endParking.BackColor = SystemColors.Control;
            btn_endParking.Dock = DockStyle.Fill;
            btn_endParking.Location = new Point(3, 3);
            btn_endParking.Name = "btn_endParking";
            btn_endParking.Size = new Size(163, 48);
            btn_endParking.TabIndex = 10;
            btn_endParking.Text = "End Parking";
            btn_endParking.UseVisualStyleBackColor = false;
            btn_endParking.Click += btn_endParking_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btn_endParking, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 731);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(509, 54);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(341, 3);
            button2.Name = "button2";
            button2.Size = new Size(165, 48);
            button2.TabIndex = 11;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7053F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2946968F));
            tableLayoutPanel2.Controls.Add(label15, 0, 8);
            tableLayoutPanel2.Controls.Add(lbl_Amount, 0, 8);
            tableLayoutPanel2.Controls.Add(label13, 0, 7);
            tableLayoutPanel2.Controls.Add(lbl_TotalHours, 0, 7);
            tableLayoutPanel2.Controls.Add(lbl_OutTime, 1, 6);
            tableLayoutPanel2.Controls.Add(label10, 0, 6);
            tableLayoutPanel2.Controls.Add(lbl_InTime, 1, 5);
            tableLayoutPanel2.Controls.Add(label8, 0, 5);
            tableLayoutPanel2.Controls.Add(label7, 0, 4);
            tableLayoutPanel2.Controls.Add(lbl_DriverName, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(lbl_VehicleType, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(lbl_DriverMobile, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(509, 731);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 660);
            label15.Name = "label15";
            label15.Size = new Size(246, 60);
            label15.TabIndex = 15;
            label15.Text = "Amount";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.Dock = DockStyle.Fill;
            lbl_Amount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Amount.Location = new Point(255, 660);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(251, 60);
            lbl_Amount.TabIndex = 14;
            lbl_Amount.Text = "10 DH";
            lbl_Amount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 600);
            label13.Name = "label13";
            label13.Size = new Size(246, 60);
            label13.TabIndex = 13;
            label13.Text = "Total Hours";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalHours
            // 
            lbl_TotalHours.AutoSize = true;
            lbl_TotalHours.Dock = DockStyle.Fill;
            lbl_TotalHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalHours.Location = new Point(255, 600);
            lbl_TotalHours.Name = "lbl_TotalHours";
            lbl_TotalHours.Size = new Size(251, 60);
            lbl_TotalHours.TabIndex = 12;
            lbl_TotalHours.Text = "5";
            lbl_TotalHours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_OutTime
            // 
            lbl_OutTime.AutoSize = true;
            lbl_OutTime.Dock = DockStyle.Fill;
            lbl_OutTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_OutTime.Location = new Point(255, 540);
            lbl_OutTime.Name = "lbl_OutTime";
            lbl_OutTime.Size = new Size(251, 60);
            lbl_OutTime.TabIndex = 11;
            lbl_OutTime.Text = "2024-04-10 03:13:15";
            lbl_OutTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 540);
            label10.Name = "label10";
            label10.Size = new Size(246, 60);
            label10.TabIndex = 10;
            label10.Text = "OutTime";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_InTime
            // 
            lbl_InTime.AutoSize = true;
            lbl_InTime.Dock = DockStyle.Fill;
            lbl_InTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_InTime.Location = new Point(255, 480);
            lbl_InTime.Name = "lbl_InTime";
            lbl_InTime.Size = new Size(251, 60);
            lbl_InTime.TabIndex = 9;
            lbl_InTime.Text = "2024-04-09 22:13:15";
            lbl_InTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 480);
            label8.Name = "label8";
            label8.Size = new Size(246, 60);
            label8.TabIndex = 8;
            label8.Text = "In Time";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 420);
            label7.Name = "label7";
            label7.Size = new Size(246, 60);
            label7.TabIndex = 7;
            label7.Text = "Driver Mobile";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_DriverName
            // 
            lbl_DriverName.Dock = DockStyle.Fill;
            lbl_DriverName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DriverName.Location = new Point(255, 360);
            lbl_DriverName.Name = "lbl_DriverName";
            lbl_DriverName.Size = new Size(251, 60);
            lbl_DriverName.TabIndex = 5;
            lbl_DriverName.Text = "HASSAN";
            lbl_DriverName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 360);
            label4.Name = "label4";
            label4.Size = new Size(246, 60);
            label4.TabIndex = 4;
            label4.Text = "Driver Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_VehicleType
            // 
            lbl_VehicleType.Dock = DockStyle.Fill;
            lbl_VehicleType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_VehicleType.Location = new Point(255, 300);
            lbl_VehicleType.Name = "lbl_VehicleType";
            lbl_VehicleType.Size = new Size(251, 60);
            lbl_VehicleType.TabIndex = 3;
            lbl_VehicleType.Text = "CAR";
            lbl_VehicleType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 300);
            label2.Name = "label2";
            label2.Size = new Size(246, 60);
            label2.TabIndex = 2;
            label2.Text = "Vehicle Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel2.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 150);
            label1.TabIndex = 1;
            label1.Text = "JTR Parking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_DriverMobile
            // 
            lbl_DriverMobile.AutoSize = true;
            lbl_DriverMobile.Dock = DockStyle.Fill;
            lbl_DriverMobile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DriverMobile.Location = new Point(255, 420);
            lbl_DriverMobile.Name = "lbl_DriverMobile";
            lbl_DriverMobile.Size = new Size(251, 60);
            lbl_DriverMobile.TabIndex = 6;
            lbl_DriverMobile.Text = "0128484459546";
            lbl_DriverMobile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parking_ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(509, 785);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "parking_ticket";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parking Ticket";
            Load += parking_ticket_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btn_endParking;
        private PrintPreviewDialog printPreviewDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbl_VehicleType;
        private Label label2;
        private Label lbl_OutTime;
        private Label label10;
        private Label lbl_InTime;
        private Label label8;
        private Label label7;
        private Label lbl_DriverName;
        private Label label4;
        private Label lbl_DriverMobile;
        private Label label13;
        private Label lbl_TotalHours;
        private Label label15;
        private Label lbl_Amount;
    }
}