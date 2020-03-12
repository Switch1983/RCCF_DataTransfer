using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RCCFLib;
// using RCCFLib.Records;

namespace Data_Transfer_Software__DTS_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DTSService" in code, svc and config file together.
    public class DTSService : IDTSService
    {
        public List<RCCFLib.Records.RecordingSet> GetRecordingSetSeries(int recordingSetId)
        {
            return DataAccess.GetRecordingSetSeries(recordingSetId);
        }

        public List<RCCFLib.Records.RecordingSet> GetRecordingSetSeriesFrom(int recordingSetId, DateTime fromDateTime)
        {
            return DataAccess.GetRecordingSetSeriesFrom(recordingSetId, fromDateTime);
        }

        public List<RCCFLib.Records.RecordingSet> GetRecordingSetSeriesFromTo(int recordingSetId, DateTime fromDateTime, DateTime toDateTime)
        {
            return DataAccess.GetRecordingSetSeriesFromTo(recordingSetId, fromDateTime, toDateTime);
        }

        public RCCFLib.Records.RecordingSet GetLatestReading(int recordingSetId)
        {
            return DataAccess.GetLatestReading(recordingSetId);
        }

        public void AddRecordingSet(RCCFLib.Records.RecordingSet recordingSet)
        {
            DataAccess.AddRecordingSet(recordingSet);
        }
    }
}
