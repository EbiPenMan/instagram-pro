using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class FeedRepository
    {
        async UniTask<string> fetch(FormUrlEncoded formUrlEncoded, Action<string> onDone)
        {
            string endPoint = $"/api/v1/feed/timeline/";

            UnityWebRequest unityWebRequest =
                UnityWebRequest.Put(Constants.BASE_URL_I + endPoint, formUrlEncoded.ToString());
           
            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }

    }
}