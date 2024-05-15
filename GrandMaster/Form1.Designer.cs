
namespace GrandMaster
{
    partial class Form1
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
            this.btn_solar_times = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_solar_times
            // 
            this.btn_solar_times.Location = new System.Drawing.Point(51, 69);
            this.btn_solar_times.Name = "btn_solar_times";
            this.btn_solar_times.Size = new System.Drawing.Size(151, 63);
            this.btn_solar_times.TabIndex = 0;
            this.btn_solar_times.Text = "Solar Times";
            this.btn_solar_times.UseVisualStyleBackColor = true;
            this.btn_solar_times.Click += new System.EventHandler(this.btn_solar_times_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_solar_times);
            this.Name = "Form1";
            this.Text = "GrandMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_solar_times;
    }
}

