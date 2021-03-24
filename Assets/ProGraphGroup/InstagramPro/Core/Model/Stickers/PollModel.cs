using System;

namespace ProGraphGroup.InstagramPro.Core.Model.Stickers
{
    [Serializable]
    public sealed class PollModel
    {
        private int leftcount, rightcount, mychoice;
        private readonly string id, question, leftchoice, rightchoice;


        public PollModel(int leftcount, int rightcount, int mychoice, string id, string question, string leftchoice, string rightchoice)
        {
            this.leftcount = leftcount;
            this.rightcount = rightcount;
            this.mychoice = mychoice;
            this.id = id;
            this.question = question;
            this.leftchoice = leftchoice;
            this.rightchoice = rightchoice;
        }

        public int Leftcount
        {
            get => leftcount;
            set => leftcount = value;
        }

        public int Rightcount
        {
            get => rightcount;
            set => rightcount = value;
        }

        public int Mychoice
        {
            get => mychoice;
            set => mychoice = value;
        }

        public string Id => id;

        public string Question => question;

        public string Leftchoice => leftchoice;

        public string Rightchoice => rightchoice;
    }
}