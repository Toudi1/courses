using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class VideoPost:Post
    {
        public string VideoURL { get; set; }
        public TimeSpan Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUssername, string videoURL, TimeSpan length, bool isPublic)
        {
            this.ID = GetNextID();
            this.SendByUssername = sendByUssername;
            this.Title = title;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUssername);
        }
    }
}
