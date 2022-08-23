/// Create by Skak2000
using Model;

namespace BuisnessLogicLayer
{
    public static class Mapper
    {
        public static ClsErrorLog ErrorLog(ErrorLog input)
        {
            ClsErrorLog respont = new ClsErrorLog()
            {
                ApplicationName = input.ApplicationName,
                ErrorLogID = input.ErrorLogID,
                StackTrace = input.StackTrace,
                ErrorLogTime = input.ErrorLogTime,
                ErrorLogUrl = input.ErrorLogUrl,
                Message = input.Message,
                Source = input.Source
            };

            return respont;
        }

        public static ClsMessageLog MessageLog(MessageLog item)
        {
            ClsMessageLog respont = new ClsMessageLog()
            {
                ApplicationName = item.ApplicationName,
                Message = item.Message,
                MessageLogID = item.MessageLogID,
                MessageTime = item.MessageTime
            };

            return respont;
        }
    }
}
