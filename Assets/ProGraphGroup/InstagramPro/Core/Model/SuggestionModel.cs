using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class SuggestionModel : IComparable<SuggestionModel>
    {
        private readonly int position;
        private readonly bool isVerified;
        private readonly string username, name, profilePic;
        private readonly SuggestionType suggestionType;

        public SuggestionModel(in bool isVerified, in string username, in string name, in string profilePic,
            in SuggestionType suggestionType, in int position)
        {
            this.isVerified = isVerified;
            this.username = username;
            this.name = name;
            this.profilePic = profilePic;
            this.suggestionType = suggestionType;
            this.position = position;
        }

        public bool Verified
        {
            get { return isVerified; }
        }

        public string Username
        {
            get { return username; }
        }

        public string Name
        {
            get { return name; }
        }

        public string ProfilePic
        {
            get { return profilePic; }
        }

        public SuggestionType SuggestionType
        {
            get { return suggestionType; }
        }

        public int Position
        {
            get { return position; }
        }


        public int CompareTo(SuggestionModel other)
        {
            return Position.CompareTo(other.Position);
        }
    }
}