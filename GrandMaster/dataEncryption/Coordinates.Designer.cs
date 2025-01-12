
namespace dataEncryption
{
    partial class Coordinates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coordinates));
            this.lbl_x_coord = new System.Windows.Forms.Label();
            this.lbl_y_coord = new System.Windows.Forms.Label();
            this.lbl_x_coordinate = new System.Windows.Forms.Label();
            this.lbl_y_coordinate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_x_coord
            // 
            this.lbl_x_coord.AutoSize = true;
            this.lbl_x_coord.Location = new System.Drawing.Point(24, 30);
            this.lbl_x_coord.Name = "lbl_x_coord";
            this.lbl_x_coord.Size = new System.Drawing.Size(102, 20);
            this.lbl_x_coord.TabIndex = 24;
            this.lbl_x_coord.Text = "X Coordinate";
            // 
            // lbl_y_coord
            // 
            this.lbl_y_coord.AutoSize = true;
            this.lbl_y_coord.Location = new System.Drawing.Point(24, 75);
            this.lbl_y_coord.Name = "lbl_y_coord";
            this.lbl_y_coord.Size = new System.Drawing.Size(102, 20);
            this.lbl_y_coord.TabIndex = 25;
            this.lbl_y_coord.Text = "Y Coordinate";
            // 
            // lbl_x_coordinate
            // 
            this.lbl_x_coordinate.AutoSize = true;
            this.lbl_x_coordinate.Location = new System.Drawing.Point(132, 30);
            this.lbl_x_coordinate.Name = "lbl_x_coordinate";
            this.lbl_x_coordinate.Size = new System.Drawing.Size(25, 20);
            this.lbl_x_coordinate.TabIndex = 26;
            this.lbl_x_coordinate.Text = "....";
            // 
            // lbl_y_coordinate
            // 
            this.lbl_y_coordinate.AutoSize = true;
            this.lbl_y_coordinate.Location = new System.Drawing.Point(132, 75);
            this.lbl_y_coordinate.Name = "lbl_y_coordinate";
            this.lbl_y_coordinate.Size = new System.Drawing.Size(25, 20);
            this.lbl_y_coordinate.TabIndex = 27;
            this.lbl_y_coordinate.Text = "....";
            // 
            // Coordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 127);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_y_coordinate);
            this.Controls.Add(this.lbl_x_coordinate);
            this.Controls.Add(this.lbl_x_coord);
            this.Controls.Add(this.lbl_y_coord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coordinates";
            this.Text = "Coordinates";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_x_coord;
        private System.Windows.Forms.Label lbl_y_coord;
        public System.Windows.Forms.Label lbl_x_coordinate;
        public System.Windows.Forms.Label lbl_y_coordinate;
    }
}