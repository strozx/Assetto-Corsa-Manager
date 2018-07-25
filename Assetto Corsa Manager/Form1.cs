﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AssettoCorsaSharedMemory;

namespace Assetto_Corsa_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPorts();
            AssettoCorsa ac = new AssettoCorsa();
            ac.PhysicsInterval = 10;
            ac.PhysicsUpdated += ac_StaticInfoUpdated;

            ac.StaticInfoInterval = 5000; // Get StaticInfo updates ever 5 seconds
            ac.StaticInfoUpdated += ac_StaticInfoUpdated; // Add event listener for StaticInfo
            ac.Start();

            timer1.Enabled = true;
        }

        ArduinoCOM AC = new ArduinoCOM();

        void LoadPorts()
        {
            AC.getAvailableComPorts();

            foreach (string port in AC.ports)
            {
                comboPorts.Items.Add(port);
                Console.WriteLine(port);
                if (AC.ports[0] != null)
                {
                    comboPorts.SelectedItem = AC.ports[0];
                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (connected)
            {
                AC.disconnectFromArduino();
                button1.Text = "Connect";
                connected = false;
            }
            else
            {
                AC.connectToArduino(comboPorts.SelectedItem.ToString());
                button1.Text = "Disconnect";
                connected = true;
            }
           
        }

        private static int maxRpm;
        static void ac_StaticInfoUpdated(object sender, StaticInfoEventArgs e)
        {
            maxRpm = (int) Math.Round(Convert.ToDouble(e.StaticInfo.MaxRpm*0.02));
            ca.MaxRPMC = maxRpm;
            ca.MaxRPM = e.StaticInfo.MaxRpm;
            
        }

  
        static Car ca=new Car();
        static void ac_StaticInfoUpdated(object sender, PhysicsEventArgs e)
        {
            ca.Fuel = e.Physics.Fuel;
            ca.Rpm = e.Physics.Rpms;
            ca.Gear = e.Physics.Gear-1;
            ca.Speed = e.Physics.SpeedKmh;
            ca.BB = e.Physics.BrakeBias*100;
            // Console.WriteLine(e.Physics.Gear);
        }

        private void send()
        {
            if (connected)
            {
                AC.send("RPM: " + ca.Rpm.ToString()+"$"+ca.Gear.ToString()+"$"+ca.Speed.ToString()+"km/h$"+ca.Shift+"$F:"+ca.Fuel+ "L$" + ca.BB+"&");
            }
            

        }
        private bool connected = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ca.MaxRPM - ca.MaxRPMC < ca.Rpm)
            {
                ca.Shift = 20;

            }
            else
            {
                ca.Shift = 10;
            }

            float shiftLight = ca.MaxRPM / 16;
            crpm.Text = ca.Rpm.ToString();
            gear.Text = ca.Gear.ToString();
            speed.Text = ca.Speed.ToString();
            fuel.Text = ca.Fuel.ToString();
            send();
        }
    }
}

