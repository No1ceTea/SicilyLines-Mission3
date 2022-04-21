using System;

namespace BankUI.Vue
{
    partial class Liaison
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CBportA = new System.Windows.Forms.ComboBox();
            this.CBportD = new System.Windows.Forms.ComboBox();
            this.BTNAffichTarif = new System.Windows.Forms.Button();
            this.BTNSuppr = new System.Windows.Forms.Button();
            this.BTNModif = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBduree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNAjout = new System.Windows.Forms.Button();
            this.ComptesUsersLabel = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckedUser = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.LBLiaison = new System.Windows.Forms.ListBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.guna2Panel1.Controls.Add(this.LBLiaison);
            this.guna2Panel1.Controls.Add(this.CBportA);
            this.guna2Panel1.Controls.Add(this.CBportD);
            this.guna2Panel1.Controls.Add(this.BTNAffichTarif);
            this.guna2Panel1.Controls.Add(this.BTNSuppr);
            this.guna2Panel1.Controls.Add(this.BTNModif);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.TBduree);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.BTNAjout);
            this.guna2Panel1.Controls.Add(this.ComptesUsersLabel);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(920, 620);
            this.guna2Panel1.TabIndex = 0;
            // 
            // CBportA
            // 
            this.CBportA.FormattingEnabled = true;
            this.CBportA.Location = new System.Drawing.Point(159, 304);
            this.CBportA.Name = "CBportA";
            this.CBportA.Size = new System.Drawing.Size(121, 21);
            this.CBportA.TabIndex = 20;
            // 
            // CBportD
            // 
            this.CBportD.FormattingEnabled = true;
            this.CBportD.Location = new System.Drawing.Point(30, 304);
            this.CBportD.Name = "CBportD";
            this.CBportD.Size = new System.Drawing.Size(121, 21);
            this.CBportD.TabIndex = 19;
            this.CBportD.SelectedIndexChanged += new System.EventHandler(this.CBportD_SelectedIndexChanged);
            // 
            // BTNAffichTarif
            // 
            this.BTNAffichTarif.Location = new System.Drawing.Point(656, 302);
            this.BTNAffichTarif.Name = "BTNAffichTarif";
            this.BTNAffichTarif.Size = new System.Drawing.Size(103, 23);
            this.BTNAffichTarif.TabIndex = 17;
            this.BTNAffichTarif.Text = "Afficher le tarif";
            this.BTNAffichTarif.UseVisualStyleBackColor = true;
            // 
            // BTNSuppr
            // 
            this.BTNSuppr.Location = new System.Drawing.Point(575, 302);
            this.BTNSuppr.Name = "BTNSuppr";
            this.BTNSuppr.Size = new System.Drawing.Size(75, 23);
            this.BTNSuppr.TabIndex = 14;
            this.BTNSuppr.Text = "Supprimer";
            this.BTNSuppr.UseVisualStyleBackColor = true;
            this.BTNSuppr.Click += new System.EventHandler(this.BTNSuppr_Click);
            // 
            // BTNModif
            // 
            this.BTNModif.Location = new System.Drawing.Point(494, 302);
            this.BTNModif.Name = "BTNModif";
            this.BTNModif.Size = new System.Drawing.Size(75, 23);
            this.BTNModif.TabIndex = 13;
            this.BTNModif.Text = "Modifier";
            this.BTNModif.UseVisualStyleBackColor = true;
            this.BTNModif.Click += new System.EventHandler(this.BTNModif_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Durée";
            // 
            // TBduree
            // 
            this.TBduree.Location = new System.Drawing.Point(286, 305);
            this.TBduree.Name = "TBduree";
            this.TBduree.Size = new System.Drawing.Size(100, 20);
            this.TBduree.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(156, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port d\'arrivé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port de départ";
            // 
            // BTNAjout
            // 
            this.BTNAjout.Location = new System.Drawing.Point(413, 302);
            this.BTNAjout.Name = "BTNAjout";
            this.BTNAjout.Size = new System.Drawing.Size(75, 23);
            this.BTNAjout.TabIndex = 6;
            this.BTNAjout.Text = "Ajouter";
            this.BTNAjout.UseVisualStyleBackColor = true;
            this.BTNAjout.Click += new System.EventHandler(this.BTNAjout_Click);
            // 
            // ComptesUsersLabel
            // 
            this.ComptesUsersLabel.AutoSize = true;
            this.ComptesUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComptesUsersLabel.ForeColor = System.Drawing.Color.White;
            this.ComptesUsersLabel.Location = new System.Drawing.Point(26, 90);
            this.ComptesUsersLabel.Name = "ComptesUsersLabel";
            this.ComptesUsersLabel.Size = new System.Drawing.Size(137, 20);
            this.ComptesUsersLabel.TabIndex = 4;
            this.ComptesUsersLabel.Text = "Listes des liaisons";
            this.ComptesUsersLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 46);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(920, 10);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.guna2Panel2.Controls.Add(this.guna2VSeparator2);
            this.guna2Panel2.Controls.Add(this.guna2VSeparator3);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.CheckedUser);
            this.guna2Panel2.Controls.Add(this.guna2Button6);
            this.guna2Panel2.Controls.Add(this.guna2Button5);
            this.guna2Panel2.Controls.Add(this.guna2Button4);
            this.guna2Panel2.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(920, 50);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(837, 13);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(14, 26);
            this.guna2VSeparator2.TabIndex = 12;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Location = new System.Drawing.Point(669, 13);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(14, 26);
            this.guna2VSeparator3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(769, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Admin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckedUser
            // 
            this.CheckedUser.AutoSize = true;
            this.CheckedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedUser.ForeColor = System.Drawing.Color.White;
            this.CheckedUser.Location = new System.Drawing.Point(684, 15);
            this.CheckedUser.Name = "CheckedUser";
            this.CheckedUser.Size = new System.Drawing.Size(75, 16);
            this.CheckedUser.TabIndex = 9;
            this.CheckedUser.Text = "Utilisateur : ";
            this.CheckedUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(329, 12);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(91, 28);
            this.guna2Button6.TabIndex = 8;
            this.guna2Button6.Text = "Liasons";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(550, 12);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(123, 28);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "MODIFICATION";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(431, 12);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(107, 28);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Opérations";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(159, 13);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(14, 26);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(172, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(149, 28);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Base de données";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::BankUI.Properties.Resources.icons8_macos_fermer_90;
            this.guna2Button2.Location = new System.Drawing.Point(885, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(27, 28);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SICILYLINES";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LBLiaison
            // 
            this.LBLiaison.FormattingEnabled = true;
            this.LBLiaison.Location = new System.Drawing.Point(30, 113);
            this.LBLiaison.Name = "LBLiaison";
            this.LBLiaison.Size = new System.Drawing.Size(729, 160);
            this.LBLiaison.TabIndex = 3;
            // 
            // Liaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 620);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Liaison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label ComptesUsersLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CheckedUser;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private System.Windows.Forms.Button BTNSuppr;
        private System.Windows.Forms.Button BTNModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBduree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNAjout;
        private System.Windows.Forms.Button BTNAffichTarif;
        private System.Windows.Forms.ComboBox CBportA;
        private System.Windows.Forms.ComboBox CBportD;
        private System.Windows.Forms.ListBox LBLiaison;
    }
}

