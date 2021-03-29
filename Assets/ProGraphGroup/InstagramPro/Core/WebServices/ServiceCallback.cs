using System;
using ProGraphGroup.InstagramPro.Core.Model;

namespace ProGraphGroup.InstagramPro.Core.WebServices
{
    public  class ServiceCallback<T>
    {

        public Action<T> onSuccess;
        public Action<ErrorModel> onFailure;

        public ServiceCallback(Action<T> onSuccess, Action<ErrorModel> onFailure)
        {
            this.onSuccess = onSuccess;
            this.onFailure = onFailure;
        }
    }
}