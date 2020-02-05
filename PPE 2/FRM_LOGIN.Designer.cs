namespace PPE_2
{
    partial class FRM_LOGIN
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.TXT_MDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.TXT_NOM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_MDP
            // 
            this.TXT_MDP.BackColor = System.Drawing.Color.LightGray;
            this.TXT_MDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TXT_MDP.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_MDP.Location = new System.Drawing.Point(26, 184);
            this.TXT_MDP.Name = "TXT_MDP";
            this.TXT_MDP.Size = new System.Drawing.Size(246, 19);
            this.TXT_MDP.TabIndex = 3;
            this.TXT_MDP.Text = "Mot de passe";
            this.TXT_MDP.Click += new System.EventHandler(this.TXT_MDP_Click);
            this.TXT_MDP.TextChanged += new System.EventHandler(this.TXT_MDP_TextChanged);
            this.TXT_MDP.Leave += new System.EventHandler(this.TXT_MDP_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (9)))), ((int) (((byte) (35)))),
                ((int) (((byte) (79)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(39, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Connexion Aloha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.AccessibleDescription = "";
            this.BTN_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (9)))), ((int) (((byte) (35)))),
                ((int) (((byte) (79)))));
            this.BTN_LOGIN.FlatAppearance.BorderSize = 0;
            this.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.White;
            this.BTN_LOGIN.Location = new System.Drawing.Point(215, 282);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(102, 34);
            this.BTN_LOGIN.TabIndex = 4;
            this.BTN_LOGIN.Text = "Connexion";
            this.BTN_LOGIN.UseVisualStyleBackColor = false;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // TXT_NOM
            // 
            this.TXT_NOM.AcceptsTab = true;
            this.TXT_NOM.AccessibleDescription = "";
            this.TXT_NOM.AccessibleName = "";
            this.TXT_NOM.BackColor = System.Drawing.Color.LightGray;
            this.TXT_NOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_NOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TXT_NOM.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_NOM.Location = new System.Drawing.Point(26, 119);
            this.TXT_NOM.Name = "TXT_NOM";
            this.TXT_NOM.Size = new System.Drawing.Size(246, 19);
            this.TXT_NOM.TabIndex = 2;
            this.TXT_NOM.Tag = "";
            this.TXT_NOM.Text = "Nom d\'utilisateur";
            this.TXT_NOM.Click += new System.EventHandler(this.TXT_NOM_Click);
            this.TXT_NOM.TextChanged += new System.EventHandler(this.TXT_NOM_TextChanged);
            this.TXT_NOM.Leave += new System.EventHandler(this.TXT_NOM_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(26, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(26, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 1);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.AccessibleDescription = "";
            this.BTN_CANCEL.BackColor = System.Drawing.Color.DimGray;
            this.BTN_CANCEL.FlatAppearance.BorderSize = 0;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(26, 287);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(93, 25);
            this.BTN_CANCEL.TabIndex = 1;
            this.BTN_CANCEL.Text = "Annuler";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_MDP);
            this.Controls.Add(this.TXT_NOM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FRM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camping Aloha";
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_LOGIN_MouseDown);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox TXT_MDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.TextBox TXT_NOM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTN_CANCEL;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

