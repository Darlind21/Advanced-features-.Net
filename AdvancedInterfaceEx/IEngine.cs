using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedInterfaceEx
{
    internal interface IEngine 
    {
        int Power { get; set; }
        int RPM { get; set; }   
        int Cylinders { get; set; }

        int StartingSpeed(int gear); //eshte metod por nuk shkruhet public sepse supozohet t nenkuptohet nqs eshte interface
    }
}
