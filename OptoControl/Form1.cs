using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace OptoControl
{
    public partial class OptoControl : Form
    {
        //private SerialPort MySerialPort = new SerialPort("COM3",9600);

        private bool enabled = false;
        private bool direction = false;


        public OptoControl()
        {
            InitializeComponent();
        }

        private void MyButtonSend_Click(object sender, EventArgs e)
        {

        }

        private void OptoControl_Load(object sender, EventArgs e)
        {
            MySerialPort.Open();
            MySerialPort.WriteLine("125 0 0");
            MySerialPort.Close();
            MyLabelInterval.Text = MyTrackBarInterval.Value.ToString();

        }
        
        private void Optocontrol_Close(object sender, EventArgs e)
        {
            enabled = false;
            MySerialWriteLine();

        }

        private void MyButtonEnable_Click(object sender, EventArgs e)
        {

            enabled = !enabled;
            if (enabled)
            {
                MyButtonEnable.Text = "Disable";
            }
            else
            {
                MyButtonEnable.Text = "Enable";
            }
            MySerialWriteLine();


        }

        public void MySerialWriteLine()
        {
            MySerialPort.Open();
            MySerialPort.WriteLine(MyTrackBarInterval.Value.ToString() + " " + Convert.ToInt16(direction).ToString()+ " " + Convert.ToInt16(enabled).ToString());
            MySerialPort.Close();
        }

        private void MyButtonDirection_Click(object sender, EventArgs e)
        {
            direction = !direction;
            if (direction)
            {
                MyButtonDirection.Text = "Turn Left";
            }
            else
            {
                MyButtonDirection.Text = "Turn Right";
            }
            MySerialWriteLine();

        }

        private void MyTrackBarInterval_Scroll(object sender, EventArgs e)
        {
            //MyButtonSend.Text = MyTrackBarInterval.Value.ToString();
            MySerialWriteLine();
            MyLabelInterval.Text = MyTrackBarInterval.Value.ToString();
        }
    }
}
