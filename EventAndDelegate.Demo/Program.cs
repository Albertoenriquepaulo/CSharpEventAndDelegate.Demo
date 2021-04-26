namespace EventAndDelegate.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Demo Video" };
            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService(); //subscriber
            var smsService = new SMSService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
