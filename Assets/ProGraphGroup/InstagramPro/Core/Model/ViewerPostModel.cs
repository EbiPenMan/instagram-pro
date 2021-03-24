using ProGraphGroup.InstagramPro.Core.Model.Enums;
using UnityEngine.UI;

namespace ProGraphGroup.InstagramPro.Core.Model
{
	public sealed class ViewerPostModel : BasePostModel
	{
		protected internal readonly ProfileModel profileModel;
		protected internal readonly string locationName;
		protected internal readonly string location;
		protected internal readonly long videoViews;
		private readonly string thumbnailUrl;
		protected internal long commentsCount;
		protected internal long likes;
		private int imageWidth;
		private int imageHeight;
		private bool isCurrentSlide = false;

		public class Builder
		{
			internal MediaItemType itemType;
			internal string postId;
			internal string displayUrl;
			internal string shortCode;
			internal string postCaption;
			internal ProfileModel profileModel;
			internal long videoViews;
			internal long timestamp;
			internal bool liked;
			internal bool bookmarked;
			internal long likes;
			internal string locationName;
			internal string location;
			internal string thumbnailUrl;
			internal int imageWidth;
			internal int imageHeight;

			public virtual Builder setItemType(in MediaItemType itemType)
			{
				this.itemType = itemType;
				return this;
			}

			public virtual Builder setPostId(in string postId)
			{
				this.postId = postId;
				return this;
			}

			public virtual Builder setDisplayUrl(in string displayUrl)
			{
				this.displayUrl = displayUrl;
				return this;
			}

			public virtual Builder setShortCode(in string shortCode)
			{
				this.shortCode = shortCode;
				return this;
			}

			// public Builder setPostCaption(final String postCaption) {
			//     this.postCaption = postCaption;
			//     return this;
			// }

			// public Builder setProfileModel(final ProfileModel profileModel) {
			//     this.profileModel = profileModel;
			//     return this;
			// }

			public virtual Builder setVideoViews(in long videoViews)
			{
				this.videoViews = videoViews;
				return this;
			}

			// public Builder setTimestamp(final long timestamp) {
			//     this.timestamp = timestamp;
			//     return this;
			// }
			//
			// public Builder setLiked(final boolean liked) {
			//     this.liked = liked;
			//     return this;
			// }
			//
			// public Builder setBookmarked(final boolean bookmarked) {
			//     this.bookmarked = bookmarked;
			//     return this;
			// }
			//
			// public Builder setLikes(final long likes) {
			//     this.likes = likes;
			//     return this;
			// }

			// public Builder setLocationName(final String locationName) {
			//     this.locationName = locationName;
			//     return this;
			// }
			//
			// public Builder setLocation(final String location) {
			//     this.location = location;
			//     return this;
			// }


			public virtual Builder setImageHeight(in int imageHeight)
			{
				this.imageHeight = imageHeight;
				return this;
			}

			public virtual Builder setImageWidth(in int imageWidth)
			{
				this.imageWidth = imageWidth;
				return this;
			}

			public virtual Builder setThumbnailUrl(in string thumbnailUrl)
			{
				this.thumbnailUrl = thumbnailUrl;
				return this;
			}

			public virtual ViewerPostModel build()
			{
				return new ViewerPostModel(itemType, postId, displayUrl, thumbnailUrl, imageHeight, imageWidth, shortCode, postCaption, profileModel, videoViews, timestamp, liked, bookmarked, likes, locationName, location);
			}
		}

		public ViewerPostModel(in MediaItemType itemType, in string postId, in string displayUrl, in string thumbnailUrl, in int imageHeight, in int imageWidth, in string shortCode, in string postCaption, in ProfileModel profileModel, in long videoViews, in long timestamp, bool liked, bool bookmarked, long likes, in string locationName, in string location)
		{
			this.itemType = itemType;
			this.postId = postId;
			this.displayUrl = displayUrl;
			this.thumbnailUrl = thumbnailUrl;
			this.imageHeight = imageHeight;
			this.imageWidth = imageWidth;
			this.postCaption = postCaption;
			this.profileModel = profileModel;
			this.shortCode = shortCode;
			this.videoViews = videoViews;
			this.timestamp = timestamp;
			this.liked = liked;
			this.likes = likes;
			this.saved = bookmarked;
			this.locationName = locationName;
			this.location = location;
		}

		public ProfileModel ProfileModel => profileModel;

		public string LocationName => locationName;

		public string Location => location;

		public long VideoViews => videoViews;

		public string ThumbnailUrl => thumbnailUrl;

		public long CommentsCount
		{
			get => commentsCount;
			set => commentsCount = value;
		}

		public long Likes
		{
			get => likes;
			set => likes = value;
		}

		public int ImageWidth
		{
			get => imageWidth;
			set => imageWidth = value;
		}

		public int ImageHeight
		{
			get => imageHeight;
			set => imageHeight = value;
		}

		public bool IsCurrentSlide
		{
			get => isCurrentSlide;
			set => isCurrentSlide = value;
		}

		public string PostId1
		{
			get => postId;
			set => postId = value;
		}

		public string DisplayUrl1
		{
			get => displayUrl;
			set => displayUrl = value;
		}

		public string ShortCode1
		{
			get => shortCode;
			set => shortCode = value;
		}

		public string CaptionId1
		{
			get => captionId;
			set => captionId = value;
		}

		public string PostCaption1
		{
			get => postCaption;
			set => postCaption = value;
		}

		public MediaItemType ItemType1
		{
			get => itemType;
			set => itemType = value;
		}

		public bool IsSelected1
		{
			get => isSelected;
			set => isSelected = value;
		}

		public bool IsDownloaded1
		{
			get => isDownloaded;
			set => isDownloaded = value;
		}

		public long Timestamp1
		{
			get => timestamp;
			set => timestamp = value;
		}

		public bool Liked1
		{
			get => liked;
			set => liked = value;
		}

		public bool Saved1
		{
			get => saved;
			set => saved = value;
		}

		public static Selectable[] SSelectables1
		{
			get => s_Selectables;
			set => s_Selectables = value;
		}

		public static int SSelectableCount1
		{
			get => s_SelectableCount;
			set => s_SelectableCount = value;
		}

		public int MCurrentIndex1
		{
			get => m_CurrentIndex;
			set => m_CurrentIndex = value;
		}

		public void setManualLike(bool like) {
			liked = like;
			likes = (like) ? (likes + 1) : (likes - 1);
		}


		public override string ToString()
		{
			return "ViewerPostModel{" +
			       "type=" + itemType +
			       ", displayUrl=" + displayUrl +
			       ", thumbnailUrl=" + thumbnailUrl +
			       ", locationName='" + locationName + '\'' +
			       ", location='" + location + '\'' +
			       ", videoViews=" + videoViews +
			       ", thumbnailUrl='" + thumbnailUrl + '\'' +
			       ", commentsCount=" + commentsCount +
			       ", likes=" + likes +
			       ", imageWidth=" + imageWidth +
			       ", imageHeight=" + imageHeight +
			       ", isCurrentSlide=" + isCurrentSlide +
			       '}';
		}
	}
}
