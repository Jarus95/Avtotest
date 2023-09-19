using Avtotest.Data;
using Avtotest.Models;
using Avtotest.Models.Json;
using Newtonsoft.Json;

namespace Avtotest.Repository
{
    public class JsonRepostiory
    {      
        public int QuestionCountOnTicket { get; set; } = 10;
       
        string path = "JsonData/uzlotin.json";

        public JsonRepostiory()
        {
            DeserializeFromJson();
        }


        public void DeserializeFromJson()
        {
            string json = File.ReadAllText(path);
            StaticValues.questions = JsonConvert.DeserializeObject<List<QuestionsToJson>>(json);
        }

        public int GetTicketCount()
        {
            return StaticValues.questions.Count() / QuestionCountOnTicket;
        }
        public int GetAllQuestionsCount()
        {
            return StaticValues.questions.Count();
        }
    }
}
