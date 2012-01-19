using USBHIDDRIVER;

namespace USBPower
{
    public static class USBPower
    {
        public static USBInterface USBInterface { get; set; }

        public static void Find()
        {
            USBInterface = new USBInterface("vid_067b", "pid_2303");
            USBInterface.Connect();
        }

        public static bool IsPowerOn()
        {
            USBInterface.write(new byte[] {0xc0, 0x01, 0x0081, 0x0000, 0x0001});
            return false;
        }

        public static void SetPower(bool turnOn)
        {
            USBInterface.write(new byte[] {0x40, 0x01, 0x0001, 0xa0, 0x0000});
        }
    }
}