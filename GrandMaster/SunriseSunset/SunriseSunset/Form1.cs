using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SunriseSunset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbobx_airport_info.SelectedIndex = 34;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("airport_data.xml", Properties.Resources.airport_data);

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

        }

        private void btn_calc_Click(object sender, System.EventArgs e)
        {
            rchtxbx_output.Text = "";

            double tsunrise, tsunset;

            string[] data = airport_data.GetAirportInfo(cmbobx_airport_info.Text);
            double lat = double.Parse(data[4]);
            double lng = double.Parse(data[6]);


            int year = SunriseSunsetDateTimePicker.Value.Year; 
            int month = SunriseSunsetDateTimePicker.Value.Month;
            int day = SunriseSunsetDateTimePicker.Value.Day;

            //Find last Sunday in March and October of year in datepicker
            DateTime marchDate = CheckDate.LastSundayOfMonth("3", year.ToString());
            DateTime octoberDate = CheckDate.LastSundayOfMonth("10", year.ToString());
            DateTime DateToCheck = SunriseSunsetDateTimePicker.Value;

            //Are we in BritishSummerTime for chosen year?
            bool BritishSummerTime = marchDate <= DateToCheck && DateToCheck <= octoberDate;


            ///////////////////////////////////////////////////////////////////////////////
            /// Standard Sunrise and Sunset
            /////////////////////////////////////////////////////////////////////////////// 
            // Parameters : year - month - day - lat (decimal) - long (decimal)
            Sunriset.SunriseSunset(year, month, day, lat, lng, out tsunrise, out tsunset);

            rchtxbx_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
            rchtxbx_output.AppendText("Standard Sunrise and Sunset\r");

            TimeSpan sunriseTime = TimeSpan.FromHours(tsunrise);
            if (BritishSummerTime) sunriseTime = sunriseTime + new TimeSpan(1, 0, 0);
            string sunriseTimeString = sunriseTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunrise = " + sunriseTimeString + "\r");

            TimeSpan sunsetTime = TimeSpan.FromHours(tsunset);
            if (BritishSummerTime) sunsetTime = sunsetTime + new TimeSpan(1, 0, 0);
            string sunsetTimeString = sunsetTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunset = " + sunsetTimeString + "\r\r");
            
            ///////////////////////////////////////////////////////////////////////////////
            /// Civil Twilight Sunrise and Sunset
            /////////////////////////////////////////////////////////////////////////////// 
            Sunriset.CivilTwilight(year, month, day, lat, lng, out tsunrise, out tsunset);

            rchtxbx_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
            rchtxbx_output.AppendText("Civil Twilight\r");

            TimeSpan CTsunriseTime = TimeSpan.FromHours(tsunrise);
            if (BritishSummerTime) CTsunriseTime = CTsunriseTime + new TimeSpan(1, 0, 0);
            string CTsunriseTimeString = CTsunriseTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunrise = " + CTsunriseTimeString + "\r");

            TimeSpan CTsunsetTime = TimeSpan.FromHours(tsunset);
            if (BritishSummerTime) CTsunsetTime = CTsunsetTime + new TimeSpan(1, 0, 0);
            string CTsunsetTimeString = CTsunsetTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunset = " + CTsunsetTimeString + "\r\r");

            ///////////////////////////////////////////////////////////////////////////////
            /// Nautical Twilight Sunrise and Sunset
            ///////////////////////////////////////////////////////////////////////////////
            Sunriset.NauticalTwilight(year, month, day, lat, lng, out tsunrise, out tsunset);

            rchtxbx_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
            rchtxbx_output.AppendText("Nautical Twilight\r");

            TimeSpan NTsunriseTime = TimeSpan.FromHours(tsunrise);
            if (BritishSummerTime) NTsunriseTime = NTsunriseTime + new TimeSpan(1, 0, 0);
            string NTsunriseTimeString = NTsunriseTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunrise = " + NTsunriseTimeString + "\r");

            TimeSpan NTsunsetTime = TimeSpan.FromHours(tsunset);
            if (BritishSummerTime) NTsunsetTime = NTsunsetTime + new TimeSpan(1, 0, 0);
            string NTsunsetTimeString = NTsunsetTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunset = " + NTsunsetTimeString + "\r\r");



            ///////////////////////////////////////////////////////////////////////////////
            /// Astronomical Twilight Sunrise and Sunset
            ///////////////////////////////////////////////////////////////////////////////
            Sunriset.AstronomicalTwilight(year, month, day, lat, lng, out tsunrise, out tsunset);

            rchtxbx_output.SelectionFont = new Font("Ariel", 8, FontStyle.Underline);
            rchtxbx_output.AppendText("Astronomical Twilight\r");

            TimeSpan ATsunriseTime = TimeSpan.FromHours(tsunrise);
            if (BritishSummerTime) ATsunriseTime = ATsunriseTime + new TimeSpan(1, 0, 0);
            string ATsunriseTimeString = ATsunriseTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunrise = " + ATsunriseTimeString + "\r");

            TimeSpan ATsunsetTime = TimeSpan.FromHours(tsunset);
            if (BritishSummerTime) ATsunsetTime = ATsunsetTime + new TimeSpan(1, 0, 0);
            string ATsunsetTimeString = ATsunsetTime.ToString(@"hh\:mm\:ss");
            rchtxbx_output.AppendText("Sunset = " + ATsunsetTimeString + "\r\r");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rchtxbx_output.Text = "";
        }
    }
}
