using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Computer
    {
        private string _model;
        private string _size;
        /// <summary>
        /// model is the name of the device.
        /// </summary>
        public string model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }

        }


        public string size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }

        public void turnOn()
        {

        }
        public void turnOff()
        {

        }
        }
}

      
       

