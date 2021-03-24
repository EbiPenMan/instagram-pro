using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
	[Serializable]
	public sealed class PostChild
	{
		private readonly string postId;
		private readonly string displayUrl;
		private readonly string shortCode;
		private readonly MediaItemType itemType;
		private readonly string thumbnailUrl;
		private readonly long videoViews;
		private readonly int width;
		private readonly int height;

		public class Builder
		{
			internal string postId, displayUrl, shortCode, thumbnailUrl;
			internal MediaItemType itemType;
			internal long videoViews;
			internal int width;
			internal int height;

			public virtual Builder setPostId(in string postId)
			{
				this.postId = postId;
				return this;
			}

			public virtual Builder setShortCode(in string shortCode)
			{
				this.shortCode = shortCode;
				return this;
			}

			public virtual Builder setItemType(in MediaItemType itemType)
			{
				this.itemType = itemType;
				return this;
			}

			public virtual Builder setDisplayUrl(in string displayUrl)
			{
				this.displayUrl = displayUrl;
				return this;
			}

			public virtual Builder setVideoViews(in long videoViews)
			{
				this.videoViews = videoViews;
				return this;
			}

			public virtual Builder setHeight(in int height)
			{
				this.height = height;
				return this;
			}

			public virtual Builder setWidth(in int width)
			{
				this.width = width;
				return this;
			}

			public virtual Builder setThumbnailUrl(in string thumbnailUrl)
			{
				this.thumbnailUrl = thumbnailUrl;
				return this;
			}

			public virtual PostChild build()
			{
				return new PostChild(postId, shortCode, itemType, displayUrl, thumbnailUrl, videoViews, height, width);
			}
		}

		public PostChild(in string postId, in string shortCode, in MediaItemType itemType, in string displayUrl, in string thumbnailUrl, in long videoViews, in int height, in int width)
		{
			this.postId = postId;
			this.shortCode = shortCode;
			this.itemType = itemType;
			this.displayUrl = displayUrl;
			this.thumbnailUrl = thumbnailUrl;
			this.height = height;
			this.width = width;
			this.videoViews = videoViews;
		}

		public string PostId => postId;

		public string DisplayUrl => displayUrl;

		public string ShortCode => shortCode;

		public MediaItemType ItemType => itemType;

		public string ThumbnailUrl => thumbnailUrl;

		public long VideoViews => videoViews;

		public int Width => width;

		public int Height => height;

		public override string ToString()
		{
			return "PostChild{" +
			       "postId='" + postId + '\'' +
			       ", shortCode=" + shortCode +
			       ", itemType=" + itemType +
			       ", displayUrl='" + displayUrl + '\'' +
			       ", thumbnailUrl='" + thumbnailUrl + '\'' +
			       ", videoViews=" + videoViews +
			       ", width=" + width +
			       ", height=" + height +
			       '}';
		}
	}
}
