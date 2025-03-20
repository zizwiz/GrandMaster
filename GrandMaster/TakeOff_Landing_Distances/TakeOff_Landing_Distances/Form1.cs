using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CenteredMessagebox;
using TakeOff_Landing_Distances.factors;

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

            cmbobox_runway_surface.SelectedIndex = 0; // set combobox to first entry.
            UpdateUI();
        }


        private void btn_get_factor_Click(object sender, EventArgs e)
        {
            bool flag = true;
            rchtxtbx_data.ResetText();

            int index = 1; //Index 0 = take-off, 1 = landing
            if (rdobtn_take_off.Checked) index = 0; //take-off
            
            int index2 = 0;
            string[] data = new string[11];
            double[] factors = new double[11];

            double baseWeight = double.Parse(txtbx_aircraft_base_weight.Text);
            double ladenWeight = double.Parse(txtbx_aircraft_laden_weight.Text);

            if (ladenWeight < baseWeight)
            {
                MsgBox.Show("Laden Weight must be equal or larger than Base Weight", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbx_aircraft_laden_weight.Text = txtbx_aircraft_base_weight.Text;
                flag = false;
            }

            if (flag)
            {
                rchtxtbx_data.AppendText("Weight: " + WeightFactor.WorkOutWeightFactor(
                    baseWeight, ladenWeight, index) + "\r");
                
                foreach (KeyValuePair<string, double[]> entry in factorLookUp)
                {
                    double[] factor = entry.Value;
                    rchtxtbx_data.AppendText(entry.Key + " = " + factor[index] + "\r");
                    rchtxtbx_data.ScrollToCaret();
                    data[index2] = entry.Key;
                    factors[index2] = factor[index];
                    index2++;
                }

                rchtxtbx_data.AppendText(WorkOutDistance(data, factors).ToString());
                rchtxtbx_data.ScrollToCaret();
            }
        }

        private double WorkOutDistance(string[] mydata, double[] myfactors)
        {
            double result;
            double total = 1;

            for (int i = 0; i < 11; i++)
            {
                switch (mydata[i])
                {
                    case "weight":
                        result = myfactors[i];
                        break;
                    case "elevation":
                        result = myfactors[i];
                        break;
                    case "temperature":
                        result = myfactors[i];
                        break;
                    case "tailwind":
                        result = myfactors[i];
                        break;
                    case "uphill":
                        result = myfactors[i];
                        break;
                    case "downhill":
                        result = myfactors[i];
                        break;
                    case "dry_grass":
                        result = myfactors[i];
                        break;
                    case "wet_grass":
                        result = myfactors[i];
                        break;
                    case "wet_paved":
                        result = myfactors[i];
                        break;
                    case "soft_ground":
                        result = myfactors[i];
                        break;
                    case "safety_margin":
                        result = myfactors[i];
                        break;
                    default:
                        result = 1; //Item in array is not used so multiply by 1 which makes no difference
                        break;



                }

                total *= result;
                rchtxtbx_data.AppendText("Multiplier = " + total + "\r");
            }

            return total;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            txtbx_aircraft_laden_weight.Text = txtbx_aircraft_base_weight.Text;

            if (rdobtn_take_off.Checked)
            {
                lbl_weight_type.Text = "Takeoff Weight";
                lbl_runway_slope.Text = "Runway Uphill Slope Angle";
            }
            else
            {
                lbl_weight_type.Text = "Landing Weight";
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
