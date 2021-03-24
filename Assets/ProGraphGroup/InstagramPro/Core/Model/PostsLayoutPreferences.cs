using Newtonsoft.Json;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class PostsLayoutPreferences
    {
        private readonly PostsLayoutType type;
        private readonly int colCount;
        private readonly bool isAvatarVisible;
        private readonly bool isNameVisible;
        private readonly ProfilePicSize profilePicSize;
        private readonly bool hasRoundedCorners;
        private readonly bool hasGap;
        private readonly bool animationDisabled;

        public class Builder
        {
            internal PostsLayoutType type = PostsLayoutType.GRID;
            internal int colCount = 3;
            internal bool isAvatarVisible = true;
            internal bool isNameVisible = false;
            internal ProfilePicSize profilePicSize = ProfilePicSize.SMALL;
            internal bool hasRoundedCorners = true;
            internal bool hasGap = true;
            internal bool animationDisabled = false;

            public virtual Builder setType(in PostsLayoutType type)
            {
                this.type = type;
                return this;
            }

            public virtual Builder setColCount(in int colCount)
            {
                this.colCount = (colCount <= 0 || colCount > 3) ? 1 : colCount;
                return this;
            }

            public virtual Builder setAvatarVisible(in bool avatarVisible)
            {
                this.isAvatarVisible = avatarVisible;
                return this;
            }

            public virtual Builder setNameVisible(in bool nameVisible)
            {
                this.isNameVisible = nameVisible;
                return this;
            }

            public virtual Builder setProfilePicSize(in ProfilePicSize profilePicSize)
            {
                this.profilePicSize = profilePicSize;
                return this;
            }

            public virtual Builder setHasRoundedCorners(in bool hasRoundedCorners)
            {
                this.hasRoundedCorners = hasRoundedCorners;
                return this;
            }

            public virtual Builder setHasGap(in bool hasGap)
            {
                this.hasGap = hasGap;
                return this;
            }

            public virtual Builder setAnimationDisabled(in bool animationDisabled)
            {
                this.animationDisabled = animationDisabled;
                return this;
            }

            // Breaking builder pattern and adding getters to avoid too many object creations in PostsLayoutPreferencesDialogFragment
            public virtual PostsLayoutType Type
            {
                get { return type; }
            }

            public virtual int ColCount
            {
                get { return colCount; }
            }

            public virtual bool AvatarVisible
            {
                get { return isAvatarVisible; }
            }

            public virtual bool NameVisible
            {
                get { return isNameVisible; }
            }

            public virtual ProfilePicSize ProfilePicSize
            {
                get { return profilePicSize; }
            }

            public virtual bool HasRoundedCorners
            {
                get { return hasRoundedCorners; }
            }

            public virtual bool HasGap
            {
                get { return hasGap; }
            }

            public virtual bool AnimationDisabled
            {
                get { return animationDisabled; }
            }

            public virtual Builder mergeFrom(in PostsLayoutPreferences preferences)
            {
                if (preferences == null)
                {
                    return this;
                }

                colCount = preferences.colCount;
                isAvatarVisible = preferences.isAvatarVisible;
                isNameVisible = preferences.isNameVisible;
                type = preferences.type;
                profilePicSize = preferences.profilePicSize;
                hasRoundedCorners = preferences.hasRoundedCorners;
                hasGap = preferences.hasGap;
                animationDisabled = preferences.animationDisabled;
                return this;
            }

            public virtual PostsLayoutPreferences build()
            {
                return new PostsLayoutPreferences(type, colCount, isAvatarVisible, isNameVisible, profilePicSize,
                    hasRoundedCorners, hasGap, animationDisabled);
            }
        }

        public static Builder builder()
        {
            return new Builder();
        }

        private PostsLayoutPreferences(in PostsLayoutType type, in int colCount, in bool isAvatarVisible,
            in bool isNameVisible, in ProfilePicSize profilePicSize, in bool hasRoundedCorners, in bool hasGap,
            in bool animationDisabled)
        {
            this.type = type;
            this.colCount = colCount;
            this.isAvatarVisible = isAvatarVisible;
            this.isNameVisible = isNameVisible;
            this.profilePicSize = profilePicSize;
            this.hasRoundedCorners = hasRoundedCorners;
            this.hasGap = hasGap;
            this.animationDisabled = animationDisabled;
        }

        public string getJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static PostsLayoutPreferences fromJson(string json)
        {
            if (json == null) return null;
            return JsonConvert.DeserializeObject<PostsLayoutPreferences>(json);
        }

        public override bool Equals(object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            PostsLayoutPreferences that = (PostsLayoutPreferences) o;
            return colCount == that.colCount &&
                   isAvatarVisible == that.isAvatarVisible &&
                   isNameVisible == that.isNameVisible &&
                   type == that.type &&
                   profilePicSize == that.profilePicSize &&
                   animationDisabled == that.animationDisabled;
        }

        public override int GetHashCode()
        {
            return type.GetHashCode() ^ colCount.GetHashCode() ^ isAvatarVisible.GetHashCode() ^
                   isNameVisible.GetHashCode() ^ profilePicSize.GetHashCode() ^ animationDisabled.GetHashCode();
        }

        public override string ToString()
        {
            return "PostsLayoutPreferences{" +
                   "type=" + type +
                   ", colCount=" + colCount +
                   ", isAvatarVisible=" + isAvatarVisible +
                   ", isNameVisible=" + isNameVisible +
                   ", profilePicSize=" + profilePicSize +
                   ", hasRoundedCorners=" + hasRoundedCorners +
                   ", hasGap=" + hasGap +
                   ", animationDisabled=" + animationDisabled +
                   '}';
        }

        public enum PostsLayoutType
        {
            GRID,
            STAGGERED_GRID,
            LINEAR
        }

        public enum ProfilePicSize
        {
            REGULAR,
            SMALL,
            TINY
        }
    }
}