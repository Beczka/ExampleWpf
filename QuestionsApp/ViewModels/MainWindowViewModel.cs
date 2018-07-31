using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

using Prism.Mvvm;

using QuestionsApp.Models.Answers;

namespace QuestionsApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Question _selectedQuestion;
        private string _title = "Test";
        private string _xml = "<Questions><Question><Text>What is the capital city of England:</Text><Answers><Answer >Birmingham</Answer><Answer >Brighton</Answer><Answer IsCorrect='true'>London</Answer><Answer >Manchester</Answer></Answers></Question><Question><Text>What is the capital city of Switzerland:</Text><Answers><Answer IsCorrect='true'>Bern</Answer><Answer >Chur</Answer><Answer >Lucerne</Answer><Answer >Zurich</Answer></Answers></Question></Questions>";
        private ObservableCollection<Question> _questions = new ObservableCollection<Question>();


        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableCollection<Question> Questions
        {
            get => _questions;
            set
            {
                if (value != _questions)
                {
                    _questions = value;
                    RaisePropertyChanged(nameof(Questions));
                }
            }
        }

        public Question SelectedQuestion
        {
            get => _selectedQuestion;
            set
            {
                if (value != _selectedQuestion)
                {
                    _selectedQuestion = value;
                    RaisePropertyChanged(nameof(SelectedQuestion));
                }
            }
        }

        public MainWindowViewModel()
        {
            var data = GetData();

            Questions.AddRange(data.Question);
        }

        private Questions GetData()
        {
            var serializer = new XmlSerializer(typeof(Questions));
            Questions result;
            using (TextReader reader = new StringReader(_xml))
            {
                result = (Questions)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
