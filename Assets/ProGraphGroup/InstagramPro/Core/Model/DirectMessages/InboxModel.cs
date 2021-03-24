namespace ProGraphGroup.InstagramPro.Core.Model.DirectMessages
{
    public sealed class InboxModel
    {
        private readonly bool hasOlder, hasPendingTopRequests, blendedInboxEnabled;
        private readonly int unseenCount, pendingRequestsCount;
        private readonly long seqId, unseenCountTimestamp;
        private readonly InboxThreadModel[] threads;
        private string oldestCursor;

        public InboxModel(in bool hasOlder, in bool hasPendingTopRequests, in bool blendedInboxEnabled, in int unseenCount, in int pendingRequestsCount, in long seqId, in long unseenCountTimestamp, in string oldestCursor, in InboxThreadModel[] threads)
        {
            this.hasOlder = hasOlder;
            this.hasPendingTopRequests = hasPendingTopRequests;
            this.blendedInboxEnabled = blendedInboxEnabled;
            this.unseenCount = unseenCount;
            this.pendingRequestsCount = pendingRequestsCount;
            this.unseenCountTimestamp = unseenCountTimestamp;
            this.oldestCursor = oldestCursor;
            this.threads = threads;
            this.seqId = seqId;
        }

        public bool HasOlder
        {
            get
            {
                return hasOlder;
            }
        }

        public bool HasPendingTopRequests
        {
            get
            {
                return hasPendingTopRequests;
            }
        }

        public bool BlendedInboxEnabled
        {
            get
            {
                return blendedInboxEnabled;
            }
        }

        public int UnseenCount
        {
            get
            {
                return unseenCount;
            }
        }

        public int PendingRequestsCount
        {
            get
            {
                return pendingRequestsCount;
            }
        }

        public long UnseenCountTimestamp
        {
            get
            {
                return unseenCountTimestamp;
            }
        }

        public long SeqId
        {
            get
            {
                return seqId;
            }
        }

        public string OldestCursor
        {
            get
            {
                return oldestCursor;
            }
            set
            {
                this.oldestCursor = value;
            }
        }


        public InboxThreadModel[] Threads
        {
            get
            {
                return threads;
            }
        }
    }

}