using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuestionsApp.Models.Answers
{
    [XmlRoot(ElementName = "Questions")]
    public class Questions
    {
        [XmlElement(ElementName = "Question")]
        public List<Question> Question { get; set; }
    }
}
