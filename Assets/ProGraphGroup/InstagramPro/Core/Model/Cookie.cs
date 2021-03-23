

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class Cookie
    {
        private string ig_did;
        private int ig_nrcb;
        private string mid;
        private string csrftoken;
        private long ds_user_id;
        private string sessionid;
        private int shbid;
        private string shbts;
        private string rur;

        public Cookie()
        {
        }

        public Cookie(string igDid, int igNrcb, string mid, string csrftoken, long dsUserId, string sessionid, int shbid, string shbts, string rur)
        {
            ig_did = igDid;
            ig_nrcb = igNrcb;
            this.mid = mid;
            this.csrftoken = csrftoken;
            ds_user_id = dsUserId;
            this.sessionid = sessionid;
            this.shbid = shbid;
            this.shbts = shbts;
            this.rur = rur;
        }

        public string IgDid
        {
            get => ig_did;
            set => ig_did = value;
        }

        public int IgNrcb
        {
            get => ig_nrcb;
            set => ig_nrcb = value;
        }

        public string Mid
        {
            get => mid;
            set => mid = value;
        }

        public string Csrftoken
        {
            get => csrftoken;
            set => csrftoken = value;
        }

        public long DsUserId
        {
            get => ds_user_id;
            set => ds_user_id = value;
        }

        public string Sessionid
        {
            get => sessionid;
            set => sessionid = value;
        }

        public int Shbid
        {
            get => shbid;
            set => shbid = value;
        }

        public string Shbts
        {
            get => shbts;
            set => shbts = value;
        }

        public string Rur
        {
            get => rur;
            set => rur = value;
        }
    }
}
