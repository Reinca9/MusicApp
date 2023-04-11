using MaterialSkin.Controls;
using System.Windows.Forms;

namespace music
{
    partial class addNewConcert
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
            materialLabel1 = new MaterialLabel();
            materialLabel2 = new MaterialLabel();
            addConcertNameBox = new MaterialTextBox();
            AddArtistInDB = new MaterialButton();
            choseArtistName = new MaterialComboBox();
            materialLabel3 = new MaterialLabel();
            materialButton2 = new MaterialButton();
            materialLabel4 = new MaterialLabel();
            materialLabel5 = new MaterialLabel();
            materialLabel6 = new MaterialLabel();
            materialMaskedTextBox1 = new MaterialMaskedTextBox();
            materialMaskedTextBox2 = new MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ImeMode = ImeMode.NoControl;
            materialLabel1.Location = new Point(113, 44);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 19);
            materialLabel1.TabIndex = 23;
            materialLabel1.Text = "Concert name";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ImeMode = ImeMode.NoControl;
            materialLabel2.Location = new Point(113, 119);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(91, 19);
            materialLabel2.TabIndex = 24;
            materialLabel2.Text = "Concert hour";
            // 
            // addConcertNameBox
            // 
            addConcertNameBox.AnimateReadOnly = false;
            addConcertNameBox.BorderStyle = BorderStyle.None;
            addConcertNameBox.Depth = 0;
            addConcertNameBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addConcertNameBox.LeadingIcon = null;
            addConcertNameBox.Location = new Point(261, 45);
            addConcertNameBox.MaxLength = 50;
            addConcertNameBox.MouseState = MaterialSkin.MouseState.OUT;
            addConcertNameBox.Multiline = false;
            addConcertNameBox.Name = "addConcertNameBox";
            addConcertNameBox.Size = new Size(225, 50);
            addConcertNameBox.TabIndex = 1;
            addConcertNameBox.Text = "";
            addConcertNameBox.TrailingIcon = null;
            // 
            // AddArtistInDB
            // 
            AddArtistInDB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddArtistInDB.Density = MaterialButton.MaterialButtonDensity.Default;
            AddArtistInDB.Depth = 0;
            AddArtistInDB.HighEmphasis = true;
            AddArtistInDB.Icon = null;
            AddArtistInDB.ImeMode = ImeMode.NoControl;
            AddArtistInDB.Location = new Point(289, 349);
            AddArtistInDB.Margin = new Padding(4, 6, 4, 6);
            AddArtistInDB.MouseState = MaterialSkin.MouseState.HOVER;
            AddArtistInDB.Name = "AddArtistInDB";
            AddArtistInDB.NoAccentTextColor = Color.Empty;
            AddArtistInDB.Size = new Size(188, 36);
            AddArtistInDB.TabIndex = 5;
            AddArtistInDB.Text = "Add the new concert";
            AddArtistInDB.Type = MaterialButton.MaterialButtonType.Contained;
            AddArtistInDB.UseAccentColor = false;
            AddArtistInDB.UseVisualStyleBackColor = true;
            AddArtistInDB.Click += AddArtistInDB_Click;
            // 
            // choseArtistName
            // 
            choseArtistName.AutoResize = false;
            choseArtistName.BackColor = Color.FromArgb(255, 255, 255);
            choseArtistName.Depth = 0;
            choseArtistName.DrawMode = DrawMode.OwnerDrawVariable;
            choseArtistName.DropDownHeight = 174;
            choseArtistName.DropDownStyle = ComboBoxStyle.DropDownList;
            choseArtistName.DropDownWidth = 121;
            choseArtistName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            choseArtistName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            choseArtistName.FormattingEnabled = true;
            choseArtistName.IntegralHeight = false;
            choseArtistName.ItemHeight = 43;
            choseArtistName.Location = new Point(261, 192);
            choseArtistName.MaxDropDownItems = 4;
            choseArtistName.MouseState = MaterialSkin.MouseState.OUT;
            choseArtistName.Name = "choseArtistName";
            choseArtistName.Size = new Size(225, 49);
            choseArtistName.StartIndex = 0;
            choseArtistName.TabIndex = 3;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.ImeMode = ImeMode.NoControl;
            materialLabel3.Location = new Point(113, 192);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(82, 19);
            materialLabel3.TabIndex = 33;
            materialLabel3.Text = "Artist name";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.ImeMode = ImeMode.NoControl;
            materialButton2.Location = new Point(723, 15);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 34;
            materialButton2.Text = "X";
            materialButton2.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.ImeMode = ImeMode.NoControl;
            materialLabel4.Location = new Point(113, 269);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(90, 19);
            materialLabel4.TabIndex = 36;
            materialLabel4.Text = "Concert date";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.ImeMode = ImeMode.NoControl;
            materialLabel5.Location = new Point(290, 402);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(150, 19);
            materialLabel5.TabIndex = 37;
            materialLabel5.Text = "Can't add the concert";
            materialLabel5.Visible = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.ImeMode = ImeMode.NoControl;
            materialLabel6.Location = new Point(289, 402);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(187, 19);
            materialLabel6.TabIndex = 38;
            materialLabel6.Text = "Concert added succesfully";
            materialLabel6.Visible = false;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(261, 119);
            materialMaskedTextBox1.Mask = "00:00";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(225, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 2;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "  :";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(261, 269);
            materialMaskedTextBox2.Mask = "00/00/0000";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(225, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 4;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.Text = "  /  /";
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // addNewConcert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = materialButton2;
            ClientSize = new Size(800, 450);
            Controls.Add(materialMaskedTextBox2);
            Controls.Add(materialMaskedTextBox1);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel3);
            Controls.Add(choseArtistName);
            Controls.Add(AddArtistInDB);
            Controls.Add(addConcertNameBox);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "addNewConcert";
            Opacity = 0.9D;
            Text = "addNewConcert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox addConcertNameBox;
        private MaterialSkin.Controls.MaterialButton AddArtistInDB;
        private MaterialSkin.Controls.MaterialComboBox choseArtistName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
    }
}