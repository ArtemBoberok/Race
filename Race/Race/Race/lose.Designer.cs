namespace Race
{
    partial class lose
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
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.DarkRed;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Stop.Location = new System.Drawing.Point(94, 129);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(97, 47);
            this.Stop.TabIndex = 0;
            this.Stop.Text = "Выйти";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ВЫ ПРОИГРАЛИ!";
            // 
            // lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
    }
}