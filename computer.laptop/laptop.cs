using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computers
{
    class laptop : Computer
    {
        private bool _hasTouchScreen;

        ///<summry>
        ///if the laptop has touch screen.
        ///</summry>
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
        }// end of hasTouchScreen

        ///<summary>
        /// close the laptop
        ///</summary>
        public void close()
        {
        }
    }// final de la class laptp
}//final del namespace computers
