/// Create by Skak2000
namespace Model
{
    public class ClsErrorLog
    {
        public System.Guid ErrorLogID { get; set; }
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string ErrorLogUrl { get; set; }
        public System.DateTime ErrorLogTime { get; set; }
               

        public string StackTraceShort 
        { 
            get { return ClsHelpers.ShortText(StackTrace); }
        }
    }
}
