using System.Collections.Generic;


namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class QueryParams
    {
        private Dictionary<string, string> _queryParams;

        public QueryParams()
        {
        }

        public QueryParams(Dictionary<string, string> queryParams)
        {
            _queryParams = queryParams;
        }

        public QueryParams add(string key , string value)
        {
            _queryParams.Add(key,value);
            return this;
        }
        
        public QueryParams remove(string key)
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
                if (query.Equals(""))
                {
                    query += "?";
                }
                else
                {
                    query += "&";
                }

                query += key + "=" + _queryParams[key];
            }

            return query;
        }
    }
}
