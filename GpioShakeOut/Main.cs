using System;
using RaspberryPiDotNet;
using System.Threading;

namespace GpioShakeOut
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            FlashLed();
           // MaxToggleSpeed();
      	}

        private static void FlashLed()
        {
            // set up which GPIO pin we will use
            GPIOFile gpio = new GPIOFile(GPIO.GPIOPins.GPIO00);

            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(200);
                gpio.Write(Convert.ToBoolean(i % 2)); // toggle pin
                Console.WriteLine("Setting pin 17 to {0}", i % 2);
            }
        }

        private static void MaxToggleSpeed()
        {
            // set up which GPIO pin we will use
            GPIOFile gpio = new GPIOFile(GPIO.GPIOPins.GPIO04);

            bool toggle = true;
            while (true)
            {
                gpio.Write(toggle ^= true);
            }
        }
	}
}
