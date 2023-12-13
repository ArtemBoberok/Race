namespace Race
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lamborghini1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoad = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxRoad2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lamborghini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lamborghini1
            // 
            this.Lamborghini1.BackColor = System.Drawing.Color.Transparent;
            this.Lamborghini1.Image = global::Race.Properties.Resources.Lamborghini1;
            this.Lamborghini1.Location = new System.Drawing.Point(511, 512);
            this.Lamborghini1.Name = "Lamborghini1";
            this.Lamborghini1.Size = new System.Drawing.Size(265, 500);
            this.Lamborghini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lamborghini1.TabIndex = 1;
            this.Lamborghini1.TabStop = false;
            // 
            // pictureBoxRoad
            // 
            this.pictureBoxRoad.Image = global::Race.Properties.Resources.Road;
            this.pictureBoxRoad.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRoad.Name = "pictureBoxRoad";
            this.pictureBoxRoad.Size = new System.Drawing.Size(1024, 1024);
            this.pictureBoxRoad.TabIndex = 0;
            this.pictureBoxRoad.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxRoad2
            // 
            this.pictureBoxRoad2.Image = global::Race.Properties.Resources.Road;
            this.pictureBoxRoad2.Location = new System.Drawing.Point(0, -1024);
            this.pictureBoxRoad2.Name = "pictureBoxRoad2";
            this.pictureBoxRoad2.Size = new System.Drawing.Size(1024, 1024);
            this.pictureBoxRoad2.TabIndex = 2;
            this.pictureBoxRoad2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Race.Properties.Resources.Cone11;
            this.pictureBox1.Location = new System.Drawing.Point(80, -100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Race.Properties.Resources.Cone11;
            this.pictureBox2.Location = new System.Drawing.Point(600, -1000);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Race.Properties.Resources.Road;
            this.ClientSize = new System.Drawing.Size(1024, 1024);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lamborghini1);
            this.Controls.Add(this.pictureBoxRoad);
            this.Controls.Add(this.pictureBoxRoad2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Lamborghini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoad;
        private System.Windows.Forms.PictureBox Lamborghini1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxRoad2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

