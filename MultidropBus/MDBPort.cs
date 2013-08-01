using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;

namespace MultidropBus
{
    public class MDBPort
    {
        SerialPort Port;

        //usemyserialPort.Parity = Parity.Mark; myserialPort.Parity = Parity.Space; for 9th bit.

        BitArray inputBuffer;

        public MDBPort(string COM)
        {
            this.Port = new SerialPort(COM, 9600); //MDB Protocol always uses a 9600 Baud Rate
        }

        public BitArray ReadByte()
        {
            BitArray inputByte = new BitArray(9);
            

    }
}
