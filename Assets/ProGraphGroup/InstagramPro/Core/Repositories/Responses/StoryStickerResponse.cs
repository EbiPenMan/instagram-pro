namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class StoryStickerResponse
    {
        private readonly string status;

        public StoryStickerResponse(in string status)
        {
            this.status = status;
        }

        public virtual string Status
        {
            get { return status; }
        }

        public override string ToString()
        {
            return "StoryStickerResponse{" + "status='" + status + '\'' + '}';
        }
    }
}