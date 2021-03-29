using System.Collections.Generic;
using ProGraphGroup.InstagramPro.Core.Login;
using ProGraphGroup.InstagramPro.Core.Model;
using ProGraphGroup.Singletons;
using ProGraphGroup.Utility;
using UnityEngine.UI;

namespace ProGraphGroup.InstagramPro.Core.Main.Managers
{
    public class AccountManager : Singleton <AccountManager>
    {

        public bool isLoadedAccounts = false;
        public List<Account> accounts = new List<Account>();
        
        
        public void LoadAllAccounts()
        {
            
        }
   
        public void SaveAccount(Account account)
        {
            
        }

        public void RemoveAccount(Account account)
        {
            
        }
        
        public void RemoveAllAccount()
        {
            
        }
    }

   
}
