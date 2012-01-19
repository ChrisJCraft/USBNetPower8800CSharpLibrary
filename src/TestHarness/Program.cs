namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            USBPower.USBPower.Find();
            var isPowerOn = USBPower.USBPower.IsPowerOn();
            USBPower.USBPower.SetPower(true);
        }
    }
}