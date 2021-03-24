using System.Collections.Generic;

namespace ProGraphGroup.InstagramPro.Core.Model.Enums
{
    public sealed class UserInboxDirection
    {
        public static readonly UserInboxDirection OLDER = new UserInboxDirection("OLDER", InnerEnum.OLDER, "older");
        public static readonly UserInboxDirection NEWER = new UserInboxDirection("NEWER", InnerEnum.NEWER, "newer");

        private static readonly List<UserInboxDirection> valueList = new List<UserInboxDirection>();

        static UserInboxDirection()
        {
            valueList.Add(OLDER);
            valueList.Add(NEWER);
        }

        public enum InnerEnum
        {
            OLDER,
            NEWER
        }

        public readonly InnerEnum innerEnumValue;
        private readonly string nameValue;
        private readonly int ordinalValue;
        private static int nextOrdinal = 0;

        private readonly string value;

        internal UserInboxDirection(string name, InnerEnum innerEnum, in string value)
        {
            this.value = value;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public string Value
        {
            get
            {
                return value;
            }
        }

        public static UserInboxDirection[] values()
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

        public static UserInboxDirection valueOf(string name)
        {
            foreach (UserInboxDirection enumInstance in UserInboxDirection.valueList)
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