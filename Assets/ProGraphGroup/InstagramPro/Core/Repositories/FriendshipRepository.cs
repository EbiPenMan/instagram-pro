using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class FriendshipRepository
    {
        async UniTask<string> change(
            string userAgent,
            string action,
            string id,
            FormUrlEncoded formUrlEncoded, 
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/friendships/{action}/{id}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL + endPoint , 
                formUrlEncoded.ToString());
            
            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            unityWebRequest.SetRequestHeader("User-Agent" , userAgent);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> toggleRestrict(
            string userAgent,
            string action,
            FormUrlEncoded formUrlEncoded, 
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/restrict_action/{action}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL + endPoint , 
                formUrlEncoded.ToString());
            
            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            unityWebRequest.SetRequestHeader("User-Agent" , userAgent);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> getList(
            string userAgent,
            string userId,
            string type,
            QueryParams queryParams,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/friendships/{userId}/{type}/";
            endPoint += queryParams.ToString();
            
            //TODO @QueryMap(encoded = true) 
            
            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL + endPoint );
            
            unityWebRequest.SetRequestHeader("User-Agent" , userAgent);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
    }
}