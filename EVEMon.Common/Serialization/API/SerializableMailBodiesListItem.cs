﻿using System.Xml;
using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.API
{
    public sealed class SerializableMailBodiesListItem
    {
        [XmlAttribute("messageID")]
        public long MessageID
        {
            get;
            set;
        }

        [XmlElement("messageText")]
        public XmlCDataSection MessageTextXml
        {
            get { return new XmlDocument().CreateCDataSection(MessageText); }
            set { MessageText = value.Data; }
        }

        [XmlIgnore]
        public string MessageText
        {
            get;
            set;
        }
    }
}