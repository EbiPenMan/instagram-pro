using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class LocationRepository
    {
        async UniTask<string> fetchPosts(
            string locationId,
            QueryParams queryParams, Action<string> onDone)
        {
            string endPoint = $"/api/v1/feed/location/{locationId}/";
            endPoint += queryParams.ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
    }
}