using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUssername { get; set; }
        protected bool IsPublic { get; set; }


        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUssername = "John Doe";
        }

        // instatance construktor that has three parameters
        public Post (string title, bool isPublic, string sendByUsser)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUssername = sendByUsser;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}",this.ID,this.Title, this.SendByUssername);
        }
    }
}
