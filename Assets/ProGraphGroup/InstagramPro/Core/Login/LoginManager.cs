using System.Collections;
using Cysharp.Threading.Tasks;
using ProGraphGroup.InstagramPro.Core.Model;
using ProGraphGroup.Singletons;
using ProGraphGroup.Utility;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

namespace ProGraphGroup.InstagramPro.Core.Login
{
    public class LoginManager : Singleton<LoginManager>
    {
        public string url = "https://instagram.com/";
        private WebViewObject _webViewObject;
        private Cookie _currentCookie;
        CompositeDisposable disposables = new CompositeDisposable();

        public void Login()
        {
            //TODO check old cookie

            saveCookie(
                "ig_did=769417AD-CB07-4366-94A9-58F394338F78; ig_nrcb=1; mid=YFoMOQABAAHovZcQYAy9Ijnmue8A; csrftoken=GlfMLRGrTNVqEb40skZ8jR6VYijQqsr6; rur=FTW; ds_user_id=1723592186; sessionid=1723592186%3AVSj0UslkcisAYA%3A15");


            _currentCookie = loadCookie();

            if (_currentCookie != null)
            {
                Debug.Log("[LoginManager][Login()] - login OK!");
                getUserInfo();
            }
            else
            {
                //TODO login webview
                Observable.EveryUpdate().Subscribe(x =>
                {
                    string cookie = _webViewObject.GetCookies(url);
                    if (checkCookie(cookie))
                    {
                        Debug.Log(cookie);
                        onGetCookie(cookie);
                        disposables.Clear();
                    }
                }).AddTo(disposables);
                initAndShowWebView();
            }
        }

        async UniTask getUserInfo()
        {
            Debug.Log("[LoginManager][getUserInfo()] - DsUserId: " + _currentCookie.DsUserId);
            UnityWebRequest getUserInfoReq =
                UnityWebRequest.Get($"https://i.instagram.com/api/v1/users/{_currentCookie.DsUserId}/info/");
            getUserInfoReq.SetRequestHeader("User-Agent",
                "Mozilla/5.0 (iPhone; CPU iPhone OS 12_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148 Instagram 105.0.0.11.118 (iPhone11,8; iOS 12_3_1; en_US; en-US; scale=2.00; 828x1792; 165586599)");

            var userInfo = (await getUserInfoReq.SendWebRequest()).downloadHandler.text;
            Debug.Log("[LoginManager][getUserInfo()] - userInfo: " + userInfo);
        }

        private void onGetCookie(string cookie)
        {
            saveCookie(cookie);
            destroyWebView();
            Login();
        }

        private void destroyWebView()
        {
            var g = GameObject.Find("WebViewObject");
            if (g != null)
            {
                Object.Destroy(g);
            }
        }

        private void initAndShowWebView()
        {
            destroyWebView();
            _webViewObject = (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
            _webViewObject.Init(
                cb: (msg) => { Debug.Log($"CallOnCB[{msg}]"); },
                err: (msg) => { Debug.Log($"CallOnError[{msg}]"); },
                started: (msg) => { Debug.Log($"CallOnStarted[{msg}]"); },
                hooked: (msg) => { Debug.Log($"CallOnHooked[{msg}]"); },
                ld: (msg) => { Debug.Log($"CallOnLoaded[{msg}]"); },
                enableWKWebView: true);

            _webViewObject.SetMargins(0, 0, 0, 0);
            _webViewObject.SetVisibility(true);
            _webViewObject.LoadURL(url.Replace(" ", "%20"));
        }


        private Cookie loadCookie()
        {
            if (!PlayerPrefs.HasKey("cookie"))
                return null;

            string cookie = PlayerPrefs.GetString("cookie");

            return createCookie(cookie);
        }

        private Cookie saveCookie(string cookie)
        {
            PlayerPrefs.SetString("cookie", cookie);
            PlayerPrefs.Save();
            return loadCookie();
        }

        private Cookie createCookie(string cookie)
        {
            return !checkCookie(cookie) ? null : new Cookie(cookie);
        }

        private bool checkCookie(string cookie)
        {
            return !TextUtils.isEmpty(cookie) && cookie.Contains("; ds_user_id=");
        }

        public Cookie GetCurrentCookie()
        {
            return _currentCookie;
        }
    }
}