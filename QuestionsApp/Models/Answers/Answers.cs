using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuestionsApp.Models.Answers
{
    [XmlRoot(ElementName = "Answers")]
    public class Answers
    {
        [XmlElement(ElementName = "Answer")]
        public List<Answer> Answer { get; set; }
    }
}