using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost:Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int curreDuration = 0;
        Timer timer;

        // properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUssername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.SendByUssername = sendByUssername;
            this.Title = title;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(object o)
        {
            if (curreDuration < Length)
            {
                curreDuration++;
                Console.WriteLine("Video at {0}s", curreDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", curreDuration);
                curreDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUssername);
        }



    }
}
