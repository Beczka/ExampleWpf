using System.Xml.Serialization;

namespace QuestionsApp.Models.Answers
{
    [XmlRoot(ElementName = "Question")]
    public class Question
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
        [XmlElement(ElementName = "Answers")]
        public Models.Answers.Answers Answers { get; set; }
    }
}