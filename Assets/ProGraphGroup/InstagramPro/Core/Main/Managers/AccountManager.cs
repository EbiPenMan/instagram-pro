using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.Singletons;
using ProGraphGroup.Utility;
using UnityEngine.UI;

namespace ProGraphGroup.InstagramPro.Core.Main.Managers
{
    public class MainManager : MonoSingleton <MainManager>
    {

        public Text txt_name;
        public LoadImage imgLoad_pic;
        
        void Start()
        {
            LoginManager.Instance.Login(
                () =>
                {
                    imgLoad_pic.GetSprite(LoginManager.Instance.myUserInfoResponse.User.ProfilePicUrl , true);
                    txt_name.text = LoginManager.Instance.myUserInfoResponse.User.FullName;
                }
                );
        }

    }
}
