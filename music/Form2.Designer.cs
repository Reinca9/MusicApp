namespace music
{
    partial class Form2
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            connectionSuccess = new MaterialSkin.Controls.MaterialLabel();
            ConnectionFail = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(288, 301);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(102, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "login now";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(288, 96);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(250, 48);
            materialTextBox21.TabIndex = 2;
            materialTextBox21.TabStop = false;
            materialTextBox21.Text = "Your e-mail @";
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            materialTextBox21.Enter += materialTextBox21_Enter;
            materialTextBox21.Leave += materialTextBox21_Leave;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(288, 150);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(250, 48);
            materialTextBox22.TabIndex = 3;
            materialTextBox22.TabStop = false;
            materialTextBox22.Text = "Your password";
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            materialTextBox22.Enter += materialTextBox22_Enter;
            materialTextBox22.Leave += materialTextBox22_Leave;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(288, 210);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(144, 37);
            materialCheckbox1.TabIndex = 4;
            materialCheckbox1.Text = "Stay connected";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(288, 58);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Login";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(673, 15);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "X";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(288, 253);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(177, 36);
            materialButton3.TabIndex = 7;
            materialButton3.Text = "Not registered yet?";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // connectionSuccess
            // 
            connectionSuccess.AutoSize = true;
            connectionSuccess.Depth = 0;
            connectionSuccess.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            connectionSuccess.Location = new Point(431, 311);
            connectionSuccess.MouseState = MaterialSkin.MouseState.HOVER;
            connectionSuccess.Name = "connectionSuccess";
            connectionSuccess.Size = new Size(157, 19);
            connectionSuccess.TabIndex = 8;
            connectionSuccess.Text = "Connection succesful!";
            connectionSuccess.Visible = false;
            // 
            // ConnectionFail
            // 
            ConnectionFail.AutoSize = true;
            ConnectionFail.Depth = 0;
            ConnectionFail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ConnectionFail.Location = new Point(431, 311);
            ConnectionFail.MouseState = MaterialSkin.MouseState.HOVER;
            ConnectionFail.Name = "ConnectionFail";
            ConnectionFail.Size = new Size(213, 19);
            ConnectionFail.TabIndex = 9;
            ConnectionFail.Text = "Invalid username or password";
            ConnectionFail.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = materialButton2;
            ClientSize = new Size(750, 375);
            Controls.Add(ConnectionFail);
            Controls.Add(connectionSuccess);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel1);
            Controls.Add(materialCheckbox1);
            Controls.Add(materialTextBox22);
            Controls.Add(materialTextBox21);
            Controls.Add(materialButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel connectionSuccess;
        private MaterialSkin.Controls.MaterialLabel ConnectionFail;
    }
}