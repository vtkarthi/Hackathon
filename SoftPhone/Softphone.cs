using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftPhone
{
    public partial class Softphone : Form
    {
        Alert oAlrt = new Alert();  
        public Softphone()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        private Timer _timer;
        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;
        private bool _timerRunning = false;
        private bool _isHoldOn = false;

        private void lbtnMinimize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void Softphone_Load(object sender, EventArgs e)
        {
                      
        }

        private void btnHangOff_Click(object sender, EventArgs e)
        {
            lblCustomerNo.Text = lblCustomerNo.Text.Split(" ".ToCharArray())[0] + " connected!";
            lblOnCallDuration.Visible = true;
            _totalElapsedTimeDisplay.Visible = true;
            btnHangOff.Visible = false;
            btnHoldCall.Visible = true;
            btnEndCall.Visible = true;
            if (!_timerRunning)
            {
                _startTime = DateTime.Now;
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }
            else 
            {
                _timer.Stop();
                _timerRunning = false;
            }


            using (SqlConnection connection = new SqlConnection("Data Source=SCSBWIN-398215;Initial Catalog=CallEvents;Persist Security Info=True;User ID=sa;Password=Admin123;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO AgentRealtimeInfo (AgentId, CustomerBTN, AgentStatus, StatusTimestamp,Status) VALUES (@AgentId, @CustomerBTN, @AgentStatus, @StatusTimestamp,@Status)";

                command.Parameters.AddWithValue("@AgentId", "3240553");
                command.Parameters.AddWithValue("@CustomerBTN", lblCustomerNo.Text.Split(" ".ToCharArray())[0].Trim());
                command.Parameters.AddWithValue("@AgentStatus", "ON CALL");
                command.Parameters.AddWithValue("@StatusTimestamp", DateTime.Now);
                command.Parameters.AddWithValue("@Status", true);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var timeSinceStartTime = DateTime.Now - _startTime;
                timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                                  timeSinceStartTime.Minutes,
                                                  timeSinceStartTime.Seconds);

                _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

                _totalElapsedTimeDisplay.Text = _currentElapsedTime.ToString();
                _currentElapsedTimeDisplay.Text = timeSinceStartTime.ToString();
                if (_isHoldOn)
                {
                    if (oAlrt == null)
                    {
                        oAlrt = new Alert();
                    }
                    if (timeSinceStartTime.Seconds == 10)
                    {
                        oAlrt.BackColor = Color.Yellow;
                        oAlrt.Controls["txtAlertMessage"].Text = "Call on hold duration exceeded 10 seconds. Please swap the call to respond customer and extend the call hold !";
                        oAlrt.Controls["txtAlertMessage"].BackColor = Color.Yellow;
                        oAlrt.Show();
                    }
                    else if (timeSinceStartTime.Seconds == 20)
                    {
                        oAlrt.BackColor = Color.Orange;
                        oAlrt.Controls["txtAlertMessage"].Text = "Call on hold duration exceeded 20 seconds. Please swap the call to respond customer and extend the call hold !";
                        oAlrt.Controls["txtAlertMessage"].BackColor = Color.Orange;
                        oAlrt.Show();
                    }
                    else if (timeSinceStartTime.Seconds == 30)
                    {
                        oAlrt.BackColor = Color.Red;
                        oAlrt.Controls["txtAlertMessage"].Text = "Call on hold duration exceeded 30 seconds. Please swap the call to respond customer and extend the call hold !";
                        oAlrt.Controls["txtAlertMessage"].BackColor = Color.Red;
                        oAlrt.Show();
                    }
                    //oAlrt = null;
                }
            }
            catch (Exception ex)
            { 
            }
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            lblCustomerNo.Text = string.Empty;
            btnHangOff.Visible = false;
            pbIncomingCall.Visible = false;
            btnHoldCall.Visible = false;
            btnEndCall.Visible = false;           
        }

        private void btnHoldCall_Click(object sender, EventArgs e)
        {
            _isHoldOn = true;
            lblonHoldDuration.Visible = true;
            _currentElapsedTimeDisplay.Visible = true;
            _startTime = DateTime.Now;
            _totalElapsedTime = _currentElapsedTime;

            _timer.Start();
            _timerRunning = true;


            using (SqlConnection connection = new SqlConnection("Data Source=SCSBWIN-398215;Initial Catalog=CallEvents;Persist Security Info=True;User ID=sa;Password=Admin123;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            using (SqlCommand command = connection.CreateCommand())
            {

                command.CommandText = "UPDATE AgentRealtimeInfo SET AgentStatus = @AgentStatus, StatusTimestamp = @StatusTimestamp Where CustomerBTN = @CustomerBTN and AgentId = @AgentId";
                command.Parameters.AddWithValue("@AgentId", "3240553");
                command.Parameters.AddWithValue("@CustomerBTN", lblCustomerNo.Text.Split(" ".ToCharArray())[0].Trim());
                command.Parameters.AddWithValue("@AgentStatus", "ON HOLD");
                command.Parameters.AddWithValue("@StatusTimestamp", DateTime.Now);               

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
