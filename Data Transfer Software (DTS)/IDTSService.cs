using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RCCFLib;

namespace Data_Transfer_Software__DTS_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDTSService" in both code and config file together.
    [ServiceContract]
    public interface IDTSService
    {
        [OperationContract]
        List<RCCFLib.Records.RecordingSet> GetRecordingSetSeries(int recordingSetId);

        [OperationContract]
        List<RCCFLib.Records.RecordingSet> GetRecordingSetSeriesFrom(int recordingSetId, DateTime fromDateTime);

        [OperationContract]
        List<RCCFLib.Records.RecordingSet> GetRecordingSetSeriesFromTo(int recordingSetId, DateTime fromDateTime, DateTime toDateTime);

        [OperationContract]
        RCCFLib.Records.RecordingSet GetLatestReading(int recordingSetId);

        [OperationContract]
        void AddRecordingSet(RCCFLib.Records.RecordingSet recordingSet);
    }
}
