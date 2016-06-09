using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computers
{
    class Desktop : Computer
    {
        private bool _hasSpeakers;
        private int _harDriveCapacity;

        public Desktop()
        {
            Console.WriteLine("your desktop was created");
        }

        /// <summary>
        /// tells if the computer has speakers.
        /// </summary>
        public Desktop(bool hasSpeakers)
        {
            _hasSpeakers = hasSpeakers;
            Console.WriteLine("has Speakers");
        }

        public Desktop(bool value1, int value2)
        {
            _hasSpeakers = value1;
            _harDriveCapacity = value2; 
        }

        public bool hasSpeakers
        {
            get
            {
                return _hasSpeakers;
            }
            set
            {
                _hasSpeakers = value;
            }
        }
        ///<summary>
        ///Amount of hard drives that this computer has.
        /// </summary>
        public int hardDriveCapacity
        {
            get
            {
                return _harDriveCapacity;
            }
            set
            {
                _harDriveCapacity = value;
            }
        }
        public void assemble()
        {

        }
    }
}
