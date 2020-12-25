namespace Server_Exercise2
{
    partial class Server
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
            this.buttonOff = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(365, 249);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(77, 36);
            this.buttonOff.TabIndex = 8;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(365, 207);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(77, 36);
            this.buttonOn.TabIndex = 7;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Klik ON untuk Menghidupkan Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Off";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

