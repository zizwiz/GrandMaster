using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TakeOff_Landing_Distances
{
    public partial class Form1 : Form
    {
        Dictionary<string, double[]> factorLookUp = new Dictionary<string, double[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate factorLookUp dictionary
            //[take-off factor, landing factor]

            factorLookUp.Add("weight", new[] { 1.2, 1.1 });
            factorLookUp.Add("elevation", new[] { 1.1, 1.1 });
            factorLookUp.Add("temperature", new[] { 1.1, 1.1 });
            factorLookUp.Add("tailwind", new[] { 1.2, 1.2 });
            factorLookUp.Add("uphill", new[] { 1.1, 1 });
            factorLookUp.Add("downhill", new[] { 1, 1.1 });
            factorLookUp.Add("dry_grass", new[] { 1.2, 1.15 });
            factorLookUp.Add("wet_grass", new[] { 1.3, 1.35 });
            factorLookUp.Add("wet_paved", new[] { 1, 1.15 });
            factorLookUp.Add("soft_ground", new[] { 1.25, 1.25 });
            factorLookUp.Add("safety_margin", new[] { 1.33, 1.43 });

            cmbobox_runway_surface.SelectedIndex = 0;
        }


        private void btn_get_factor_Click(object sender, EventArgs e)
        {
            int index = 1; //Index 0 = take-off, 1 = landing
            if (rdobtn_take_off.Checked) index = 0;

            foreach (KeyValuePair<string, double[]> entry in factorLookUp)
            {
                double[] factor = entry.Value;
                rchtxtbx_data.AppendText(entry.Key + " = " + factor[index] + "\r");
                rchtxtbx_data.ScrollToCaret();
            }


        }


       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn_take_off.Checked)
            {
                lbl_runway_slope.Text = "Runway Uphill Slope Angle";
            }
            else
            {
                lbl_runway_slope.Text = "Runway Downhill Slope Angle";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }





        /*
          Define a sample class
           public class Person
           {
               public string Name { get; set; }
               public int Age { get; set; }
           }
           
           // Create an instance of the Person class
           Person person = new Person();
           person.Name = "John";
           person.Age = 30;
           
           // Access the properties using dot notation
           string name = person.Name;
           int age = person.Age;
         */





    }
}
