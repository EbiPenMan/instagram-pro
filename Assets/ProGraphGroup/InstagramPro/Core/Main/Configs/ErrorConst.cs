using ProGraphGroup.InstagramPro.Core.Model;

namespace ProGraphGroup.InstagramPro.Core.Main
{
    public class ErrorConst
    {
        public static readonly ErrorModel NULL_DATA = new ErrorModel(1001, "Data is Null");
        public static readonly ErrorModel EXP_PARS = new ErrorModel(1002, "Exception on parsing data");
        public static readonly ErrorModel NOT_FOUND_FIELD = new ErrorModel(1003, "Not Found Field");
        public static readonly ErrorModel STATUS_NOT_OK = new ErrorModel(1004, "Response Status not OK");


    }
}