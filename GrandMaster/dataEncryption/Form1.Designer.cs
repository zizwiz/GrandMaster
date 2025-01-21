
namespace dataEncryption
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picbx_Original = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picbx_result = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_get_original_pixel_colour = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbx_red_flip_bit7_8 = new System.Windows.Forms.TextBox();
            this.txtbx_red_flip_bit7 = new System.Windows.Forms.TextBox();
            this.txtbx_red_flip_bit8 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbx_original_pixel = new System.Windows.Forms.TextBox();
            this.lbl_original_pixel_value = new System.Windows.Forms.Label();
            this.txtbx_x_coord = new System.Windows.Forms.TextBox();
            this.txtbx_original_blue = new System.Windows.Forms.TextBox();
            this.txtbx_y_coord = new System.Windows.Forms.TextBox();
            this.txtbx_original_green = new System.Windows.Forms.TextBox();
            this.lbl_x_coord = new System.Windows.Forms.Label();
            this.txtbx_original_red = new System.Windows.Forms.TextBox();
            this.lbl_y_coord = new System.Windows.Forms.Label();
            this.lbl_original_r = new System.Windows.Forms.Label();
            this.lbl_original_pixel = new System.Windows.Forms.Label();
            this.lbl_original_g = new System.Windows.Forms.Label();
            this.lbl_original_b = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_save_modified_image = new System.Windows.Forms.Button();
            this.btn_encode_bitmap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_original_alpha = new System.Windows.Forms.Label();
            this.lbl_original_red = new System.Windows.Forms.Label();
            this.lbl_original_blue = new System.Windows.Forms.Label();
            this.lbl_original_green = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1418, 732);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picbx_Original);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1410, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picbx_Original
            // 
            this.picbx_Original.BackColor = System.Drawing.Color.Red;
            this.picbx_Original.Location = new System.Drawing.Point(7, 8);
            this.picbx_Original.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_Original.Name = "picbx_Original";
            this.picbx_Original.Size = new System.Drawing.Size(193, 121);
            this.picbx_Original.TabIndex = 31;
            this.picbx_Original.TabStop = false;
            this.picbx_Original.MouseLeave += new System.EventHandler(this.picbx_Original_MouseLeave);
            this.picbx_Original.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbx_Original_MouseMove);
            this.picbx_Original.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbx_Original_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picbx_result);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1410, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picbx_result
            // 
            this.picbx_result.Location = new System.Drawing.Point(7, 8);
            this.picbx_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbx_result.Name = "picbx_result";
            this.picbx_result.Size = new System.Drawing.Size(339, 193);
            this.picbx_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_result.TabIndex = 33;
            this.picbx_result.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 898);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 732);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 821);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1418, 74);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save_modified_image, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_get_original_pixel_colour, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1418, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_get_original_pixel_colour
            // 
            this.btn_get_original_pixel_colour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_get_original_pixel_colour.Location = new System.Drawing.Point(601, 3);
            this.btn_get_original_pixel_colour.Name = "btn_get_original_pixel_colour";
            this.btn_get_original_pixel_colour.Size = new System.Drawing.Size(194, 68);
            this.btn_get_original_pixel_colour.TabIndex = 30;
            this.btn_get_original_pixel_colour.Text = "Get Original Pixel";
            this.btn_get_original_pixel_colour.UseVisualStyleBackColor = true;
            this.btn_get_original_pixel_colour.Click += new System.EventHandler(this.btn_get_original_pixel_colour_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(1216, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(194, 68);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtbx_red_flip_bit7_8);
            this.panel4.Controls.Add(this.txtbx_red_flip_bit7);
            this.panel4.Controls.Add(this.txtbx_red_flip_bit8);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 68);
            this.panel4.TabIndex = 31;
            // 
            // txtbx_red_flip_bit7_8
            // 
            this.txtbx_red_flip_bit7_8.Location = new System.Drawing.Point(352, 10);
            this.txtbx_red_flip_bit7_8.Name = "txtbx_red_flip_bit7_8";
            this.txtbx_red_flip_bit7_8.Size = new System.Drawing.Size(166, 26);
            this.txtbx_red_flip_bit7_8.TabIndex = 35;
            // 
            // txtbx_red_flip_bit7
            // 
            this.txtbx_red_flip_bit7.Location = new System.Drawing.Point(180, 10);
            this.txtbx_red_flip_bit7.Name = "txtbx_red_flip_bit7";
            this.txtbx_red_flip_bit7.Size = new System.Drawing.Size(166, 26);
            this.txtbx_red_flip_bit7.TabIndex = 34;
            // 
            // txtbx_red_flip_bit8
            // 
            this.txtbx_red_flip_bit8.Location = new System.Drawing.Point(8, 10);
            this.txtbx_red_flip_bit8.Name = "txtbx_red_flip_bit8";
            this.txtbx_red_flip_bit8.Size = new System.Drawing.Size(166, 26);
            this.txtbx_red_flip_bit8.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_original_blue);
            this.panel3.Controls.Add(this.lbl_original_green);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_original_red);
            this.panel3.Controls.Add(this.lbl_original_alpha);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtbx_original_pixel);
            this.panel3.Controls.Add(this.lbl_original_pixel_value);
            this.panel3.Controls.Add(this.txtbx_x_coord);
            this.panel3.Controls.Add(this.txtbx_original_blue);
            this.panel3.Controls.Add(this.txtbx_y_coord);
            this.panel3.Controls.Add(this.txtbx_original_green);
            this.panel3.Controls.Add(this.lbl_x_coord);
            this.panel3.Controls.Add(this.txtbx_original_red);
            this.panel3.Controls.Add(this.lbl_y_coord);
            this.panel3.Controls.Add(this.lbl_original_r);
            this.panel3.Controls.Add(this.lbl_original_pixel);
            this.panel3.Controls.Add(this.lbl_original_g);
            this.panel3.Controls.Add(this.lbl_original_b);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 741);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 74);
            this.panel3.TabIndex = 2;
            // 
            // txtbx_original_pixel
            // 
            this.txtbx_original_pixel.Location = new System.Drawing.Point(717, 36);
            this.txtbx_original_pixel.Name = "txtbx_original_pixel";
            this.txtbx_original_pixel.Size = new System.Drawing.Size(166, 26);
            this.txtbx_original_pixel.TabIndex = 26;
            // 
            // lbl_original_pixel_value
            // 
            this.lbl_original_pixel_value.AutoSize = true;
            this.lbl_original_pixel_value.Location = new System.Drawing.Point(597, 39);
            this.lbl_original_pixel_value.Name = "lbl_original_pixel_value";
            this.lbl_original_pixel_value.Size = new System.Drawing.Size(51, 20);
            this.lbl_original_pixel_value.TabIndex = 30;
            this.lbl_original_pixel_value.Text = "label2";
            // 
            // txtbx_x_coord
            // 
            this.txtbx_x_coord.Location = new System.Drawing.Point(117, 10);
            this.txtbx_x_coord.Name = "txtbx_x_coord";
            this.txtbx_x_coord.Size = new System.Drawing.Size(53, 26);
            this.txtbx_x_coord.TabIndex = 18;
            this.txtbx_x_coord.Text = "10";
            // 
            // txtbx_original_blue
            // 
            this.txtbx_original_blue.Location = new System.Drawing.Point(1233, 36);
            this.txtbx_original_blue.Name = "txtbx_original_blue";
            this.txtbx_original_blue.Size = new System.Drawing.Size(166, 26);
            this.txtbx_original_blue.TabIndex = 29;
            // 
            // txtbx_y_coord
            // 
            this.txtbx_y_coord.Location = new System.Drawing.Point(117, 39);
            this.txtbx_y_coord.Name = "txtbx_y_coord";
            this.txtbx_y_coord.Size = new System.Drawing.Size(53, 26);
            this.txtbx_y_coord.TabIndex = 19;
            this.txtbx_y_coord.Text = "20";
            // 
            // txtbx_original_green
            // 
            this.txtbx_original_green.Location = new System.Drawing.Point(1061, 36);
            this.txtbx_original_green.Name = "txtbx_original_green";
            this.txtbx_original_green.Size = new System.Drawing.Size(166, 26);
            this.txtbx_original_green.TabIndex = 28;
            // 
            // lbl_x_coord
            // 
            this.lbl_x_coord.AutoSize = true;
            this.lbl_x_coord.Location = new System.Drawing.Point(9, 13);
            this.lbl_x_coord.Name = "lbl_x_coord";
            this.lbl_x_coord.Size = new System.Drawing.Size(102, 20);
            this.lbl_x_coord.TabIndex = 20;
            this.lbl_x_coord.Text = "X Coordinate";
            // 
            // txtbx_original_red
            // 
            this.txtbx_original_red.Location = new System.Drawing.Point(889, 36);
            this.txtbx_original_red.Name = "txtbx_original_red";
            this.txtbx_original_red.Size = new System.Drawing.Size(166, 26);
            this.txtbx_original_red.TabIndex = 27;
            // 
            // lbl_y_coord
            // 
            this.lbl_y_coord.AutoSize = true;
            this.lbl_y_coord.Location = new System.Drawing.Point(9, 42);
            this.lbl_y_coord.Name = "lbl_y_coord";
            this.lbl_y_coord.Size = new System.Drawing.Size(102, 20);
            this.lbl_y_coord.TabIndex = 21;
            this.lbl_y_coord.Text = "Y Coordinate";
            // 
            // lbl_original_r
            // 
            this.lbl_original_r.AutoSize = true;
            this.lbl_original_r.Location = new System.Drawing.Point(923, 13);
            this.lbl_original_r.Name = "lbl_original_r";
            this.lbl_original_r.Size = new System.Drawing.Size(96, 20);
            this.lbl_original_r.TabIndex = 22;
            this.lbl_original_r.Text = "Original Red";
            // 
            // lbl_original_pixel
            // 
            this.lbl_original_pixel.AutoSize = true;
            this.lbl_original_pixel.Location = new System.Drawing.Point(651, 13);
            this.lbl_original_pixel.Name = "lbl_original_pixel";
            this.lbl_original_pixel.Size = new System.Drawing.Size(98, 20);
            this.lbl_original_pixel.TabIndex = 25;
            this.lbl_original_pixel.Text = "Original Pixel";
            // 
            // lbl_original_g
            // 
            this.lbl_original_g.AutoSize = true;
            this.lbl_original_g.Location = new System.Drawing.Point(1080, 13);
            this.lbl_original_g.Name = "lbl_original_g";
            this.lbl_original_g.Size = new System.Drawing.Size(111, 20);
            this.lbl_original_g.TabIndex = 23;
            this.lbl_original_g.Text = "Original Green";
            // 
            // lbl_original_b
            // 
            this.lbl_original_b.AutoSize = true;
            this.lbl_original_b.Location = new System.Drawing.Point(1261, 13);
            this.lbl_original_b.Name = "lbl_original_b";
            this.lbl_original_b.Size = new System.Drawing.Size(98, 20);
            this.lbl_original_b.TabIndex = 24;
            this.lbl_original_b.Text = "Original Blue";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(596, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "Get Original Pixel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_encode_bitmap);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(806, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 68);
            this.panel5.TabIndex = 33;
            // 
            // btn_save_modified_image
            // 
            this.btn_save_modified_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save_modified_image.Location = new System.Drawing.Point(1011, 3);
            this.btn_save_modified_image.Name = "btn_save_modified_image";
            this.btn_save_modified_image.Size = new System.Drawing.Size(194, 68);
            this.btn_save_modified_image.TabIndex = 31;
            this.btn_save_modified_image.Text = "Save Modified Image";
            this.btn_save_modified_image.UseVisualStyleBackColor = true;
            this.btn_save_modified_image.Click += new System.EventHandler(this.btn_save_modified_image_Click);
            // 
            // btn_encode_bitmap
            // 
            this.btn_encode_bitmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_encode_bitmap.Location = new System.Drawing.Point(0, 0);
            this.btn_encode_bitmap.Name = "btn_encode_bitmap";
            this.btn_encode_bitmap.Size = new System.Drawing.Size(194, 68);
            this.btn_encode_bitmap.TabIndex = 0;
            this.btn_encode_bitmap.Text = "Encode";
            this.btn_encode_bitmap.UseVisualStyleBackColor = true;
            this.btn_encode_bitmap.Click += new System.EventHandler(this.btn_encode_bitmap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "red";
            // 
            // lbl_original_alpha
            // 
            this.lbl_original_alpha.AutoSize = true;
            this.lbl_original_alpha.Location = new System.Drawing.Point(263, 16);
            this.lbl_original_alpha.Name = "lbl_original_alpha";
            this.lbl_original_alpha.Size = new System.Drawing.Size(25, 20);
            this.lbl_original_alpha.TabIndex = 33;
            this.lbl_original_alpha.Text = "....";
            // 
            // lbl_original_red
            // 
            this.lbl_original_red.AutoSize = true;
            this.lbl_original_red.Location = new System.Drawing.Point(263, 39);
            this.lbl_original_red.Name = "lbl_original_red";
            this.lbl_original_red.Size = new System.Drawing.Size(25, 20);
            this.lbl_original_red.TabIndex = 34;
            this.lbl_original_red.Text = "....";
            // 
            // lbl_original_blue
            // 
            this.lbl_original_blue.AutoSize = true;
            this.lbl_original_blue.Location = new System.Drawing.Point(489, 39);
            this.lbl_original_blue.Name = "lbl_original_blue";
            this.lbl_original_blue.Size = new System.Drawing.Size(25, 20);
            this.lbl_original_blue.TabIndex = 38;
            this.lbl_original_blue.Text = "....";
            // 
            // lbl_original_green
            // 
            this.lbl_original_green.AutoSize = true;
            this.lbl_original_green.Location = new System.Drawing.Point(489, 16);
            this.lbl_original_green.Name = "lbl_original_green";
            this.lbl_original_green.Size = new System.Drawing.Size(25, 20);
            this.lbl_original_green.TabIndex = 37;
            this.lbl_original_green.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Green";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 898);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hiding Data in a Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Original)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_result)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtbx_original_blue;
        private System.Windows.Forms.TextBox txtbx_original_green;
        private System.Windows.Forms.TextBox txtbx_original_red;
        private System.Windows.Forms.TextBox txtbx_original_pixel;
        private System.Windows.Forms.Label lbl_original_pixel;
        private System.Windows.Forms.Label lbl_original_b;
        private System.Windows.Forms.Label lbl_original_g;
        private System.Windows.Forms.Label lbl_original_r;
        private System.Windows.Forms.Label lbl_y_coord;
        private System.Windows.Forms.Label lbl_x_coord;
        private System.Windows.Forms.TextBox txtbx_y_coord;
        private System.Windows.Forms.TextBox txtbx_x_coord;
        private System.Windows.Forms.Button btn_get_original_pixel_colour;
        private System.Windows.Forms.Label lbl_original_pixel_value;
        private System.Windows.Forms.PictureBox picbx_Original;
        private System.Windows.Forms.PictureBox picbx_result;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbx_red_flip_bit7_8;
        private System.Windows.Forms.TextBox txtbx_red_flip_bit7;
        private System.Windows.Forms.TextBox txtbx_red_flip_bit8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_save_modified_image;
        private System.Windows.Forms.Button btn_encode_bitmap;
        private System.Windows.Forms.Label lbl_original_blue;
        private System.Windows.Forms.Label lbl_original_green;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_original_red;
        private System.Windows.Forms.Label lbl_original_alpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

