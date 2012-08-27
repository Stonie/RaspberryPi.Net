using System;
using RaspberryPiDotNet;
using System.Threading;

namespace GpioShakeOut
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			GPIOFile gpio = new GPIOFile(GPIO.GPIOPins.GPIO00);
            
			for (int i = 0; i < 10; i++) //flash pin 17, 5 times on & off (1 second each)
            {
				Thread.Sleep(500);
            	gpio.Write(Convert.ToBoolean(i%2));
				
				Console.WriteLine("Setting pin 17 to {0}",i%2);
            }
      	}
	}
}
