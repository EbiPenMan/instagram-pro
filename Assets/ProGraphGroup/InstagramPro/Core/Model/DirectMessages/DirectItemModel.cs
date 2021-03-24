using System;
using System.Linq;
using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.InstagramPro.Core.Model;
using ProGraphGroup.InstagramPro.Core.Model.Enums;
using ProGraphGroup.Utility;

[Serializable]
public sealed class DirectItemModel : IComparable<DirectItemModel>
{
    private readonly long userId, timestamp;
    private readonly DirectItemType itemType;
    private readonly string itemId;
    private string[] likes;
    private bool liked;
    private readonly string text;
    private readonly DirectItemLinkModel linkModel;
    private readonly DirectItemMediaModel mediaModel;
    private readonly ProfileModel profileModel;
    private readonly DirectItemReelShareModel reelShare;
    private readonly DirectItemActionLogModel actionLogModel;
    private readonly DirectItemVoiceMediaModel voiceMediaModel;
    private readonly DirectItemRavenMediaModel ravenMediaModel;
    private readonly DirectItemAnimatedMediaModel animatedMediaModel;
    private readonly DirectItemVideoCallEventModel videoCallEventModel;
    private readonly DateTime date;

    public int CompareTo(DirectItemModel other)
    {
        return timestamp.CompareTo(other.timestamp);
    }

    public DirectItemModel(long userId, long timestamp, DirectItemType itemType, string itemId, string[] likes,
        string text, DirectItemLinkModel linkModel, DirectItemMediaModel mediaModel,
        ProfileModel profileModel, DirectItemReelShareModel reelShare, DirectItemActionLogModel actionLogModel,
        DirectItemVoiceMediaModel voiceMediaModel, DirectItemRavenMediaModel ravenMediaModel,
        DirectItemAnimatedMediaModel animatedMediaModel, DirectItemVideoCallEventModel videoCallEventModel)
    {
        string myId = LoginManager.Instance.GetCurrentCookie().DsUserId;
        this.userId = userId;
        this.timestamp = timestamp;
        this.itemType = itemType;
        this.itemId = itemId;
        this.likes = likes;
        liked = likes != null && likes.Contains(myId);
        this.text = text;
        this.linkModel = linkModel;
        this.profileModel = profileModel;
        this.reelShare = reelShare;
        this.actionLogModel = actionLogModel;
        this.voiceMediaModel = voiceMediaModel;
        this.ravenMediaModel = ravenMediaModel;
        this.animatedMediaModel = animatedMediaModel;
        this.videoCallEventModel = videoCallEventModel;
        date = GeneralUtils.UnixTimeStampToDateTime(timestamp);
    }

    public long UserId => userId;

    public long Timestamp => timestamp;

    public DirectItemType ItemType => itemType;

    public string ItemId => itemId;

    public string[] Likes
    {
        get => likes;
        set => likes = value;
    }

    public bool Liked
    {
        get => liked;
        set => liked = value;
    }

    public string Text => text;

    public DirectItemLinkModel LinkModel => linkModel;

    public DirectItemMediaModel MediaModel => mediaModel;

    public ProfileModel ProfileModel => profileModel;

    public DirectItemReelShareModel ReelShare => reelShare;

    public DirectItemActionLogModel ActionLogModel => actionLogModel;

    public DirectItemVoiceMediaModel VoiceMediaModel => voiceMediaModel;

    public DirectItemRavenMediaModel RavenMediaModel => ravenMediaModel;

    public DirectItemAnimatedMediaModel AnimatedMediaModel => animatedMediaModel;

    public DirectItemVideoCallEventModel VideoCallEventModel => videoCallEventModel;

    public DateTime Date => date;


    [Serializable]
    public sealed class DirectItemAnimatedMediaModel
    {
        private readonly bool isRandom, isSticker;
        private readonly string id;
        private readonly string gifUrl;
        private readonly string webpUrl;
        private readonly string mp4Url;
        private readonly int height, width;

        public DirectItemAnimatedMediaModel(bool isRandom, bool isSticker, string id, string gifUrl, string webpUrl, string mp4Url, int height, int width)
        {
            this.isRandom = isRandom;
            this.isSticker = isSticker;
            this.id = id;
            this.gifUrl = gifUrl;
            this.webpUrl = webpUrl;
            this.mp4Url = mp4Url;
            this.height = height;
            this.width = width;
        }

        public bool IsRandom => isRandom;

        public bool IsSticker => isSticker;

        public string Id => id;

        public string GifUrl => gifUrl;

        public string WebpUrl => webpUrl;

        public string Mp4Url => mp4Url;

        public int Height => height;

        public int Width => width;
    }

    [Serializable]
    public sealed class DirectItemVoiceMediaModel
    {
        private readonly string id, audioUrl;
        private readonly long durationMs;
        private readonly int[] waveformData;
        private int progress;
        private bool isPlaying = false;

        public DirectItemVoiceMediaModel(string id, string audioUrl, long durationMs, int[] waveformData, int progress)
        {
            this.id = id;
            this.audioUrl = audioUrl;
            this.durationMs = durationMs;
            this.waveformData = waveformData;
            this.progress = progress;
        }

        public string Id => id;

        public string AudioUrl => audioUrl;

        public long DurationMs => durationMs;

        public int[] WaveformData => waveformData;

        public int Progress
        {
            get => progress;
            set => progress = value;
        }

        public bool IsPlaying
        {
            get => isPlaying;
            set => isPlaying = value;
        }
    }

    [Serializable]
    public sealed class DirectItemLinkModel
    {
        private readonly string text;
        private readonly string clientContext;
        private readonly string mutationToken;
        private readonly DirectItemLinkContext linkContext;

        public DirectItemLinkModel(string text, string clientContext, string mutationToken, DirectItemLinkContext linkContext)
        {
            this.text = text;
            this.clientContext = clientContext;
            this.mutationToken = mutationToken;
            this.linkContext = linkContext;
        }

        public string Text1 => text;

        public string ClientContext => clientContext;

        public string MutationToken => mutationToken;

        public DirectItemLinkContext LinkContext => linkContext;
    }

    [Serializable]
    public sealed class DirectItemLinkContext
    {
        private readonly string linkUrl;
        private readonly string linkTitle;
        private readonly string linkSummary;
        private readonly string linkImageUrl;

        public DirectItemLinkContext(string linkUrl, string linkTitle, string linkSummary, string linkImageUrl)
        {
            this.linkUrl = linkUrl;
            this.linkTitle = linkTitle;
            this.linkSummary = linkSummary;
            this.linkImageUrl = linkImageUrl;
        }

        public string LinkUrl => linkUrl;

        public string LinkTitle => linkTitle;

        public string LinkSummary => linkSummary;

        public string LinkImageUrl => linkImageUrl;
    }

    [Serializable]
    public sealed class DirectItemActionLogModel
    {
        private readonly string description;

        public DirectItemActionLogModel(string description)
        {
            this.description = description;
        }

        public string Description => description;
    }

    [Serializable]
    public sealed class DirectItemReelShareModel
    {
        private readonly bool isReelPersisted;
        private readonly long reelOwnerId;
        private readonly string reelOwnerName;
        private readonly string text;
        private readonly string type;
        private readonly string reelType;
        private readonly string reelName;
        private readonly string reelId;
        private readonly DirectItemMediaModel media;

        public DirectItemReelShareModel(bool isReelPersisted, long reelOwnerId, string reelOwnerName, string text, string type, string reelType, string reelName, string reelId, DirectItemMediaModel media)
        {
            this.isReelPersisted = isReelPersisted;
            this.reelOwnerId = reelOwnerId;
            this.reelOwnerName = reelOwnerName;
            this.text = text;
            this.type = type;
            this.reelType = reelType;
            this.reelName = reelName;
            this.reelId = reelId;
            this.media = media;
        }

        public bool IsReelPersisted => isReelPersisted;

        public long ReelOwnerId => reelOwnerId;

        public string ReelOwnerName => reelOwnerName;

        public string Text1 => text;

        public string Type => type;

        public string ReelType => reelType;

        public string ReelName => reelName;

        public string ReelId => reelId;

        public DirectItemMediaModel Media => media;
    }

    [Serializable]
    public sealed class DirectItemMediaModel
    {
        private readonly MediaItemType mediaType;
        private readonly long expiringAt, pk;
        private readonly string id;
        private readonly string thumbUrl;
        private readonly string videoUrl;
        private readonly string code;
        private readonly ProfileModel user;
        private readonly int height;
        private readonly int width;

        public DirectItemMediaModel(MediaItemType mediaType, long expiringAt, long pk, string id, string thumbUrl, string videoUrl, string code, ProfileModel user, int height, int width)
        {
            this.mediaType = mediaType;
            this.expiringAt = expiringAt;
            this.pk = pk;
            this.id = id;
            this.thumbUrl = thumbUrl;
            this.videoUrl = videoUrl;
            this.code = code;
            this.user = user;
            this.height = height;
            this.width = width;
        }

        public MediaItemType MediaType => mediaType;

        public long ExpiringAt => expiringAt;

        public long Pk => pk;

        public string Id => id;

        public string ThumbUrl => thumbUrl;

        public string VideoUrl => videoUrl;

        public string Code => code;

        public ProfileModel User => user;

        public int Height => height;

        public int Width => width;
    }

    [Serializable]
    public sealed class DirectItemRavenMediaModel
    {
        private readonly long expireAtSecs;
        private readonly int playbackDurationSecs;
        private readonly int seenCount;
        private readonly string[] seenUserIds;
        private readonly RavenMediaViewType viewType;
        private readonly DirectItemMediaModel media;
        private readonly RavenExpiringMediaActionSummaryModel expiringMediaActionSummary;

        public DirectItemRavenMediaModel(long expireAtSecs, int playbackDurationSecs, int seenCount, string[] seenUserIds, RavenMediaViewType viewType, DirectItemMediaModel media, RavenExpiringMediaActionSummaryModel expiringMediaActionSummary)
        {
            this.expireAtSecs = expireAtSecs;
            this.playbackDurationSecs = playbackDurationSecs;
            this.seenCount = seenCount;
            this.seenUserIds = seenUserIds;
            this.viewType = viewType;
            this.media = media;
            this.expiringMediaActionSummary = expiringMediaActionSummary;
        }

        public long ExpireAtSecs => expireAtSecs;

        public int PlaybackDurationSecs => playbackDurationSecs;

        public int SeenCount => seenCount;

        public string[] SeenUserIds => seenUserIds;

        public RavenMediaViewType ViewType => viewType;

        public DirectItemMediaModel Media => media;

        public RavenExpiringMediaActionSummaryModel ExpiringMediaActionSummary => expiringMediaActionSummary;
    }

    [Serializable]
    public sealed class DirectItemVideoCallEventModel
    {
        private readonly long videoCallId;
        private readonly bool hasAudioOnlyCall;
        private readonly string action;
        private readonly string description;

        public DirectItemVideoCallEventModel(long videoCallId, bool hasAudioOnlyCall, string action, string description)
        {
            this.videoCallId = videoCallId;
            this.hasAudioOnlyCall = hasAudioOnlyCall;
            this.action = action;
            this.description = description;
        }

        public long VideoCallId => videoCallId;

        public bool HasAudioOnlyCall => hasAudioOnlyCall;

        public string Action => action;

        public string Description => description;
    }

    [Serializable]
    public sealed class RavenExpiringMediaActionSummaryModel
    {
        private readonly long timestamp;
        private readonly int count;
        private readonly RavenExpiringMediaType type;

        public RavenExpiringMediaActionSummaryModel(long timestamp, int count, RavenExpiringMediaType type)
        {
            this.timestamp = timestamp;
            this.count = count;
            this.type = type;
        }

        public long Timestamp1 => timestamp;

        public int Count => count;

        public RavenExpiringMediaType Type => type;
    }
}