using System;

namespace ProGraphGroup.InstagramPro.Core.Model.Stickers
{
    [Serializable]
    public sealed class SwipeUpModel
    {
        private readonly string url, text;

        public SwipeUpModel(string url, string text)
        {
            this.url = url;
            this.text = text;
        }

        public string Url => url;

        public string Text => text;
    }
}