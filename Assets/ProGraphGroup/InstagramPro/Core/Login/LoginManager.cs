using System.Collections;
using ProGraphGroup.InstagramPro.Core.Model;
using ProGraphGroup.Singletons;
using ProGraphGroup.Utility;
using UnityEngine;
using UnityEngine.Serialization;

namespace ProGraphGroup.InstagramPro.Core.Login
{
    public class LoginManager : Singleton<LoginManager>
    {
        public string url;
        private WebViewObject _webViewObject;
        private Cookie _currentCookie;
        
        public void Login()
        {
            //TODO check old cookie
            if (checkCookie())
            {
                
            }
            else
            {
                //TODO login webview
                initAndShowWebView();
                
            }
        }

        private void initAndShowWebView()
        {
            var g = GameObject.Find("WebViewObject");
            if (g != null)
            {
                Object.Destroy(g);
            }
            
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


        private bool checkCookie()
        {
            if (!PlayerPrefs.HasKey("cookie"))
                return false;

            string cookie = PlayerPrefs.GetString("cookie");

            _currentCookie = new Cookie(cookie);
            
            return !TextUtils.isEmpty(cookie) && cookie.Contains("; ds_user_id=");
        }
    }
}