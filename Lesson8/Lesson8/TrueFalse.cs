using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lesson8
{
    public class TrueFalse
    {
        private string fileName;
        private List<Question> questions;
        public string FileName
        {
            set { fileName = value; }
        }
        public int Count
        {
            get { return questions.Count; }
        }
        public Question this[int index]
        {
            get { return questions[index]; }
        }
        public TrueFalse(string fileName)
        {
            this.FileName = fileName;
            questions = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            questions.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (questions != null && index < questions.Count && index >= 0) questions.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, questions);
            }
        }
        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                questions = (List<Question>)xmlSerializer.Deserialize(stream);
            }
        }
        
    }

}

