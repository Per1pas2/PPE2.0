namespace PPE_2
{
    partial class FRM_ADMIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADMIN));
            this.BTN_SECRETAIRE = new System.Windows.Forms.Button();
            this.BTN_CHEF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // BTN_SECRETAIRE
            // 
            this.BTN_SECRETAIRE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_SECRETAIRE.BackColor = System.Drawing.Color.OrangeRed;
            this.BTN_SECRETAIRE.FlatAppearance.BorderSize = 0;
            this.BTN_SECRETAIRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SECRETAIRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BTN_SECRETAIRE.Location = new System.Drawing.Point(14, 14);
            this.BTN_SECRETAIRE.Name = "BTN_SECRETAIRE";
            this.BTN_SECRETAIRE.Size = new System.Drawing.Size(232, 99);
            this.BTN_SECRETAIRE.TabIndex = 0;
            this.BTN_SECRETAIRE.Text = "Interface secrétaire";
            this.BTN_SECRETAIRE.UseVisualStyleBackColor = false;
            this.BTN_SECRETAIRE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_CHEF
            // 
            this.BTN_CHEF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_CHEF.BackColor = System.Drawing.Color.Olive;
            this.BTN_CHEF.FlatAppearance.BorderSize = 0;
            this.BTN_CHEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CHEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BTN_CHEF.Location = new System.Drawing.Point(14, 120);
            this.BTN_CHEF.Name = "BTN_CHEF";
            this.BTN_CHEF.Size = new System.Drawing.Size(232, 99);
            this.BTN_CHEF.TabIndex = 1;
            this.BTN_CHEF.Text = "Interface annimateur";
            this.BTN_CHEF.UseVisualStyleBackColor = false;
            this.BTN_CHEF.Click += new System.EventHandler(this.BTN_CHEF_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(14, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 99);
            this.button1.TabIndex = 2;
            this.button1.Text = "Interface technicien";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.Location = new System.Drawing.Point(13, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 99);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FRM_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(259, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_CHEF);
            this.Controls.Add(this.BTN_SECRETAIRE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FRM_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interface Admin";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BTN_SECRETAIRE;
        private System.Windows.Forms.Button BTN_CHEF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}