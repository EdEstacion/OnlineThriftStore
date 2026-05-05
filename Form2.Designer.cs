namespace Project2_Online_Thrifiting_Store
{
    partial class Form2
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPants = new System.Windows.Forms.Button();
            this.btnTshirts = new System.Windows.Forms.Button();
            this.btnJackets = new System.Windows.Forms.Button();
            this.btnSwaters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(283, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(724, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To The Online Thrifiting Store";
            // 
            // btnPants
            // 
            this.btnPants.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPants.Location = new System.Drawing.Point(112, 151);
            this.btnPants.Name = "btnPants";
            this.btnPants.Size = new System.Drawing.Size(214, 356);
            this.btnPants.TabIndex = 1;
            this.btnPants.Text = "Pants";
            this.btnPants.UseVisualStyleBackColor = true;
            this.btnPants.Click += new System.EventHandler(this.btnPants_Click);
            // 
            // btnTshirts
            // 
            this.btnTshirts.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTshirts.Location = new System.Drawing.Point(410, 151);
            this.btnTshirts.Name = "btnTshirts";
            this.btnTshirts.Size = new System.Drawing.Size(214, 356);
            this.btnTshirts.TabIndex = 2;
            this.btnTshirts.Text = "T-Shirt";
            this.btnTshirts.UseVisualStyleBackColor = true;
            this.btnTshirts.Click += new System.EventHandler(this.btnTshirts_Click);
            // 
            // btnJackets
            // 
            this.btnJackets.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJackets.Location = new System.Drawing.Point(698, 151);
            this.btnJackets.Name = "btnJackets";
            this.btnJackets.Size = new System.Drawing.Size(214, 356);
            this.btnJackets.TabIndex = 3;
            this.btnJackets.Text = "Jackets";
            this.btnJackets.UseVisualStyleBackColor = true;
            this.btnJackets.Click += new System.EventHandler(this.btnJackets_Click);
            // 
            // btnSwaters
            // 
            this.btnSwaters.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwaters.Location = new System.Drawing.Point(990, 151);
            this.btnSwaters.Name = "btnSwaters";
            this.btnSwaters.Size = new System.Drawing.Size(214, 356);
            this.btnSwaters.TabIndex = 4;
            this.btnSwaters.Text = "Sweaters";
            this.btnSwaters.UseVisualStyleBackColor = true;
            this.btnSwaters.Click += new System.EventHandler(this.btnSwaters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select The Category You Want To Shop";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwaters);
            this.Controls.Add(this.btnJackets);
            this.Controls.Add(this.btnTshirts);
            this.Controls.Add(this.btnPants);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPants;
        private System.Windows.Forms.Button btnTshirts;
        private System.Windows.Forms.Button btnJackets;
        private System.Windows.Forms.Button btnSwaters;
        private System.Windows.Forms.Label label1;
    }
}