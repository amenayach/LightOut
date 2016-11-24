using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LightOut.Managers
{
    public class BrightnessManager
    {

        private static object _lock = new object();

        public void SetBrightness(byte targetBrightness)
        {

            new Thread(() =>
            {

                ManagementScope scope = new ManagementScope("root\\WMI");
                SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
                {
                    using (ManagementObjectCollection objectCollection = searcher.Get())
                    {
                        foreach (ManagementObject mObj in objectCollection)
                        {
                            mObj.InvokeMethod("WmiSetBrightness",
                                new Object[] { UInt32.MaxValue, targetBrightness });
                            break;
                        }
                    }
                }

            }).Start();
            
        }

        public byte GetBrightness()
        {
            ManagementScope scope = new ManagementScope("root\\WMI");
            SelectQuery query = new SelectQuery("WmiMonitorBrightness");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
            {
                using (ManagementObjectCollection objectCollection = searcher.Get())
                {
                    foreach (ManagementObject mObj in objectCollection)
                    {
                        foreach (var item in mObj.Properties)
                        {
                            if (item.Name == "CurrentBrightness")
                            {
                                return (byte)item.Value;
                            }
                        }

                    }

                }
            }

            return 0;
        }

    }
}
