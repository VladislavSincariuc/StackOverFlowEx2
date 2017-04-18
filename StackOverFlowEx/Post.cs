using System;

namespace StackOverFlowEx
{
    class Post
    {
        public readonly string Title;
        public readonly string Description;
        public readonly  DateTime ItWasCreatedOn;
        public int Vote { get; set; }

       
        public Post(string title , string description)
        {
            this.Description = description;
            this.Title = title;
            this.ItWasCreatedOn = DateTime.Now;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
           if (Vote == 0)
             throw new InvalidOperationException("Can't reduce votes, when noone are");
            Vote--;
        }

    }
}