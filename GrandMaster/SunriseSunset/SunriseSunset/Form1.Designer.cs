
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.webView_chart = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calc.Location = new System.Drawing.Point(344, 3);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(94, 48);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(229, 378);
            this.rchtxbx_output.TabIndex = 1;
            this.rchtxbx_output.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(685, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 48);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SunriseSunsetDateTimePicker
            // 
            this.SunriseSunsetDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SunriseSunsetDateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.SunriseSunsetDateTimePicker.Name = "SunriseSunsetDateTimePicker";
            this.SunriseSunsetDateTimePicker.Size = new System.Drawing.Size(229, 26);
            this.SunriseSunsetDateTimePicker.TabIndex = 3;
            this.SunriseSunsetDateTimePicker.ValueChanged += new System.EventHandler(this.SunriseSunsetDateTimePicker_ValueChanged);
            // 
            // cmbobx_airport_info
            // 
            this.cmbobx_airport_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbobx_airport_info.FormattingEnabled = true;
            this.cmbobx_airport_info.Location = new System.Drawing.Point(0, 0);
            this.cmbobx_airport_info.Name = "cmbobx_airport_info";
            this.cmbobx_airport_info.Size = new System.Drawing.Size(543, 28);
            this.cmbobx_airport_info.Sorted = true;
            this.cmbobx_airport_info.TabIndex = 4;
            this.cmbobx_airport_info.SelectedIndexChanged += new System.EventHandler(this.cmbobx_airport_info_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(3, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 48);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 504);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SunriseSunsetDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rchtxbx_output);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 378);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbobx_airport_info);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 34);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(248, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 378);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(8, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(783, 54);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_calc, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.webView_chart);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(543, 378);
            this.panel6.TabIndex = 0;
            // 
            // webView_chart
            // 
            this.webView_chart.AllowExternalDrop = true;
            this.webView_chart.CreationProperties = null;
            this.webView_chart.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_chart.Location = new System.Drawing.Point(0, 0);
            this.webView_chart.Name = "webView_chart";
            this.webView_chart.Size = new System.Drawing.Size(543, 378);
            this.webView_chart.TabIndex = 0;
            this.webView_chart.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunrise and Sunset Times";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RichTextBox rchtxbx_output;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker SunriseSunsetDateTimePicker;
        private System.Windows.Forms.ComboBox cmbobx_airport_info;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_chart;
    }
}

