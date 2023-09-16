using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;

namespace Avtotest.Models
{
    public class Questions
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Question { get; set; }
        public int ChoiceId { get; set; }
        public bool Media { get; set; }
        public string Description { get; set; }

    }

    //public class Choice
    //{
    //    public int Id { get; set; }
    //    public string Text { get; set; }
    //    public bool Answer { get; set; }
    //    public int QuestionsId { get; set; }
    //}
}
