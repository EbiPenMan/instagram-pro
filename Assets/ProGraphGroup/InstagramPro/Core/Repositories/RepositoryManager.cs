using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.Manager;
using ProGraphGroup.Singletons;
using UnityEngine.Networking;

namespace ProGraphGroup.InstagramPro.Core.Repositories
{
    public class RepositoryManager : Singleton<RepositoryManager>
    {
        public void AddCookiesInterceptor(ref UnityWebRequest unityWebRequest)
        {
            unityWebRequest.SetRequestHeader("Cookie", LoginManager.Instance.GetCurrentCookie().ToString());

            if (unityWebRequest.GetRequestHeader("User-Agent") == null ||
                unityWebRequest.GetRequestHeader("User-Agent") == "")
            {
                unityWebRequest.SetRequestHeader("User-Agent", Constants.I_USER_AGENT);
            }

            if (unityWebRequest.GetRequestHeader("Accept-Language") == null ||
                unityWebRequest.GetRequestHeader("Accept-Language") == "")
            {
                unityWebRequest.SetRequestHeader("Accept-Language", MultiLanguage.Instance.GetCurrentLanguageCodeName()
                                                                    + ",en-US;q=0.8");
            }
        }
    }
}