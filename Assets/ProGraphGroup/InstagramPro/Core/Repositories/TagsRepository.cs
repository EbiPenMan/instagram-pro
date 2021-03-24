using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class TagsRepository
    {
        
        async UniTask<string> follow(
            string tag,
            Action<string> onDone)
        {
            string endPoint = $"/web/tags/follow/{tag}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint ,"");
            
            unityWebRequest.SetRequestHeader("User-Agent" , Constants.USER_AGENT);
            unityWebRequest.SetRequestHeader("x-csrftoken" , LoginManager.Instance.GetCurrentCookie().Csrftoken);

            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> unfollow(
            string tag,
            Action<string> onDone)
        {
            string endPoint = $"/web/tags/unfollow/{tag}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint ,"");
            
            unityWebRequest.SetRequestHeader("User-Agent" , Constants.USER_AGENT);
            unityWebRequest.SetRequestHeader("x-csrftoken" , LoginManager.Instance.GetCurrentCookie().Csrftoken);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }

        
        async UniTask<string> fetchPosts( string tag,
            QueryParams queryParams, Action<string> onDone)
        {
            string endPoint = $"/api/v1/feed/tag/{tag}/";
            endPoint += queryParams.ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
    }
}