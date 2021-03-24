using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class DiscoverRepository
    {
      async  UniTask<string> topicalExplore(QueryParams queryParams)
        {
            string endPoint = $"/api/v1/discover/topical_explore/";
            endPoint += queryParams.ToString();

            UnityWebRequest unityWebRequest =UnityWebRequest.Get(Constants.BASE_URL + endPoint);
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            return (await unityWebRequest.SendWebRequest()).downloadHandler.text;
        }
      
    }
}