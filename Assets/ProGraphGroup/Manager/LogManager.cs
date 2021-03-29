using ProGraphGroup.Singletons;

namespace ProGraphGroup.Manager
{
    public class MultiLanguage : Singleton<MultiLanguage>
    {
        public string GetCurrentLanguageCodeName()
        {
            return "en";
        }
    }
}