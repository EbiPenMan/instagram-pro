using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class NewsRepository
    {
        async UniTask<string> webInbox(Action<string> onDone)
        {
            string endPoint = $"/accounts/activity/";
            endPoint += new QueryParams().add("__a" , "1").ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_WWW + endPoint);
            
            unityWebRequest.SetRequestHeader("User-Agent" , Constants.USER_AGENT);
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> appInbox( 
            bool markAsSeen,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/news/inbox/";
            
            //TODO @QueryMap(encoded = true) 

            endPoint += new QueryParams().add("mark_as_seen" , markAsSeen.ToString()).ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> getAyml(
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/discover/ayml/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
    }
}