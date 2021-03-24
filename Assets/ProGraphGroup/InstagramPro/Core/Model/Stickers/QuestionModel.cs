using System;

namespace ProGraphGroup.InstagramPro.Core.Model.Stickers
{
    [Serializable]
    public sealed class QuestionModel
    {
        private readonly string id, question;

        public QuestionModel(string id, string question)
        {
            this.id = id;
            this.question = question;
        }

        public string Id => id;

        public string Question => question;
    }
}