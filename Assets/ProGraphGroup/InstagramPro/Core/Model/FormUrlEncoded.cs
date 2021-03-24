using System.Collections.Generic;


namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class FormUrlEncoded
    {
        private Dictionary<string, string> _queryParams;

        public FormUrlEncoded()
        {
        }

        public FormUrlEncoded(Dictionary<string, string> queryParams)
        {
            _queryParams = queryParams;
        }

        public FormUrlEncoded add(string key , string value)
        {
            _queryParams.Add(key,value);
            return this;
        }
        
        public FormUrlEncoded remove(string key)
        {
            _queryParams.Remove(key);
            return this;
        }

        public Dictionary<string, string> getAll()
        {
            return _queryParams;
        }

        public override string ToString()
        {
            string query = "";

            foreach (string key in _queryParams.Keys)
            {
                if (!query.Equals(""))
                {
                    query += "&";
                }

                query += key + "=" + _queryParams[key];
            }

            return query;
        }
    }
}
