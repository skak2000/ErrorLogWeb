using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ErrorLogWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ErrorLogWS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ErrorLogWS.svc or ErrorLogWS.svc.cs at the Solution Explorer and start debugging.
    public class ErrorLogWS : IErrorLogWS
    {
        BusinessController bc = new BusinessController();

        public void WriteToLog(string applicationName, string message, string source, string stackTrack, string errorLogUrl)
        {
            bc.WriteToLog(applicationName, message, source, stackTrack, errorLogUrl);
        }

        public void WriteToMessageLog(string applicationName, string message)
        {
            bc.WriteToMessageLog(applicationName, message);
        }
    }
}
