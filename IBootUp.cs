using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Thompson_Lillian
{
    interface IBootUp
    {
        public bool IsOn {get; set;}

        public void PowerOnOff();
    }
}
