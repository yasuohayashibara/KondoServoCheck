using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KondoServoCheck
{
    public partial class Form1 : Form
    {
        int step = 0;
        int angle0 = -100;
        int dir0 = 1;
        int angle1 = 0;
        int dir1 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Open COM Port");
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step++;
            if (step >= 1000) timer1.Stop();
            angle0 += dir0;
            if ((angle0 >= 100)||(angle0 <= -100)) dir0 *= -1;
            angle1 += dir1;
            if ((angle1 >= 100)||(angle1 <= -100)) dir1 *= -1;

            byte[] com;

            com = B3MLib.B3MLib.Write(
                0,
                B3MLib.B3MLib.SERVO_DESIRED_POSITION,
                new Dictionary<byte, byte[]> {
                    {0, Extensions.Converter.ByteConverter.Int16ToByteArray(angle0*100)},
                    {1, Extensions.Converter.ByteConverter.Int16ToByteArray(angle1*100)}});
            if (B3MLib.B3MLib.Synchronize(serialPort1, com) == false)
            {
                MessageBox.Show("Error: Send Command");
            }
        }

        private void buttonServoOn_Click(object sender, EventArgs e)
        {
            byte[] com;

            com = B3MLib.B3MLib.WriteSingle(
                0,
                B3MLib.B3MLib.SERVO_TORQUE_ON,
                255,
                new byte[] {
                    (byte)B3MLib.B3MLib.Options.RunNormal |
                    (byte)B3MLib.B3MLib.Options.ControlPosition});
            if (B3MLib.B3MLib.Synchronize(serialPort1, com) == false){
                MessageBox.Show("Error: Send Command");
            }
        }

        private void buttonServoOff_Click(object sender, EventArgs e)
        {
            byte[] com;

            com = B3MLib.B3MLib.WriteSingle(
                0,
                B3MLib.B3MLib.SERVO_TORQUE_ON,
                255,
                new byte[] {
                    (byte)B3MLib.B3MLib.Options.RunFree |
                    (byte)B3MLib.B3MLib.Options.ControlPosition});
            if (B3MLib.B3MLib.Synchronize(serialPort1, com) == false)
            {
                MessageBox.Show("Error: Send Command");
            }
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            byte[] com;

            com = B3MLib.B3MLib.Write(
                0,
                B3MLib.B3MLib.SERVO_DESIRED_POSITION,
                new Dictionary<byte, byte[]> {
                    {0, Extensions.Converter.ByteConverter.Int16ToByteArray(trackBarAngle.Value)},
                    {1, Extensions.Converter.ByteConverter.Int16ToByteArray(trackBarAngle.Value)}});
            if (B3MLib.B3MLib.Synchronize(serialPort1, com) == false)
            {
                MessageBox.Show("Error: Send Command");
            }
        }

        private void buttonMotion_Click(object sender, EventArgs e)
        {
            step = 0;
            timer1.Start();
        }
    }
}
