using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.Singletons;

namespace ProGraphGroup.InstagramPro.Core.Main
{
    public class MainManager : MonoSingleton <MainManager>
    {
        void Start()
        {
            LoginManager.Instance.Login();
        }

    }
}
