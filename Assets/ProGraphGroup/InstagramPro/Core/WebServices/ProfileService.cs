using System;
using Newtonsoft.Json;
using ProGraphGroup.InstagramPro.Core.Main;
using ProGraphGroup.InstagramPro.Core.Repositories;
using ProGraphGroup.InstagramPro.Core.Repositories.Responses;
using ProGraphGroup.Manager;
using ProGraphGroup.Singletons;

namespace ProGraphGroup.InstagramPro.Core.WebServices
{
    public class ProfileService : Singleton<ProfileService>
    {
        private readonly ProfileRepository repository = new ProfileRepository();


        public virtual void getUserInfo(string uid, ServiceCallback<UserInfoResponse> callback)
        {
            repository.getUserInfo(uid, response =>
            {
                LogManager.Instance.debug("response" ,response);
                string body = response;
                if (body == null) callback.onFailure(ErrorConst.NULL_DATA);
                try
                {
                    UserInfoResponse userInfoResponse = JsonConvert.DeserializeObject<UserInfoResponse>(body);
                    if(!userInfoResponse.Status.ToLower().Equals("ok"))
                        callback.onFailure(ErrorConst.STATUS_NOT_OK);
                    callback.onSuccess(userInfoResponse);
                }
                catch (Exception e)
                {
                    callback.onFailure(ErrorConst.EXP_PARS.SetData(response));
                }
            });
        }

    }
}