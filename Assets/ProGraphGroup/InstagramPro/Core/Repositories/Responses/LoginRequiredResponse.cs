namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class LoginRequiredResponse
    {
        private string message = "login_required";
        private int logoutReason;
        private string status = "fail";

        public LoginRequiredResponse(in string message, in int logoutReason, in string status)
        {
            this.message = message;
            this.logoutReason = logoutReason;
            this.status = status;
        }

        public virtual string Message
        {
            get
            {
                return message;
            }
        }

        public virtual int LogoutReason
        {
            get
            {
                return logoutReason;
            }
        }

        public virtual string Status
        {
            get
            {
                return status;
            }
        }
    }
}