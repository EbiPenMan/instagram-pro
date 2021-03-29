namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class ErrorModel
    {
        private int code;
        private string message;
        private object data;

        public ErrorModel(int code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public ErrorModel(int code, string message, object data)
        {
            this.code = code;
            this.message = message;
            this.data = data;
        }

        public object Data
        {
            get => data;
        }

        public ErrorModel SetData(object value)
        {
            this.data = value;
            return this;
        }


        public int Code
        {
            get => code;
            set => code = value;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }

        public override string ToString()
        {
            return $" Error[code: {code} - message: {message}] ";
        }
    }
}