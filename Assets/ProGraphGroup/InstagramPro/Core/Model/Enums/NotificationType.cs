using System.Collections.Generic;

namespace ProGraphGroup.InstagramPro.Core.Model.Enums
{
    public sealed class NotificationType
    {
        // web
        public static readonly NotificationType LIKE =
            new NotificationType("LIKE", InnerEnum.LIKE, "GraphLikeAggregatedStory");

        public static readonly NotificationType FOLLOW =
            new NotificationType("FOLLOW", InnerEnum.FOLLOW, "GraphFollowAggregatedStory");

        public static readonly NotificationType COMMENT =
            new NotificationType("COMMENT", InnerEnum.COMMENT, "GraphCommentMediaStory");

        public static readonly NotificationType MENTION =
            new NotificationType("MENTION", InnerEnum.MENTION, "GraphMentionStory");

        public static readonly NotificationType TAGGED =
            new NotificationType("TAGGED", InnerEnum.TAGGED, "GraphUserTaggedStory");

        // app story_type
        public static readonly NotificationType COMMENT_LIKE =
            new NotificationType("COMMENT_LIKE", InnerEnum.COMMENT_LIKE, "13");

        public static readonly NotificationType TAGGED_COMMENT =
            new NotificationType("TAGGED_COMMENT", InnerEnum.TAGGED_COMMENT, "14");

        public static readonly NotificationType RESPONDED_STORY =
            new NotificationType("RESPONDED_STORY", InnerEnum.RESPONDED_STORY, "213");

        // efr - random value
        public static readonly NotificationType REQUEST = new NotificationType("REQUEST", InnerEnum.REQUEST, "REQUEST");

        // ayml - random value
        public static readonly NotificationType AYML = new NotificationType("AYML", InnerEnum.AYML, "AYML");

        private static readonly List<NotificationType> valueList = new List<NotificationType>();

        public enum InnerEnum
        {
            LIKE,
            FOLLOW,
            COMMENT,
            MENTION,
            TAGGED,
            COMMENT_LIKE,
            TAGGED_COMMENT,
            RESPONDED_STORY,
            REQUEST,
            AYML
        }

        public readonly InnerEnum innerEnumValue;
        private readonly string nameValue;
        private readonly int ordinalValue;
        private static int nextOrdinal = 0;

        private readonly string itemType;
        private static readonly IDictionary<string, NotificationType> map = new Dictionary<string, NotificationType>();

        static NotificationType()
        {
            foreach (NotificationType type in NotificationType.values())
            {
                map[type.itemType] = type;
            }

            valueList.Add(LIKE);
            valueList.Add(FOLLOW);
            valueList.Add(COMMENT);
            valueList.Add(MENTION);
            valueList.Add(TAGGED);
            valueList.Add(COMMENT_LIKE);
            valueList.Add(TAGGED_COMMENT);
            valueList.Add(RESPONDED_STORY);
            valueList.Add(REQUEST);
            valueList.Add(AYML);
        }

        internal NotificationType(string name, InnerEnum innerEnum, in string itemType)
        {
            this.itemType = itemType;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public string ItemType
        {
            get { return itemType; }
        }

        public static NotificationType valueOfType(in string itemType)
        {
            return map[itemType];
        }

        public static NotificationType[] values()
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

        public static NotificationType valueOf(string name)
        {
            foreach (NotificationType enumInstance in NotificationType.valueList)
            {
                if (enumInstance.nameValue == name)
                {
                    return enumInstance;
                }
            }

            throw new System.ArgumentException(name);
        }
    }
}