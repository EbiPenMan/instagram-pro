using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model.DirectMessages
{
    [Serializable]
    public sealed class InboxThreadModel
    {
        private readonly InboxReadState readState;

        private readonly string threadId,
            threadV2Id,
            threadType,
            threadTitle,
            newestCursor,
            oldestCursor,
            nextCursor,
            prevCursor;

        private readonly ProfileModel inviter;
        private readonly ProfileModel[] users, leftUsers;
        private readonly long?[] admins;
        private readonly DirectItemModel[] items;
        private readonly bool muted, isPin, isSpam, isGroup, named, pending, archived, canonical, hasOlder;
        private readonly long unreadCount, lastActivityAt;

        public InboxThreadModel(in InboxReadState readState, in string threadId, in string threadV2Id,
            in string threadType, in string threadTitle, in string newestCursor, in string oldestCursor,
            in string nextCursor, in string prevCursor, in ProfileModel inviter, in ProfileModel[] users,
            in ProfileModel[] leftUsers, in long?[] admins, in DirectItemModel[] items, in bool muted, in bool isPin,
            in bool named, in bool canonical, in bool pending, in bool hasOlder, in long unreadCount, in bool isSpam,
            in bool isGroup, in bool archived, in long lastActivityAt)
        {
            this.readState = readState;
            this.threadId = threadId;
            this.threadV2Id = threadV2Id;
            this.threadType = threadType;
            this.threadTitle = threadTitle;
            this.newestCursor = newestCursor;
            this.oldestCursor = oldestCursor;
            this.nextCursor = nextCursor;
            this.prevCursor = prevCursor;
            this.inviter = inviter;
            this.users = users;
            this.leftUsers = leftUsers;
            this.admins = admins;
            this.items = items; // todo
            this.muted = muted;
            this.isPin = isPin;
            this.named = named;
            this.canonical = canonical;
            this.pending = pending;
            this.hasOlder = hasOlder;
            this.unreadCount = unreadCount;
            this.isSpam = isSpam;
            this.isGroup = isGroup;
            this.archived = archived;
            this.lastActivityAt = lastActivityAt;
        }

        public InboxReadState ReadState
        {
            get { return readState; }
        }

        public string ThreadId
        {
            get { return threadId; }
        }


        public override bool Equals(object o)
        {
            if (this == o)
            {
                return true;
            }

            if (o == null || this.GetType() != o.GetType())
            {
                return false;
            }

            InboxThreadModel that = (InboxThreadModel) o;
            return this.threadId.Equals(that.threadId) && this.threadV2Id.Equals(that.threadV2Id);
        }

        public override int GetHashCode()
        {
            return threadId.GetHashCode() ^ threadV2Id.GetHashCode();
        }

        public InboxReadState ReadState1 => readState;

        public string ThreadId1 => threadId;

        public string ThreadV2Id => threadV2Id;

        public string ThreadType => threadType;

        public string ThreadTitle => threadTitle;

        public string NewestCursor => newestCursor;

        public string OldestCursor => oldestCursor;

        public string NextCursor => nextCursor;

        public string PrevCursor => prevCursor;

        public ProfileModel Inviter => inviter;

        public ProfileModel[] Users => users;

        public ProfileModel[] LeftUsers => leftUsers;

        public long?[] Admins => admins;

        public DirectItemModel[] Items => items;

        public bool Muted => muted;

        public bool IsPin => isPin;

        public bool IsSpam => isSpam;

        public bool IsGroup => isGroup;

        public bool Named => named;

        public bool Pending => pending;

        public bool Archived => archived;

        public bool Canonical => canonical;

        public bool HasOlder => hasOlder;

        public long UnreadCount => unreadCount;

        public long LastActivityAt => lastActivityAt;
    }
}
