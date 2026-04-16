namespace Biblioteca
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bemVindo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bemVindo
            // 
            this.bemVindo.AutoSize = true;
            this.bemVindo.BackColor = System.Drawing.Color.LightCoral;
            this.bemVindo.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bemVindo.Location = new System.Drawing.Point(21, 9);
            this.bemVindo.Name = "bemVindo";
            this.bemVindo.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.bemVindo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bemVindo.Size = new System.Drawing.Size(365, 39);
            this.bemVindo.TabIndex = 0;
            this.bemVindo.Text = "Bem-Vindo!!!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(100, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bemVindo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 371);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bemVindo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}