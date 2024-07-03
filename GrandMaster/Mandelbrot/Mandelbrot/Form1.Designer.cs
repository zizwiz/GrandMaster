﻿namespace myMandelbrot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.mnuScaleMnu = new System.Windows.Forms.MenuItem();
            this.mnuScale_2 = new System.Windows.Forms.MenuItem();
            this.mnuScale_4 = new System.Windows.Forms.MenuItem();
            this.mnuScale_8 = new System.Windows.Forms.MenuItem();
            this.mnuScaleFull = new System.Windows.Forms.MenuItem();
            this.mnuScaleRefreshSep = new System.Windows.Forms.MenuItem();
            this.mnuScaleRefresh = new System.Windows.Forms.MenuItem();
            this.mnuOpt = new System.Windows.Forms.MenuItem();
            this.mnuOptOptions = new System.Windows.Forms.MenuItem();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuScaleMnu,
            this.mnuOpt});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileSaveAs});
            this.mnuFile.Text = "&File";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Index = 0;
            this.mnuFileSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuFileSaveAs.Text = "&Save As...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuScaleMnu
            // 
            this.mnuScaleMnu.Index = 1;
            this.mnuScaleMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuScale_2,
            this.mnuScale_4,
            this.mnuScale_8,
            this.mnuScaleFull,
            this.mnuScaleRefreshSep,
            this.mnuScaleRefresh});
            this.mnuScaleMnu.Text = "&Scale";
            // 
            // mnuScale_2
            // 
            this.mnuScale_2.Index = 0;
            this.mnuScale_2.Tag = "2";
            this.mnuScale_2.Text = "x&2";
            this.mnuScale_2.Click += new System.EventHandler(this.mnuScale_Click);
            // 
            // mnuScale_4
            // 
            this.mnuScale_4.Index = 1;
            this.mnuScale_4.Tag = "4";
            this.mnuScale_4.Text = "x&4";
            this.mnuScale_4.Click += new System.EventHandler(this.mnuScale_Click);
            // 
            // mnuScale_8
            // 
            this.mnuScale_8.Index = 2;
            this.mnuScale_8.Tag = "8";
            this.mnuScale_8.Text = "x&8";
            this.mnuScale_8.Click += new System.EventHandler(this.mnuScale_Click);
            // 
            // mnuScaleFull
            // 
            this.mnuScaleFull.Index = 3;
            this.mnuScaleFull.Tag = "";
            this.mnuScaleFull.Text = "&Full Scale";
            this.mnuScaleFull.Click += new System.EventHandler(this.mnuScaleFull_Click);
            // 
            // mnuScaleRefreshSep
            // 
            this.mnuScaleRefreshSep.Index = 4;
            this.mnuScaleRefreshSep.Text = "-";
            // 
            // mnuScaleRefresh
            // 
            this.mnuScaleRefresh.Index = 5;
            this.mnuScaleRefresh.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.mnuScaleRefresh.Text = "&Refresh";
            this.mnuScaleRefresh.Click += new System.EventHandler(this.mnuScaleRefresh_Click);
            // 
            // mnuOpt
            // 
            this.mnuOpt.Index = 2;
            this.mnuOpt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOptOptions});
            this.mnuOpt.Text = "&Options";
            // 
            // mnuOptOptions
            // 
            this.mnuOptOptions.Index = 0;
            this.mnuOptOptions.Text = "&Set Options";
            this.mnuOptOptions.Click += new System.EventHandler(this.mnuOptOptions_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "bmp";
            this.dlgSaveFile.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif;*.tiff|BMP|*.bmp|JPEG|*.jpg;*.jp" +
    "eg|GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff|All Files|*.*";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Black;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(760, 707);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 713);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picCanvas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 707);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 713);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "Mandelbrot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MainMenu MainMenu1;
        public System.Windows.Forms.MenuItem mnuFile;
        public System.Windows.Forms.MenuItem mnuFileSaveAs;
        public System.Windows.Forms.MenuItem mnuScaleMnu;
        public System.Windows.Forms.MenuItem mnuScale_2;
        public System.Windows.Forms.MenuItem mnuScale_4;
        public System.Windows.Forms.MenuItem mnuScale_8;
        public System.Windows.Forms.MenuItem mnuScaleFull;
        public System.Windows.Forms.MenuItem mnuScaleRefreshSep;
        public System.Windows.Forms.MenuItem mnuScaleRefresh;
        public System.Windows.Forms.MenuItem mnuOpt;
        public System.Windows.Forms.MenuItem mnuOptOptions;
        internal System.Windows.Forms.SaveFileDialog dlgSaveFile;
        internal System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}

