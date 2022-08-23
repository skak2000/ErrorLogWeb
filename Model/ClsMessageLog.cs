/// Create by Skak2000
namespace Model
{
    public class ClsMessageLog
    {
        public System.Guid MessageLogID { get; set; }
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public System.DateTime MessageTime { get; set; }

        public string MessageShort
        {
            get { return ClsHelpers.ShortText(Message); }
        }
    }
}
