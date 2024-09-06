using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using GPS_App.Properties;
using GPS_App.utils;


namespace GPSInfo
{
    #region Public Enumerations

    public enum DataMode
    {
        Text,
        Hex
    }

    public enum LogMsgType
    {
        Incoming,
        Outgoing,
        Normal,
        Warning,
        Error
    };

    #endregion

    public partial class Form1 : Form
    {
        #region Private Variables

        // Various colors for logging info
        private Color[] LogMsgTypeColor = {Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red};
        private Settings settings = Settings.Default;

        #endregion

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();
            btn_send.Enabled = false;

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_output.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // SendData("$PSRF103,00,01,00,01*25\r\n");

            // SendData("$PSRF112,140,6,1*3B\r\n");

            // SendData(ConvertASCIItoDec("$PSRF100,1,19200,8,1,0*38"));

            SendData(Translators.ConvertASCIItoDec("$PSRF103,00,01,10,01*24"));
        }

        private void btn_add_Checksum_Click(object sender, EventArgs e)
        {
            rchtxbx_output.AppendText(Checksums.Add_nmea0183_checksum(txtbx_data_without_checksum.Text) + "\r");
        }

        private void btn_check_Checksum_Click(object sender, EventArgs e)
        {
            rchtxbx_output.AppendText(Checksums.Check_nmea0183_checksum(txtbx_data_with_checksum.Text) + "\r");
        }

        private void btn_convertToDecimal_Click(object sender, EventArgs e)
        {
            string GPSData = "";
            foreach (var character in txtbx_data_with_checksum.Text)
            {
                GPSData += Convert.ToUInt16(character);
            }

            rchtxbx_output.AppendText(GPSData + "1310");
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
