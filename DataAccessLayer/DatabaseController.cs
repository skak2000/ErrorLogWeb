/// Create by Skak2000
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class DatabaseController
    {
        DatabaseConnection db = new DatabaseConnection();

        public List<ErrorLog> GetErrorList()
        {
            IOrderedQueryable<ErrorLog> query = from b in db.ErrorLog
                                                orderby b.ErrorLogTime descending
                                                select b;
                       
            List<ErrorLog> respont = query.Take(ClsSettings.ShowNumberOfErrors).ToList();
            return respont;
        }

        public void WriteToLog(ErrorLog input)
        {
            db.ErrorLog.Add(input);
            db.SaveChanges();
        }

        public ErrorLog GetErrorById(Guid input)
        {
            ErrorLog respont = db.ErrorLog.FirstOrDefault(x => x.ErrorLogID == input);
            return respont;
        }

       

        public List<MessageLog> GetMessageLogList()
        {
            IOrderedQueryable<MessageLog> query = from b in db.MessageLog
                                                  orderby b.MessageTime descending
                                                  select b;

            List<MessageLog> respont = query.Take(ClsSettings.ShowNumberOfErrors).ToList();
            return respont;
        }

        public void WriteToMessageLog(MessageLog input)
        {
            db.MessageLog.Add(input);
            db.SaveChanges();
        }

        public MessageLog GetMessageLogById(Guid input)
        {
            MessageLog respont = db.MessageLog.FirstOrDefault(x => x.MessageLogID == input);
            return respont;
        }
    }
}
