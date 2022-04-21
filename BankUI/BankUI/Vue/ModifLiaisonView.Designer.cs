namespace BankUI.Vue
{
    partial class ModifLiaisonView
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
            this.TBidLiaison = new System.Windows.Forms.TextBox();
            this.TBnomPortD = new System.Windows.Forms.TextBox();
            this.TBnomPortA = new System.Windows.Forms.TextBox();
            this.TBduree = new System.Windows.Forms.TextBox();
            this.BTNValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBidLiaison
            // 
            this.TBidLiaison.Location = new System.Drawing.Point(120, 12);
            this.TBidLiaison.Name = "TBidLiaison";
            this.TBidLiaison.Size = new System.Drawing.Size(100, 20);
            this.TBidLiaison.TabIndex = 0;
            // 
            // TBnomPortD
            // 
            this.TBnomPortD.Location = new System.Drawing.Point(120, 38);
            this.TBnomPortD.Name = "TBnomPortD";
            this.TBnomPortD.Size = new System.Drawing.Size(100, 20);
            this.TBnomPortD.TabIndex = 1;
            // 
            // TBnomPortA
            // 
            this.TBnomPortA.Location = new System.Drawing.Point(120, 64);
            this.TBnomPortA.Name = "TBnomPortA";
            this.TBnomPortA.Size = new System.Drawing.Size(100, 20);
            this.TBnomPortA.TabIndex = 2;
            // 
            // TBduree
            // 
            this.TBduree.Location = new System.Drawing.Point(120, 90);
            this.TBduree.Name = "TBduree";
            this.TBduree.Size = new System.Drawing.Size(100, 20);
            this.TBduree.TabIndex = 3;
            // 
            // BTNValider
            // 
            this.BTNValider.Location = new System.Drawing.Point(120, 149);
            this.BTNValider.Name = "BTNValider";
            this.BTNValider.Size = new System.Drawing.Size(100, 28);
            this.BTNValider.TabIndex = 4;
            this.BTNValider.Text = "Valider";
            this.BTNValider.UseVisualStyleBackColor = true;
            this.BTNValider.Click += new System.EventHandler(this.BTNValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Liaison :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port de départ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port d\'arrivée : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durée :";
            // 
            // ModifLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNValider);
            this.Controls.Add(this.TBduree);
            this.Controls.Add(this.TBnomPortA);
            this.Controls.Add(this.TBnomPortD);
            this.Controls.Add(this.TBidLiaison);
            this.Name = "ModifLiaison";
            this.Text = "ModifLiaison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBidLiaison;
        private System.Windows.Forms.TextBox TBnomPortD;
        private System.Windows.Forms.TextBox TBnomPortA;
        private System.Windows.Forms.TextBox TBduree;
        private System.Windows.Forms.Button BTNValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}