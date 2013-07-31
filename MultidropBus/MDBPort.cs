using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MultidropBus
{
    public class MDBPort
    {
        SerialPort Port;

        //usemyserialPort.Parity = Parity.Mark; myserialPort.Parity = Parity.Space; for 9th bit.


        public MDBPort(string COM)
        {
            this.Port = new SerialPort(COM, 9600); //MDB Protocol always uses a 9600 Baud Rate
        }

    }
}
