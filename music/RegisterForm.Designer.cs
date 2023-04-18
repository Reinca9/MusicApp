using MaterialSkin.Controls;
using System.Windows.Forms;

namespace music
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            materialLabel1 = new MaterialLabel();
            materialButton1 = new MaterialButton();
            materialTextBox22 = new MaterialTextBox2();
            materialTextBox21 = new MaterialTextBox2();
            materialTextBox23 = new MaterialTextBox2();
            materialTextBox24 = new MaterialTextBox2();
            materialCheckbox1 = new MaterialCheckbox();
            materialButton2 = new MaterialButton();
            materialCheckbox2 = new MaterialCheckbox();
            materialLabel2 = new MaterialLabel();
            materialLabel3 = new MaterialLabel();
            materialLabel4 = new MaterialLabel();
            materialLabel5 = new MaterialLabel();
            materialLabel6 = new MaterialLabel();
            materialLabel7 = new MaterialLabel();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            resources.ApplyResources(materialLabel1, "materialLabel1");
            materialLabel1.Depth = 0;
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            // 
            // materialButton1
            // 
            resources.ApplyResources(materialButton1, "materialButton1");
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            resources.ApplyResources(materialTextBox22, "materialTextBox22");
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.ReadOnly = false;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            materialTextBox22.Enter += materialTextBox22_Enter;
            materialTextBox22.Leave += materialTextBox22_Leave;
            materialTextBox22.TextChanged += materialTextBox22_TextChanged;
            materialTextBox22.Validating += materialTextBox22_Validating;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            resources.ApplyResources(materialTextBox21, "materialTextBox21");
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.ReadOnly = false;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            materialTextBox21.Enter += materialTextBox21_Enter;
            materialTextBox21.Leave += materialTextBox21_Leave_1;
            materialTextBox21.TextChanged += materialTextBox21_TextChanged;
            materialTextBox21.Validating += materialTextBox21_Validating;
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            resources.ApplyResources(materialTextBox23, "materialTextBox23");
            materialTextBox23.CharacterCasing = CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '*';
            materialTextBox23.ReadOnly = false;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.TabStop = false;
            materialTextBox23.TextAlign = HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
            materialTextBox23.Enter += materialTextBox23_Enter;
            materialTextBox23.Leave += materialTextBox23_Leave;
            materialTextBox23.TextChanged += materialTextBox23_TextChanged;
            // 
            // materialTextBox24
            // 
            materialTextBox24.AnimateReadOnly = false;
            resources.ApplyResources(materialTextBox24, "materialTextBox24");
            materialTextBox24.CharacterCasing = CharacterCasing.Normal;
            materialTextBox24.Depth = 0;
            materialTextBox24.HideSelection = true;
            materialTextBox24.LeadingIcon = null;
            materialTextBox24.MaxLength = 32767;
            materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox24.Name = "materialTextBox24";
            materialTextBox24.PasswordChar = '*';
            materialTextBox24.ReadOnly = false;
            materialTextBox24.SelectedText = "";
            materialTextBox24.SelectionLength = 0;
            materialTextBox24.SelectionStart = 0;
            materialTextBox24.ShortcutsEnabled = true;
            materialTextBox24.TabStop = false;
            materialTextBox24.TextAlign = HorizontalAlignment.Left;
            materialTextBox24.TrailingIcon = null;
            materialTextBox24.UseSystemPasswordChar = false;
            materialTextBox24.Enter += materialTextBox24_Enter;
            materialTextBox24.Leave += materialTextBox24_Leave;
            materialTextBox24.TextChanged += materialTextBox24_TextChanged;
            materialTextBox24.Validating += materialTextBox24_Validating;
            // 
            // materialCheckbox1
            // 
            resources.ApplyResources(materialCheckbox1, "materialCheckbox1");
            materialCheckbox1.Depth = 0;
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.UseVisualStyleBackColor = true;
            materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged;
            // 
            // materialButton2
            // 
            resources.ApplyResources(materialButton2, "materialButton2");
            materialButton2.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialCheckbox2
            // 
            resources.ApplyResources(materialCheckbox2, "materialCheckbox2");
            materialCheckbox2.Depth = 0;
            materialCheckbox2.MouseLocation = new Point(-1, -1);
            materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox2.Name = "materialCheckbox2";
            materialCheckbox2.ReadOnly = false;
            materialCheckbox2.Ripple = true;
            materialCheckbox2.UseVisualStyleBackColor = true;
            materialCheckbox2.CheckedChanged += materialCheckbox2_CheckedChanged;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(materialLabel2, "materialLabel2");
            materialLabel2.Depth = 0;
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(materialLabel3, "materialLabel3");
            materialLabel3.Depth = 0;
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(materialLabel4, "materialLabel4");
            materialLabel4.BackColor = Color.Gainsboro;
            materialLabel4.Depth = 0;
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel4.ForeColor = Color.Red;
            materialLabel4.HighEmphasis = true;
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(materialLabel5, "materialLabel5");
            materialLabel5.BackColor = SystemColors.ButtonFace;
            materialLabel5.Depth = 0;
            materialLabel5.ForeColor = Color.Red;
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(materialLabel6, "materialLabel6");
            materialLabel6.Depth = 0;
            materialLabel6.ForeColor = Color.Red;
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            // 
            // materialLabel7
            // 
            resources.ApplyResources(materialLabel7, "materialLabel7");
            materialLabel7.Depth = 0;
            materialLabel7.ForeColor = Color.Red;
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            // 
            // maskedTextBox1
            // 
            resources.ApplyResources(maskedTextBox1, "maskedTextBox1");
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.TypeValidationCompleted += maskedTextBox1_TypeValidationCompleted;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = materialButton1;
            Controls.Add(maskedTextBox1);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialCheckbox2);
            Controls.Add(materialButton2);
            Controls.Add(materialCheckbox1);
            Controls.Add(materialTextBox24);
            Controls.Add(materialTextBox23);
            Controls.Add(materialTextBox22);
            Controls.Add(materialTextBox21);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaskedTextBox maskedTextBox1;
    }
}