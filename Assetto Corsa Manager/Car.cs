using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assetto_Corsa_Manager
{
    class Car
    {
        private int rpm;
        private int gear;
        private float speed;
        private int maxRPM;
        private int maxRPMC;
        private int shift;
        public int Rpm
        {
            get { return rpm; }
            set { rpm = value; }
        }

        public int Gear
        {
            get { return gear; }
            set { gear = value; }
        }

        public float Speed
        {
            get { return (float) Math.Round(Convert.ToDouble(speed));}
            set
            {
                speed = value;
                
            }
        }
        public int MaxRPM
        {
            get { return maxRPM; }
            set { maxRPM = value; }
        }
        public int MaxRPMC
        {
            get { return maxRPMC; }
            set { maxRPMC = value; }
        }
        public int Shift
        {
            get { return shift; }
            set { shift = value; }
        }

    }
}
