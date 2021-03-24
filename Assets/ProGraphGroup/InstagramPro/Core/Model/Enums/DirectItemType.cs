using System.Collections.Generic;


namespace ProGraphGroup.InstagramPro.Core.Model.Enums
{
    public sealed class DirectItemType
    {
        public static readonly DirectItemType TEXT = new DirectItemType("TEXT", InnerEnum.TEXT, 1);
        public static readonly DirectItemType LIKE = new DirectItemType("LIKE", InnerEnum.LIKE, 2);
        public static readonly DirectItemType LINK = new DirectItemType("LINK", InnerEnum.LINK, 3);
        public static readonly DirectItemType MEDIA = new DirectItemType("MEDIA", InnerEnum.MEDIA, 4);
        public static readonly DirectItemType RAVEN_MEDIA = new DirectItemType("RAVEN_MEDIA", InnerEnum.RAVEN_MEDIA, 5);
        public static readonly DirectItemType PROFILE = new DirectItemType("PROFILE", InnerEnum.PROFILE, 6);

        public static readonly DirectItemType VIDEO_CALL_EVENT =
            new DirectItemType("VIDEO_CALL_EVENT", InnerEnum.VIDEO_CALL_EVENT, 7);

        public static readonly DirectItemType ANIMATED_MEDIA =
            new DirectItemType("ANIMATED_MEDIA", InnerEnum.ANIMATED_MEDIA, 8);

        public static readonly DirectItemType VOICE_MEDIA = new DirectItemType("VOICE_MEDIA", InnerEnum.VOICE_MEDIA, 9);

        public static readonly DirectItemType
            MEDIA_SHARE = new DirectItemType("MEDIA_SHARE", InnerEnum.MEDIA_SHARE, 10);

        public static readonly DirectItemType REEL_SHARE = new DirectItemType("REEL_SHARE", InnerEnum.REEL_SHARE, 11);
        public static readonly DirectItemType ACTION_LOG = new DirectItemType("ACTION_LOG", InnerEnum.ACTION_LOG, 12);

        public static readonly DirectItemType
            PLACEHOLDER = new DirectItemType("PLACEHOLDER", InnerEnum.PLACEHOLDER, 13);

        public static readonly DirectItemType
            STORY_SHARE = new DirectItemType("STORY_SHARE", InnerEnum.STORY_SHARE, 14);

        public static readonly DirectItemType
            CLIP = new DirectItemType("CLIP", InnerEnum.CLIP, 15); // media_share but reel

        public static readonly DirectItemType
            FELIX_SHARE = new DirectItemType("FELIX_SHARE", InnerEnum.FELIX_SHARE, 16); // media_share but igtv

        private static readonly List<DirectItemType> valueList = new List<DirectItemType>();

        public enum InnerEnum
        {
            TEXT,
            LIKE,
            LINK,
            MEDIA,
            RAVEN_MEDIA,
            PROFILE,
            VIDEO_CALL_EVENT,
            ANIMATED_MEDIA,
            VOICE_MEDIA,
            MEDIA_SHARE,
            REEL_SHARE,
            ACTION_LOG,
            PLACEHOLDER,
            STORY_SHARE,
            CLIP,
            FELIX_SHARE
        }

        public readonly InnerEnum innerEnumValue;
        private readonly string nameValue;
        private readonly int ordinalValue;
        private static int nextOrdinal = 0;

        private readonly int id;
        private static IDictionary<int, DirectItemType> map = new Dictionary<int, DirectItemType>();

        static DirectItemType()
        {
            foreach (DirectItemType type in DirectItemType.values())
            {
                map[type.id] = type;
            }

            valueList.Add(TEXT);
            valueList.Add(LIKE);
            valueList.Add(LINK);
            valueList.Add(MEDIA);
            valueList.Add(RAVEN_MEDIA);
            valueList.Add(PROFILE);
            valueList.Add(VIDEO_CALL_EVENT);
            valueList.Add(ANIMATED_MEDIA);
            valueList.Add(VOICE_MEDIA);
            valueList.Add(MEDIA_SHARE);
            valueList.Add(REEL_SHARE);
            valueList.Add(ACTION_LOG);
            valueList.Add(PLACEHOLDER);
            valueList.Add(STORY_SHARE);
            valueList.Add(CLIP);
            valueList.Add(FELIX_SHARE);
        }

        internal DirectItemType(string name, InnerEnum innerEnum, in int id)
        {
            this.id = id;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public int Id
        {
            get { return id; }
        }

        public static DirectItemType valueOf(in int id)
        {
            return map[id];
        }

        public static DirectItemType[] values()
        {
            return valueList.ToArray();
        }

        public int ordinal()
        {
            return ordinalValue;
        }

        public override string ToString()
        {
            return nameValue;
        }
    }
}