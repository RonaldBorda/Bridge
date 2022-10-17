using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyLedTv : LEDTV
    {
        public void SetChannel(int channetNumber)
        {
            Console.WriteLine("Configuración de canal " + channetNumber + " en Sony Tv");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Apagado: Sony TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Encendido: Sony TV");
        }
    }
}
