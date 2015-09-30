using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftPhone
{
    public partial class Caller : Form
    {
        Softphone oSft = new Softphone();
        public Caller()
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

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            lblCallDuration.Visible = true;
            _totalElapsedTimeDisplay.Visible = true;
            oSft.Controls["lblCustomerNo"].Text = txtCustomerNo.Text + " calling..";
            oSft.Controls["pbIncomingCall"].Visible = true;
            oSft.Controls["btnHangOff"].Visible = true;
            
            if (!_timerRunning)
            {
                // Set the start time to Now
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }
            else // If the timer is already running
            {
                _timer.Stop();
                _timerRunning = false;
            }
            btnEndCall.Visible = true;
            btnMakeCall.Visible = false;
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            _totalElapsedTimeDisplay.Text = _currentElapsedTime.ToString();
            //_currentElapsedTimeDisplay.Text = timeSinceStartTime.ToString();
        }

        private void Caller_Load(object sender, EventArgs e)
        {
            oSft.Show();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            _totalElapsedTimeDisplay.Visible = false;
            lblCallDuration.Visible = false;
            _startTime = DateTime.Now;
            
            _timer.Stop();
            _currentElapsedTime = TimeSpan.Zero;
            _totalElapsedTime = TimeSpan.Zero;
            _timerRunning = false;

            btnEndCall.Visible = false;
            btnMakeCall.Visible = true;

            oSft.Controls["lblCustomerNo"].Text = txtCustomerNo.Text + " Disconnected..";
            oSft.Controls["btnHoldCall"].Visible = false;
            oSft.Controls["btnEndCall"].Visible = false;

            oSft.Controls["lblOnCallDuration"].Visible = false;
            oSft.Controls["_totalElapsedTimeDisplay"].Visible = false;
            oSft.Controls["lblonHoldDuration"].Visible = false;
            oSft.Controls["_currentElapsedTimeDisplay"].Visible = false;

        }
    }
}
