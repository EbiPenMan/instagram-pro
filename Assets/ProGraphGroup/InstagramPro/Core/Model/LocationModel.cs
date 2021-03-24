using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class LocationModel
    {
        private readonly long postCount;
        private readonly string id;
        private readonly string slug;
        private readonly string name;
        private readonly string bio;
        private readonly string url;
        private readonly string sdProfilePic;
        private readonly string lat;
        private readonly string lng;

        public LocationModel(in string id, in string slug, in string name, in string bio, in string url, in string sdProfilePic, in long postCount, in string lat, in string lng)
        {
            this.id = id;
            this.slug = slug;
            this.name = name;
            this.bio = bio;
            this.url = url;
            this.sdProfilePic = sdProfilePic;
            this.postCount = postCount;
            this.lat = lat;
            this.lng = lng;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Slug
        {
            get
            {
                return slug;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Bio
        {
            get
            {
                return bio;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
        }

        public string Geo
        {
            get
            {
                return "geo:" + lat + "," + lng + "?z=17&q=" + lat + "," + lng + "(" + name + ")";
            }
        }

        public string SdProfilePic
        {
            get
            {
                return sdProfilePic;
            }
        }

        public long? PostCount
        {
            get
            {
                return postCount;
            }
        }
    }
}