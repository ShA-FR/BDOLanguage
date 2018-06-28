namespace BDOLanguage
{
    partial class BDOLanguage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDOLanguage));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.SetPathBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.GamePathTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SetLanguageBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SetGamePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(439, 171);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = resources.GetString("materialLabel1.Text");
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-6, 266);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(522, 10);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-6, 63);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(522, 10);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // SetPathBtn
            // 
            this.SetPathBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetPathBtn.Depth = 0;
            this.SetPathBtn.Icon = null;
            this.SetPathBtn.Location = new System.Drawing.Point(8, 285);
            this.SetPathBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetPathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SetPathBtn.Name = "SetPathBtn";
            this.SetPathBtn.Primary = false;
            this.SetPathBtn.Size = new System.Drawing.Size(466, 23);
            this.SetPathBtn.TabIndex = 3;
            this.SetPathBtn.Text = "Set path";
            this.SetPathBtn.UseVisualStyleBackColor = true;
            this.SetPathBtn.Click += new System.EventHandler(this.SetPathBtn_Click);
            // 
            // GamePathTxt
            // 
            this.GamePathTxt.Depth = 0;
            this.GamePathTxt.Hint = "";
            this.GamePathTxt.Location = new System.Drawing.Point(57, 317);
            this.GamePathTxt.MaxLength = 32767;
            this.GamePathTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.GamePathTxt.Name = "GamePathTxt";
            this.GamePathTxt.PasswordChar = '\0';
            this.GamePathTxt.ReadOnly = true;
            this.GamePathTxt.SelectedText = "";
            this.GamePathTxt.SelectionLength = 0;
            this.GamePathTxt.SelectionStart = 0;
            this.GamePathTxt.Size = new System.Drawing.Size(417, 23);
            this.GamePathTxt.TabIndex = 4;
            this.GamePathTxt.TabStop = false;
            this.GamePathTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 321);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Path :";
            // 
            // SetLanguageBtn
            // 
            this.SetLanguageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetLanguageBtn.Depth = 0;
            this.SetLanguageBtn.Enabled = false;
            this.SetLanguageBtn.Icon = null;
            this.SetLanguageBtn.Location = new System.Drawing.Point(8, 391);
            this.SetLanguageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetLanguageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SetLanguageBtn.Name = "SetLanguageBtn";
            this.SetLanguageBtn.Primary = false;
            this.SetLanguageBtn.Size = new System.Drawing.Size(466, 23);
            this.SetLanguageBtn.TabIndex = 6;
            this.SetLanguageBtn.Text = "Set Language";
            this.SetLanguageBtn.UseVisualStyleBackColor = true;
            this.SetLanguageBtn.Click += new System.EventHandler(this.SetLanguageBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Chinese (CN)",
            "Japanese (JP)",
            "Korean (KR)",
            "Russian (RU)"});
            this.comboBox1.Location = new System.Drawing.Point(91, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 360);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Language :";
            // 
            // BDOLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 425);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SetLanguageBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.GamePathTxt);
            this.Controls.Add(this.SetPathBtn);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BDOLanguage";
            this.Resizable = false;
            this.Text = "BDOLanguage";
            this.Load += new System.EventHandler(this.BDOLanguage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialFlatButton SetPathBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField GamePathTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton SetLanguageBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FolderBrowserDialog SetGamePath;
    }
}

