using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SamsungLedTv : LEDTV
    {
        public void SetChannel(int channetNumber)
        {
            Console.WriteLine("Configuración de canal " + channetNumber + " en Samsung Tv");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Apagado: Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Encendido: Samsung TV");
        }
    }
}
