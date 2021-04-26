using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EventAndDelegate.Demo
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            Console.WriteLine("Video encoded :)");
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            //if (VideoEncoded != null)
            //{
            //    VideoEncoded(this, EventArgs.Empty);
            //}
            // Code lines above are the same that the line below
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
