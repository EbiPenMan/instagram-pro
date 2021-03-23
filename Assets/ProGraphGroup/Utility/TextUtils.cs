using System;

namespace ProGraphGroup.Utility
{
    public sealed class TextUtils
    {
        public static bool isEmpty(String str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            if ("".Equals(str) || "null".Equals(str))
                return true;

            str = str.Trim();
            return "".Equals(str) || "null".Equals(str) || string.IsNullOrEmpty(str);
        }
    }
}