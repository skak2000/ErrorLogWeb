using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ErrorLogWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IErrorLogWS" in both code and config file together.
    [ServiceContract]
    public interface IErrorLogWS
    {
        
        [OperationContract]
        void WriteToLog(string applicationName, string message, string source, string stackTrack, string errorLogUrl);

        [OperationContract]
        void WriteToMessageLog(string applicationName, string message);
    }
}
