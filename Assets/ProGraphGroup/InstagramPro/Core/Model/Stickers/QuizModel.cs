using System;

namespace ProGraphGroup.InstagramPro.Core.Model.Stickers
{
    [Serializable]
    public sealed class QuizModel
    {
        private readonly string id, question;
        private readonly string[] choices;
        private long[] counts;
        private int mychoice;

        public QuizModel( string id,  string question,  string[] choices,  long[] counts,  int mychoice)
        {
            this.id = id; // only the poll id
            this.question = question;
            this.choices = choices;
            this.counts = counts;
            this.mychoice = mychoice;
        }

        public string Id => id;

        public string Question => question;

        public string[] Choices => choices;

        public long[] Counts
        {
            get => counts;
            set => counts = value;
        }

        public int Mychoice
        {
            get => mychoice;
            set => mychoice = value;
        }
    }
}