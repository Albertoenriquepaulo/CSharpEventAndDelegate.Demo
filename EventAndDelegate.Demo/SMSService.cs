using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate.Demo
{
    public class SMSService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("SMSService: Sending SMS...");
        }
    }
}
