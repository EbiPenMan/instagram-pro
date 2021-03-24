using System;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class Cookie
    {
        private string ig_did;
        private string ig_nrcb;
        private string mid;
        private string csrftoken;
        private string ds_user_id;
        private string sessionid;
        private string shbid;
        private string shbts;
        private string rur;

        private string strCookie;

        public Cookie(string strCookie)
        {
            
            this.strCookie = strCookie;
            
            if (TextUtils.isEmpty(strCookie))
                return;

            foreach (string fields in strCookie.Split(new string[] {"; "}, StringSplitOptions.None))
            {
                string[] field = fields.Split(new string[] {"="}, StringSplitOptions.None);

                switch (field[0].Trim())
                {
                    case "ig_did":
                        this.ig_did = field[1].Trim();
                        break;
                    case "ig_nrcb":
                        this.ig_nrcb = field[1].Trim();
                        break;
                    case "mid":
                        this.mid = field[1].Trim();
                        break;
                    case "csrftoken":
                        this.csrftoken = field[1].Trim();
                        break;
                    case "ds_user_id":
                        this.ds_user_id = field[1].Trim();
                        break;
                    case "sessionid":
                        this.sessionid = field[1].Trim();
                        break;
                    case "shbid":
                        this.shbid = field[1].Trim();
                        break;
                    case "shbts":
                        this.shbts = field[1].Trim();
                        break;
                    case "rur":
                        this.rur = field[1].Trim();
                        break;
                }

            }
        }
        
        public string IgDid
        {
            get => ig_did;
            set => ig_did = value;
        }

        public string IgNrcb
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

        public string DsUserId
        {
            get => ds_user_id;
            set => ds_user_id = value;
        }

        public string Sessionid
        {
            get => sessionid;
            set => sessionid = value;
        }

        public string Shbid
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


        public override string ToString()
        {
            return strCookie;
        }
    }
}