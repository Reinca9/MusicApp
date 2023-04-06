namespace music
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            fermerToolStripMenuItem = new ToolStripMenuItem();
            editionToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            affichageToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem1 = new ToolStripMenuItem();
            ouvrirAvecToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            label1 = new Label();
            AddConcertButton = new MaterialSkin.Controls.MaterialButton();
            DeleteConcertButton = new MaterialSkin.Controls.MaterialButton();
            RefreshConcertListButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dataGridView2 = new DataGridView();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editionToolStripMenuItem, affichageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1377, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, fermerToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(122, 22);
            nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(122, 22);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // fermerToolStripMenuItem
            // 
            fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            fermerToolStripMenuItem.Size = new Size(122, 22);
            fermerToolStripMenuItem.Text = "Fermer";
            // 
            // editionToolStripMenuItem
            // 
            editionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { couperToolStripMenuItem, collerToolStripMenuItem, supprimerToolStripMenuItem });
            editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            editionToolStripMenuItem.Size = new Size(56, 20);
            editionToolStripMenuItem.Text = "Edition";
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(129, 22);
            couperToolStripMenuItem.Text = "Couper";
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(129, 22);
            collerToolStripMenuItem.Text = "Coller";
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(129, 22);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // affichageToolStripMenuItem
            // 
            affichageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirToolStripMenuItem1, ouvrirAvecToolStripMenuItem });
            affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            affichageToolStripMenuItem.Size = new Size(70, 20);
            affichageToolStripMenuItem.Text = "Affichage";
            // 
            // ouvrirToolStripMenuItem1
            // 
            ouvrirToolStripMenuItem1.Name = "ouvrirToolStripMenuItem1";
            ouvrirToolStripMenuItem1.Size = new Size(134, 22);
            ouvrirToolStripMenuItem1.Text = "Ouvrir";
            // 
            // ouvrirAvecToolStripMenuItem
            // 
            ouvrirAvecToolStripMenuItem.Name = "ouvrirAvecToolStripMenuItem";
            ouvrirAvecToolStripMenuItem.Size = new Size(134, 22);
            ouvrirAvecToolStripMenuItem.Text = "Ouvrir avec";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(45, 49);
            materialButton1.Margin = new Padding(6, 8, 6, 8);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Padding = new Padding(1);
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click_1;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Location = new Point(170, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(476, 359);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(134, 49);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(89, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "Register";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(45, 113);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(128, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Liste des concerts";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(45, 163);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(219, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Login to access the concert list";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Sitka Subheading", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 49);
            label1.Name = "label1";
            label1.Size = new Size(140, 18);
            label1.TabIndex = 9;
            label1.Text = "Vous êtes bien connecté";
            label1.Visible = false;
            // 
            // AddConcertButton
            // 
            AddConcertButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddConcertButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddConcertButton.Depth = 0;
            AddConcertButton.HighEmphasis = true;
            AddConcertButton.Icon = null;
            AddConcertButton.Location = new Point(263, 146);
            AddConcertButton.Margin = new Padding(4, 6, 4, 6);
            AddConcertButton.MouseState = MaterialSkin.MouseState.HOVER;
            AddConcertButton.Name = "AddConcertButton";
            AddConcertButton.NoAccentTextColor = Color.Empty;
            AddConcertButton.Size = new Size(179, 36);
            AddConcertButton.TabIndex = 11;
            AddConcertButton.Text = "Ajouter un concert";
            AddConcertButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddConcertButton.UseAccentColor = false;
            AddConcertButton.UseVisualStyleBackColor = true;
            AddConcertButton.Visible = false;
            AddConcertButton.Click += AddConcertButton_Click;
            // 
            // DeleteConcertButton
            // 
            DeleteConcertButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteConcertButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeleteConcertButton.Depth = 0;
            DeleteConcertButton.HighEmphasis = true;
            DeleteConcertButton.Icon = null;
            DeleteConcertButton.Location = new Point(450, 146);
            DeleteConcertButton.Margin = new Padding(4, 6, 4, 6);
            DeleteConcertButton.MouseState = MaterialSkin.MouseState.HOVER;
            DeleteConcertButton.Name = "DeleteConcertButton";
            DeleteConcertButton.NoAccentTextColor = Color.Empty;
            DeleteConcertButton.Size = new Size(196, 36);
            DeleteConcertButton.TabIndex = 12;
            DeleteConcertButton.Text = "Supprimer un concert";
            DeleteConcertButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DeleteConcertButton.UseAccentColor = false;
            DeleteConcertButton.UseVisualStyleBackColor = true;
            DeleteConcertButton.Visible = false;
            // 
            // RefreshConcertListButton
            // 
            RefreshConcertListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RefreshConcertListButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RefreshConcertListButton.Depth = 0;
            RefreshConcertListButton.HighEmphasis = true;
            RefreshConcertListButton.Icon = null;
            RefreshConcertListButton.Location = new Point(170, 146);
            RefreshConcertListButton.Margin = new Padding(4, 6, 4, 6);
            RefreshConcertListButton.MouseState = MaterialSkin.MouseState.HOVER;
            RefreshConcertListButton.Name = "RefreshConcertListButton";
            RefreshConcertListButton.NoAccentTextColor = Color.Empty;
            RefreshConcertListButton.Size = new Size(84, 36);
            RefreshConcertListButton.TabIndex = 10;
            RefreshConcertListButton.Text = "Refresh";
            RefreshConcertListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            RefreshConcertListButton.UseAccentColor = false;
            RefreshConcertListButton.UseVisualStyleBackColor = true;
            RefreshConcertListButton.Visible = false;
            RefreshConcertListButton.Click += RefreshConcertListButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(766, 113);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(120, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Liste des artistes";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(766, 196);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(397, 359);
            dataGridView2.TabIndex = 14;
            dataGridView2.Visible = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(766, 163);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(186, 19);
            materialLabel4.TabIndex = 15;
            materialLabel4.Text = "Login to see the artists list";
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(766, 146);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(84, 36);
            materialButton3.TabIndex = 16;
            materialButton3.Text = "Refresh";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Visible = false;
            materialButton3.Click += materialButton3_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(1036, 146);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(127, 36);
            materialButton4.TabIndex = 17;
            materialButton4.Text = "Delete artist";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Visible = false;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(875, 146);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(153, 36);
            materialButton5.TabIndex = 18;
            materialButton5.Text = "Add a new artist";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Visible = false;
            materialButton5.Click += materialButton5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 650);
            Controls.Add(materialButton5);
            Controls.Add(materialButton4);
            Controls.Add(materialButton3);
            Controls.Add(materialLabel4);
            Controls.Add(dataGridView2);
            Controls.Add(materialLabel1);
            Controls.Add(DeleteConcertButton);
            Controls.Add(AddConcertButton);
            Controls.Add(RefreshConcertListButton);
            Controls.Add(label1);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialButton2);
            Controls.Add(dataGridView1);
            Controls.Add(materialButton1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem fermerToolStripMenuItem;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripMenuItem affichageToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem1;
        private ToolStripMenuItem ouvrirAvecToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton AddConcertButton;
        private MaterialSkin.Controls.MaterialButton DeleteConcertButton;
        private MaterialSkin.Controls.MaterialButton RefreshConcertListButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
    }
}