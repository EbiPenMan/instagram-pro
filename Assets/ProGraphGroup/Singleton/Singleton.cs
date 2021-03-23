using UnityEngine;

namespace ProGraphGroup.Singleton
{
    /// <summary>
    /// Inherit from this base class to create a singleton.
    /// e.g. public class MyClassName : Singleton<MyClassName> {}
    /// </summary>
    public class Singleton<T>  where T : class, new()
    {
        private static T m_Instance;
 
        /// <summary>
        /// Access singleton instance through this propriety.
        /// </summary>
        public static T Instance
        {
            get
            {
                    if (m_Instance == null)
                    {
                        m_Instance = new T();
                    }
                    return m_Instance;
            }
        }

    }
}