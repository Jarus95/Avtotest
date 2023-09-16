using Avtotest.Data;
using Avtotest.Models;
using Avtotest.Models.Json;
using Newtonsoft.Json;

namespace Avtotest.Repository
{
    public class JsonRepostiory
    {
        public AvtoTestDbContext dbContext;
       
        string path = "JsonData/uzlotin.json";

        public JsonRepostiory(AvtoTestDbContext dbContext)
        {
            this.dbContext = dbContext;
            DeserializeFromJson();
        }


        public void DeserializeFromJson()
        {
            string json = File.ReadAllText(path);
            StaticValues.questions = JsonConvert.DeserializeObject<List<QuestionsToJson>>(json);
        }

        public int GetQuestionsCount()
        {
            return StaticValues.questions.Count();
        }
    }
}
