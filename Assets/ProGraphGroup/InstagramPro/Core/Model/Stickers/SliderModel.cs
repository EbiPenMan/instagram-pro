using System;

namespace ProGraphGroup.InstagramPro.Core.Model.Stickers
{
    [Serializable]
    public sealed class SliderModel
    {
        private readonly int voteCount;
        private readonly double average;
        private double myChoice;
        private readonly bool canVote;
        private readonly string id, question, emoji;

        public SliderModel(string id, string question, string emoji, bool canVote, double average, int voteCount,
            double myChoice)
        {
            this.id = id;
            this.question = question;
            this.emoji = emoji;
            this.canVote = canVote;
            this.average = average;
            this.voteCount = voteCount;
            this.myChoice = myChoice;
        }

        public int VoteCount => voteCount;

        public double Average => average;

        public double MyChoice
        {
            get => myChoice;
            set => myChoice = value;
        }

        public bool CanVote => canVote;

        public string Id => id;

        public string Question => question;

        public string Emoji => emoji;
    }
}