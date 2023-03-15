using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUssername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.SendByUssername = sendByUssername;
            this.Title = title;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImageURL, this.SendByUssername);
        }
    }
}
