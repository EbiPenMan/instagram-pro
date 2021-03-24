using System;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class MediaRepository
    {
        async UniTask<string> fetch(
            string mediaId,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/info/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }

        async UniTask<string> fetchLikes(
            string mediaId,
            string action,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/{action}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }


        async UniTask<string> action(
            string mediaId,
            string action,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/{action}/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> comment(
            string mediaId,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/comment/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> commentsBulkDelete(
            string mediaId,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/comment/bulk_delete/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> commentLike(
            string commentId,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{commentId}/comment_like/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> commentUnlike(
            string commentId,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{commentId}/comment_unlike/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> editCaption(
            string mediaId,
            FormUrlEncoded formUrlEncoded,
            Action<string> onDone)
        {
            string endPoint = $"/api/v1/media/{mediaId}/edit_media/";

            UnityWebRequest unityWebRequest = UnityWebRequest.Put(Constants.BASE_URL_I + endPoint,
                formUrlEncoded.ToString());

            unityWebRequest.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
        
        async UniTask<string> translate(QueryParams queryParams, Action<string> onDone)
        {
            string endPoint = $"/api/v1/language/translate/";
            endPoint += queryParams.ToString();

            UnityWebRequest unityWebRequest = UnityWebRequest.Get(Constants.BASE_URL_I + endPoint);
            
            RepositoryManager.Instance.AddCookiesInterceptor(ref unityWebRequest);

            var op = await unityWebRequest.SendWebRequest();
            onDone.Invoke(op.downloadHandler.text);
            return op.downloadHandler.text;
        }
    }
}