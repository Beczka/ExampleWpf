using System.Xml.Serialization;

namespace QuestionsApp.Models.Answers
{
    [XmlRoot(ElementName = "Answer")]
    public class Answer
    {
        [XmlAttribute(AttributeName = "IsCorrect")]
        public bool IsCorrect { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}