using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class IntentModel
    {
        private readonly IntentModelType type;
        private readonly string text;

        public IntentModel(in IntentModelType type, in string text)
        {
            this.type = type;
            this.text = text;
        }

        public IntentModelType Type
        {
            get
            {
                return type;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }
    }
}