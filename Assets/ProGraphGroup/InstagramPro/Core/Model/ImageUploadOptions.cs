using UnityEngine;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class ImageUploadOptions
    {
        private readonly Texture2D bitmap;
        private bool isSidecar;
        private string waterfallId;

        public class Builder
        {
            internal Texture2D bitmap;
            internal bool isSidecar;
            internal string waterfallId;

            public Builder(in Texture2D bitmap)
            {
                this.bitmap = bitmap;
            }

            public virtual Builder setBitmap(in Texture2D bitmap)
            {
                this.bitmap = bitmap;
                return this;
            }

            public virtual Builder setIsSidecar(in bool isSidecar)
            {
                this.isSidecar = isSidecar;
                return this;
            }

            public virtual Builder setWaterfallId(in string waterfallId)
            {
                this.waterfallId = waterfallId;
                return this;
            }

            public virtual ImageUploadOptions build()
            {
                return new ImageUploadOptions(bitmap, isSidecar, waterfallId);
            }
        }

        public static Builder builder(in Texture2D file)
        {
            return new Builder(file);
        }

        private ImageUploadOptions(in Texture2D bitmap, in bool isSidecar, in string waterfallId)
        {
            this.bitmap = bitmap;
            this.isSidecar = isSidecar;
            this.waterfallId = waterfallId;
        }

        public virtual Texture2D Bitmap
        {
            get
            {
                return bitmap;
            }
        }

        public virtual bool Sidecar
        {
            get
            {
                return isSidecar;
            }
        }

        public virtual string WaterfallId
        {
            get
            {
                return waterfallId;
            }
        }
    }
}