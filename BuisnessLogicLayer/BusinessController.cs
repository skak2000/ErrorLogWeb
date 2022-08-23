/// Create by Skak2000
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;

namespace BuisnessLogicLayer
{
    public class BusinessController
    {
        DatabaseController db = new DatabaseController();

        public List<ClsErrorLog> GetErrorList()
        {
            List<ErrorLog> dbValues = db.GetErrorList();
            List<ClsErrorLog> respont = new List<ClsErrorLog>();

            foreach (ErrorLog item in dbValues)
            {
                ClsErrorLog temp = Mapper.ErrorLog(item);
                respont.Add(temp);
            }

            return respont;
        }

        public ErrorLog GetErrorById(Guid input)
        {
            return db.GetErrorById(input);
        }

        public List<ClsMessageLog> GetMessageList()
        {
            List<MessageLog> dbValues = db.GetMessageLogList();
            List<ClsMessageLog> respont = new List<ClsMessageLog>();

            foreach (MessageLog item in dbValues)
            {
                ClsMessageLog temp = Mapper.MessageLog(item);
                respont.Add(temp);
            }

            return respont;
        }

        public MessageLog GetMessageById(Guid input)
        {
            return db.GetMessageLogById(input);
        }

        public void WriteToLog(string applicationName, string message, string source, string stackTrack, string errorLogUrl = null)
        {
            if (applicationName != null && applicationName != string.Empty)
            {
                ErrorLog error = new ErrorLog
                {
                    ApplicationName = applicationName,
                    ErrorLogUrl = errorLogUrl,
                    Message = message,
                    Source = source,
                    StackTrace = stackTrack,
                    ErrorLogID = Guid.NewGuid(),
                    ErrorLogTime = DateTime.Now                    
                };
                db.WriteToLog(error);
            }  
        }

        public void WriteToMessageLog(string applicationName, string message)
        {
            if (applicationName != null && applicationName != string.Empty)
            {
                MessageLog messageLog = new MessageLog
                {
                    ApplicationName = applicationName,
                   MessageLogID = Guid.NewGuid(),
                   Message = message,
                   MessageTime = DateTime.Now
                };
                db.WriteToMessageLog(messageLog);
            }
        }
    }
}
