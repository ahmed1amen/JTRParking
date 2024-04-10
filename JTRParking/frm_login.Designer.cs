namespace JTRParking
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            label1 = new Label();
            label2 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txt_username = new MaterialSkin.Controls.MaterialTextBox2();
            txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 271);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 347);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
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
            materialButton1.Location = new Point(249, 401);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(174, 68);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click;
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
            txt_username.Location = new Point(166, 259);
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
            txt_username.Size = new Size(360, 48);
            txt_username.TabIndex = 5;
            txt_username.TabStop = false;
            txt_username.Text = "admin";
            txt_username.TextAlign = HorizontalAlignment.Center;
            txt_username.TrailingIcon = null;
            txt_username.UseSystemPasswordChar = false;
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
            txt_password.Location = new Point(166, 334);
            txt_password.MaxLength = 32767;
            txt_password.MouseState = MaterialSkin.MouseState.OUT;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '●';
            txt_password.PrefixSuffixText = null;
            txt_password.ReadOnly = false;
            txt_password.RightToLeft = RightToLeft.No;
            txt_password.SelectedText = "";
            txt_password.SelectionLength = 0;
            txt_password.SelectionStart = 0;
            txt_password.ShortcutsEnabled = true;
            txt_password.Size = new Size(360, 48);
            txt_password.TabIndex = 6;
            txt_password.TabStop = false;
            txt_password.Text = "admin";
            txt_password.TextAlign = HorizontalAlignment.Center;
            txt_password.TrailingIcon = null;
            txt_password.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frm_login
            // 
            AcceptButton = materialButton1;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(625, 499);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(materialButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "frm_login";
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_username;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

