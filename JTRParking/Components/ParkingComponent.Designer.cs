namespace JTRParking.Components
{
    partial class ParkingComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_driver_phone = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            txt_driver_name = new MaterialSkin.Controls.MaterialTextBox2();
            label3 = new Label();
            combo_vehicle_type = new MaterialSkin.Controls.MaterialComboBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Vehicle Type";
            // 
            // txt_driver_phone
            // 
            txt_driver_phone.AnimateReadOnly = false;
            txt_driver_phone.BackgroundImageLayout = ImageLayout.None;
            txt_driver_phone.CharacterCasing = CharacterCasing.Normal;
            txt_driver_phone.Depth = 0;
            txt_driver_phone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_driver_phone.HideSelection = true;
            txt_driver_phone.LeadingIcon = null;
            txt_driver_phone.Location = new Point(114, 158);
            txt_driver_phone.MaxLength = 32767;
            txt_driver_phone.MouseState = MaterialSkin.MouseState.OUT;
            txt_driver_phone.Name = "txt_driver_phone";
            txt_driver_phone.PasswordChar = '\0';
            txt_driver_phone.PrefixSuffixText = null;
            txt_driver_phone.ReadOnly = false;
            txt_driver_phone.RightToLeft = RightToLeft.No;
            txt_driver_phone.SelectedText = "";
            txt_driver_phone.SelectionLength = 0;
            txt_driver_phone.SelectionStart = 0;
            txt_driver_phone.ShortcutsEnabled = true;
            txt_driver_phone.Size = new Size(312, 48);
            txt_driver_phone.TabIndex = 4;
            txt_driver_phone.TabStop = false;
            txt_driver_phone.TextAlign = HorizontalAlignment.Left;
            txt_driver_phone.TrailingIcon = null;
            txt_driver_phone.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 173);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Driver Phone";
            // 
            // txt_driver_name
            // 
            txt_driver_name.AnimateReadOnly = false;
            txt_driver_name.BackgroundImageLayout = ImageLayout.None;
            txt_driver_name.CharacterCasing = CharacterCasing.Normal;
            txt_driver_name.Depth = 0;
            txt_driver_name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_driver_name.HideSelection = true;
            txt_driver_name.LeadingIcon = null;
            txt_driver_name.Location = new Point(114, 90);
            txt_driver_name.MaxLength = 32767;
            txt_driver_name.MouseState = MaterialSkin.MouseState.OUT;
            txt_driver_name.Name = "txt_driver_name";
            txt_driver_name.PasswordChar = '\0';
            txt_driver_name.PrefixSuffixText = null;
            txt_driver_name.ReadOnly = false;
            txt_driver_name.RightToLeft = RightToLeft.No;
            txt_driver_name.SelectedText = "";
            txt_driver_name.SelectionLength = 0;
            txt_driver_name.SelectionStart = 0;
            txt_driver_name.ShortcutsEnabled = true;
            txt_driver_name.Size = new Size(312, 48);
            txt_driver_name.TabIndex = 6;
            txt_driver_name.TabStop = false;
            txt_driver_name.TextAlign = HorizontalAlignment.Left;
            txt_driver_name.TrailingIcon = null;
            txt_driver_name.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 104);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Driver Name";
            // 
            // combo_vehicle_type
            // 
            combo_vehicle_type.AutoResize = false;
            combo_vehicle_type.BackColor = Color.FromArgb(255, 255, 255);
            combo_vehicle_type.Depth = 0;
            combo_vehicle_type.DrawMode = DrawMode.OwnerDrawVariable;
            combo_vehicle_type.DropDownHeight = 174;
            combo_vehicle_type.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_vehicle_type.DropDownWidth = 121;
            combo_vehicle_type.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            combo_vehicle_type.ForeColor = Color.FromArgb(222, 0, 0, 0);
            combo_vehicle_type.FormattingEnabled = true;
            combo_vehicle_type.IntegralHeight = false;
            combo_vehicle_type.ItemHeight = 43;
            combo_vehicle_type.Items.AddRange(new object[] { "Car", "Motor" });
            combo_vehicle_type.Location = new Point(114, 19);
            combo_vehicle_type.MaxDropDownItems = 4;
            combo_vehicle_type.MouseState = MaterialSkin.MouseState.OUT;
            combo_vehicle_type.Name = "combo_vehicle_type";
            combo_vehicle_type.Size = new Size(312, 49);
            combo_vehicle_type.StartIndex = 0;
            combo_vehicle_type.TabIndex = 9;
            combo_vehicle_type.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
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
            materialButton2.Location = new Point(153, 232);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(174, 70);
            materialButton2.TabIndex = 23;
            materialButton2.Text = "Add";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            materialButton2.Click += materialButton2_Click;
            // 
            // ParkingComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButton2);
            Controls.Add(combo_vehicle_type);
            Controls.Add(txt_driver_name);
            Controls.Add(label3);
            Controls.Add(txt_driver_phone);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ParkingComponent";
            Size = new Size(437, 319);
            Load += Parking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_driver_phone;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_driver_name;
        private Label label3;
        private MaterialSkin.Controls.MaterialComboBox combo_vehicle_type;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}
