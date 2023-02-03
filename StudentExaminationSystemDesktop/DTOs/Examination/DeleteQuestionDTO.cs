using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.DTOs.Examination
{
    public class DeleteQuestionDTO
    {
        public Guid GroupId { get; set; }
        public Guid QuestionId { get; set; }
    }
}
