using System;
using System.Windows.Forms;

namespace FormTextUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                txtbx_2.Select();
            }
        }

        private void btn_speed_calculation_Click(object sender, EventArgs e)
        {
            /*
             * In aviation, the ground speed formula is as follows: vg = √(va2 + vw2 - (2vavw cos(δ - ω + ⍺))
               
               Where, vg – Ground speed 
               va – True airspeed 
               vw – Wind speed
               δ – Course – the desired flight path, measured clockwise from the North
               ω – Wind direction
               ⍺ – Wind correction angle
               The above equation is a simple vector addition of the true airspeed and wind speed of the aircraft. 
                It can be calculated using the law of cosines formula.
             
             * wind correction angle, ⍺ as: Note this is inverse of Sin which is Asin
             * All Degrees need to be converted into Radians
               
               𝛼=sin−1[(vw/va)*sin(ω−δ)]

               double mycalcInRadians = Math.Asin([(vw/va)*sin(DegreeToRadian(ω−δ))]);
               double mycalcInDegrees = Math.Asin([(vw/va)*sin(DegreeToRadian(ω−δ))]) * 180 / Math.PI;
             
             * The heading is the direction in which a pilot directs the nose of the aircraft to avoid any
             * wind-induced deviation from its course. The sum of the course and the wind correction angle is as
             * follows: ѱ = δ + ⍺
             */

            rchtxtbx_speed_output.Text = "";

            double TrueAirspeed = Double.Parse(txtbx_speed_true_airspeed.Text);
            double WindSpeed = Double.Parse(txtbx_speed_wind_speed.Text);
            double Course = Double.Parse(txtbx_speed_course.Text);
            double WindDirection = Double.Parse(txtbx_speed_wind_direction.Text);

            //Get the wind correction but here we need to convert degrees to radian do the inverse
            //SIN then convert radians to Degrees
            double WindCorrection = Math.Round(Math.Asin((WindSpeed / TrueAirspeed) *
                                              Math.Sin(DegreeToRadian(WindDirection - Course))) *
                                                    180 / Math.PI, 0);

            //Convert all Degrees into Radians
            double GroundSpeed = Math.Round(Math.Sqrt((Math.Pow(TrueAirspeed, 2.0) + Math.Pow(WindSpeed, 2.0)) -
                                                      (2 * TrueAirspeed * WindSpeed * Math.Cos(DegreeToRadian(Course - WindDirection + WindCorrection)))), 0);

            rchtxtbx_speed_output.AppendText("Wind Correction = " + WindCorrection + "°\r");
            rchtxtbx_speed_output.AppendText("Heading = " + (Course + WindCorrection) + "°\r");
            rchtxtbx_speed_output.AppendText("Ground Speed = " + GroundSpeed + "kts\r");

            //FlightTime = Distance in nautical miles / speed in knots
            Double FlightTime = Double.Parse(txtbx_speed_distance.Text) / GroundSpeed;
            rchtxtbx_speed_output.AppendText("\rFlight Time = " + TimeSpan.FromHours(FlightTime).ToString("h\\:mm\\:ss") + "\r");

            //Fuel Consumption = Flight Time * Hourly consumption rate
            Double JourneyFuelLoad = Math.Ceiling(FlightTime * Double.Parse(txtbx_speed_fuel_consumption.Text));
            rchtxtbx_speed_output.AppendText("\rMin journey fuel consumption = " + JourneyFuelLoad + "ℓ");

            Double FuelLoad = JourneyFuelLoad + Double.Parse(txtbx_min_landing_fuel.Text);
            rchtxtbx_speed_output.AppendText("\rMin takeoff fuel load = " + FuelLoad + "ℓ");

            rchtxtbx_speed_output.AppendText("\rFuel weight at takeoff= " + FuelLoad * Double.Parse(txtbx_speed_fuel_specific_gravity.Text) + "kg");


        }

        //Some helper functions
        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}
