using System.Collections.Generic;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class ViewerPostModelWrapper
    {
        private int position;
        private IList<PostChild> viewerPostModels;

        public ViewerPostModelWrapper(in int position, in IList<PostChild> viewerPostModels)
        {
            this.position = position;
            this.viewerPostModels = viewerPostModels;
        }

        public virtual int Position
        {
            get
            {
                return position;
            }
        }

        public virtual IList<PostChild> ViewerPostModels
        {
            get
            {
                return viewerPostModels;
            }
            set
            {
                this.viewerPostModels = value;
            }
        }

    }
}