using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Laptop : Computer
    {

      
        private bool _hasTouchScreen;


        public bool hasTouchScreen
        {
            get
            {
                return _hasTouchScreen;
            }

            set
            {
                _hasTouchScreen = value;
            }
        }
        public Laptop(bool hasTouchScreen)
        {
        _hasTouchScreen = hasTouchScreen;
        }

    public void open()




        {

        }


            public void close()
            /// overload.
          
        {

        }
        
        
    }
}
