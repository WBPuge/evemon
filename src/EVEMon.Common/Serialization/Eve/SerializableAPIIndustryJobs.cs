using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Eve
{
    /// <summary>
    /// Represents a serializable version of industry jobs. Used for querying CCP.
    /// </summary>
    public sealed class SerializableAPIIndustryJobs
    {
        private readonly Collection<SerializableJobListItem> m_jobs;

        public SerializableAPIIndustryJobs()
        {
            m_jobs = new Collection<SerializableJobListItem>();
        }

        [XmlArray("jobs")]
        [XmlArrayItem("job")]
        public Collection<SerializableJobListItem> Jobs => m_jobs;
    }
}