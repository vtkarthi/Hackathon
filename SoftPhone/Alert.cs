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
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }



        void timer_Tick(object sender, EventArgs e)
        {
            if (lblAlert.ForeColor == Color.Black)
                lblAlert.ForeColor = Color.Brown;
            else
                lblAlert.ForeColor = Color.Black;
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Enabled = false;

            timer.Start();

            //if (messagesNum > oldMessagesNum)
                timer.Tick += new EventHandler(timer_Tick);
            //else
                //timer.Tick -= timer_Tick;
        }

    }
}
