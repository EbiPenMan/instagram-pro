using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;
using ProGraphGroup.Utility;
using UnityEngine.UI;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public abstract class BasePostModel : Selectable
    {
        protected internal string postId, displayUrl, shortCode, captionId;
        protected internal string postCaption;
        protected internal MediaItemType itemType;
        protected internal bool isSelected, isDownloaded;
        protected internal long timestamp;
        internal bool liked, saved;
        
        public string PostId
        {
            get => postId;
            set => postId = value;
        }

        public string DisplayUrl
        {
            get => displayUrl;
            set => displayUrl = value;
        }

        public string ShortCode
        {
            get => shortCode;
            set => shortCode = value;
        }

        public string CaptionId
        {
            get => captionId;
            set => captionId = value;
        }

        public string PostCaption
        {
            get => postCaption;
            set => postCaption = value;
        }

        public MediaItemType ItemType
        {
            get => itemType;
            set => itemType = value;
        }

        public bool IsSelected
        {
            get => isSelected;
            set => isSelected = value;
        }

        public bool IsDownloaded
        {
            get => isDownloaded;
            set => isDownloaded = value;
        }

        public long Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public bool Liked
        {
            get => liked;
            set => liked = value;
        }

        public bool Saved
        {
            get => saved;
            set => saved = value;
        }

        public static Selectable[] SSelectables
        {
            get => s_Selectables;
            set => s_Selectables = value;
        }

        public static int SSelectableCount
        {
            get => s_SelectableCount;
            set => s_SelectableCount = value;
        }

        public int MCurrentIndex
        {
            get => m_CurrentIndex;
            set => m_CurrentIndex = value;
        }
        
        
        public string PostDate
        {
            get { return GeneralUtils.UnixTimeStampToDateTime(timestamp).ToString(); }
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

            BasePostModel that = (BasePostModel) o;
            return postId.Equals(that.postId) && shortCode.Equals(that.shortCode);
        }


        public override int GetHashCode()
        {
            return postId.GetHashCode() ^ shortCode.GetHashCode();
        }
    }
    
}