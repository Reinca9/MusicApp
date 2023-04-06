namespace music
{
    partial class addNewArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewArtist));
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            AddArtistNameBox = new MaterialSkin.Controls.MaterialTextBox();
            AddArtistInfoBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            AddArtistInDB = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialButton2
            // 
            resources.ApplyResources(materialButton2, "materialButton2");
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // AddArtistNameBox
            // 
            AddArtistNameBox.AnimateReadOnly = false;
            AddArtistNameBox.BorderStyle = BorderStyle.None;
            AddArtistNameBox.Depth = 0;
            resources.ApplyResources(AddArtistNameBox, "AddArtistNameBox");
            AddArtistNameBox.LeadingIcon = null;
            AddArtistNameBox.MouseState = MaterialSkin.MouseState.OUT;
            AddArtistNameBox.Name = "AddArtistNameBox";
            AddArtistNameBox.TrailingIcon = null;
            // 
            // AddArtistInfoBox
            // 
            AddArtistInfoBox.AnimateReadOnly = false;
            AddArtistInfoBox.BorderStyle = BorderStyle.None;
            AddArtistInfoBox.Depth = 0;
            resources.ApplyResources(AddArtistInfoBox, "AddArtistInfoBox");
            AddArtistInfoBox.LeadingIcon = null;
            AddArtistInfoBox.MouseState = MaterialSkin.MouseState.OUT;
            AddArtistInfoBox.Name = "AddArtistInfoBox";
            AddArtistInfoBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            resources.ApplyResources(materialLabel1, "materialLabel1");
            materialLabel1.Depth = 0;
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(materialLabel2, "materialLabel2");
            materialLabel2.Depth = 0;
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            // 
            // AddArtistInDB
            // 
            resources.ApplyResources(AddArtistInDB, "AddArtistInDB");
            AddArtistInDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddArtistInDB.Depth = 0;
            AddArtistInDB.HighEmphasis = true;
            AddArtistInDB.Icon = null;
            AddArtistInDB.MouseState = MaterialSkin.MouseState.HOVER;
            AddArtistInDB.Name = "AddArtistInDB";
            AddArtistInDB.NoAccentTextColor = Color.Empty;
            AddArtistInDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddArtistInDB.UseAccentColor = false;
            AddArtistInDB.UseVisualStyleBackColor = true;
            AddArtistInDB.Click += AddArtistInDB_Click;
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
            materialLabel4.Depth = 0;
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            // 
            // addNewArtist
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = materialButton2;
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(AddArtistInDB);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(AddArtistInfoBox);
            Controls.Add(AddArtistNameBox);
            Controls.Add(materialButton2);
            Name = "addNewArtist";
            Opacity = 0.9D;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox AddArtistNameBox;
        private MaterialSkin.Controls.MaterialTextBox AddArtistInfoBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton AddArtistInDB;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}