using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class StoriesRepository
    {
        async UniTask<string> fetch(string mediaId, Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/info/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> getFeedStories(Action<string> onDone)
        {
            string endPoint = $"/api/v1/feed/reels_tray/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> fetchHighlights(string uid, Action<string> onDone)
        {
            string endPoint = $"/api/v1/highlights/{uid}/highlights_tray/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }

        
        async UniTask<string> fetchArchive(QueryParams queryParams, Action<string> onDone)
        {
            string endPoint = $"/api/v1/archive/reel/day_shells/";
            endPoint += queryParams.ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> getUserStory(
            string userAgent,
            string url,
            Action<string> onDone)
        {

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(url);
            
            unityWebRequest.SetRequestHeader("User-Agent" , userAgent);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> respondToSticker(
            string userAgent,
            string storyId,
            string stickerId,
            string action,
            FormUrlEncoded formUrlEncoded, 
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{storyId}/{stickerId}/{action}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint , 
                formUrlEncoded.ToString());
            
            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            unityWebRequest.SetRequestHeader("User-Agent" , userAgent);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);
            
            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
    }
}