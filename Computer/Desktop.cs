using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Desktop : Computer
    {

        private bool _hasSpeaker;
        private int _hardDriveCapacity;
        public Desktop(bool hasSpeaker)
        {
            _hasSpeaker = hasSpeaker;
        }
        public bool hasSpeaker
        {
            get
            {
                return _hasSpeaker;
            }
            set
            {
                _hasSpeaker = value;
            }
            }
        public int hardDriveCapacity
        {
            get
            {
                return _hardDriveCapacity;
            }
            set
            {
                _hardDriveCapacity = value;
            }
        }
        public void assemble()
        {
        }
        /// <summary>
        /// overload.
        /// </summary>
        Desktop()
         {
            Console.WriteLine("your desktop has been created.");
            
        }
        Desktop(bool value1, int value2);
    }///end of the class desktop.
}///end of the namespace.
