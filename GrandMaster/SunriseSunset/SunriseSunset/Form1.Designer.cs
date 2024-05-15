
namespace SunriseSunset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_calc = new System.Windows.Forms.Button();
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SunriseSunsetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbobx_airport_info = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(343, 441);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(113, 51);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Location = new System.Drawing.Point(14, 47);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(774, 388);
            this.rchtxbx_output.TabIndex = 1;
            this.rchtxbx_output.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(675, 441);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 51);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SunriseSunsetDateTimePicker
            // 
            this.SunriseSunsetDateTimePicker.Location = new System.Drawing.Point(14, 11);
            this.SunriseSunsetDateTimePicker.Name = "SunriseSunsetDateTimePicker";
            this.SunriseSunsetDateTimePicker.Size = new System.Drawing.Size(202, 26);
            this.SunriseSunsetDateTimePicker.TabIndex = 3;
            // 
            // cmbobx_airport_info
            // 
            this.cmbobx_airport_info.FormattingEnabled = true;
            this.cmbobx_airport_info.Location = new System.Drawing.Point(470, 13);
            this.cmbobx_airport_info.Name = "cmbobx_airport_info";
            this.cmbobx_airport_info.Size = new System.Drawing.Size(318, 28);
            this.cmbobx_airport_info.Sorted = true;
            this.cmbobx_airport_info.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Airport";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 441);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 51);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbobx_airport_info);
            this.Controls.Add(this.SunriseSunsetDateTimePicker);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.rchtxbx_output);
            this.Controls.Add(this.btn_calc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunrise and Sunset Times";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RichTextBox rchtxbx_output;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker SunriseSunsetDateTimePicker;
        private System.Windows.Forms.ComboBox cmbobx_airport_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
    }
}

