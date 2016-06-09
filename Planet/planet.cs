using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Planet

    {
        private string _name;
        private string _temperature;
        private string _density;
        private string _gravity;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public string temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;

            }
        }


        public string density
        {
            get
            {
                return _density;
            }
            set
            {
                _density = value;
            }
        }

        public string gravity
        {
            get
            {
                return _gravity;
            }
            set
            {
                _gravity = value;

            }
        }
    }
}