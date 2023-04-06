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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            addConcertNameBox = new MaterialSkin.Controls.MaterialTextBox();
            addConcertHourBox = new MaterialSkin.Controls.MaterialTextBox();
            AddArtistInDB = new MaterialSkin.Controls.MaterialButton();
            choseArtistName = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
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
            addConcertNameBox.TabIndex = 27;
            addConcertNameBox.Text = "";
            addConcertNameBox.TrailingIcon = null;
            // 
            // addConcertHourBox
            // 
            addConcertHourBox.AnimateReadOnly = false;
            addConcertHourBox.BorderStyle = BorderStyle.None;
            addConcertHourBox.Depth = 0;
            addConcertHourBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addConcertHourBox.LeadingIcon = null;
            addConcertHourBox.Location = new Point(261, 119);
            addConcertHourBox.MaxLength = 50;
            addConcertHourBox.MouseState = MaterialSkin.MouseState.OUT;
            addConcertHourBox.Multiline = false;
            addConcertHourBox.Name = "addConcertHourBox";
            addConcertHourBox.Size = new Size(225, 50);
            addConcertHourBox.TabIndex = 28;
            addConcertHourBox.Text = "";
            addConcertHourBox.TrailingIcon = null;
            // 
            // AddArtistInDB
            // 
            AddArtistInDB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddArtistInDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
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
            AddArtistInDB.TabIndex = 31;
            AddArtistInDB.Text = "Add the new concert";
            AddArtistInDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
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
            choseArtistName.TabIndex = 32;
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
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
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
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(261, 269);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(225, 50);
            materialTextBox2.TabIndex = 35;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
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
            materialLabel5.Location = new Point(320, 402);
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
            materialLabel6.Location = new Point(320, 402);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(187, 19);
            materialLabel6.TabIndex = 38;
            materialLabel6.Text = "Concert added succesfully";
            materialLabel6.Visible = false;
            // 
            // addNewConcert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = materialButton2;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialTextBox2);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel3);
            Controls.Add(choseArtistName);
            Controls.Add(AddArtistInDB);
            Controls.Add(addConcertHourBox);
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
        private MaterialSkin.Controls.MaterialTextBox addConcertHourBox;
        private MaterialSkin.Controls.MaterialButton AddArtistInDB;
        private MaterialSkin.Controls.MaterialComboBox choseArtistName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}