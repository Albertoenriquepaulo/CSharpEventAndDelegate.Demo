using System;

namespace EventAndDelegate.Demo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending email...");
        }
    }
}