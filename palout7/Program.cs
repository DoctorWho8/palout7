using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace palout7
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort i0 = new OutputPort(Pins.GPIO_PIN_D2, false);
            OutputPort i1 = new OutputPort(Pins.GPIO_PIN_D3, false);
            OutputPort i2 = new OutputPort(Pins.GPIO_PIN_D4, false);
            OutputPort i3 = new OutputPort(Pins.GPIO_PIN_D5, false);
            OutputPort i4 = new OutputPort(Pins.GPIO_PIN_D6, false);
         //   OutputPort i5 = new OutputPort(Pins.GPIO_PIN_D7, false);
        //  OutputPort i6 = new OutputPort(Pins.GPIO_PIN_D8, false);
        //   OutputPort i7 = new OutputPort(Pins.GPIO_PIN_D9, false);
        //    OutputPort i8 = new OutputPort(Pins.GPIO_PIN_D10, false);
        //    OutputPort i9 = new OutputPort(Pins.GPIO_PIN_D11, false);
        //    OutputPort i10 = new OutputPort(Pins.GPIO_PIN_D12, false);
        //    OutputPort i11 = new OutputPort(Pins.GPIO_PIN_D13, false);
            while (true)
            {
                i0.Write(true);
                i1.Write(true);
                i2.Write(true);
                Thread.Sleep(220);   
                i0.Write(false);
                i1.Write(false);
                i2.Write(false);
                i3.Write(false);
                i4.Write(false);
           //     i5.Write(false);
           //     i6.Write(false);
           //     i7.Write(false);
           //     i8.Write(false);
           //     i9.Write(false);
           //     i10.Write(false);
           //     i11.Write(false);
            Thread.Sleep(375);
                i0.Write(true);
                i1.Write(true);
                i2.Write(true);
                i3.Write(true);
                i4.Write(true);
           //     i5.Write(true);
           //     i6.Write(true);
           //     i7.Write(true);
           //     i8.Write(true);
           //     i9.Write(true);
           //     i10.Write(true);
           //     i11.Write(true);
             Thread.Sleep(375);
                 i0.Write(true);
                 i1.Write(true);
                 i2.Write(true);
             Thread.Sleep(220); 
                i0.Write(false);
                i1.Write(false);
                i2.Write(false);
                i3.Write(false);
                i4.Write(false);
           //     i5.Write(false);
           //     i6.Write(false);
           //     i7.Write(false);
           //     i8.Write(false);
           //     i9.Write(false);
           //     i10.Write(false);
           //     i11.Write(false);
             Thread.Sleep(3750);
            }
            }    
    }
}


        

    

