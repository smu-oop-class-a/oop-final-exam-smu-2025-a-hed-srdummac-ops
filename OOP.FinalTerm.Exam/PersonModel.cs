using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace OOP.FinalTerm.Exam
{
    public class PersonModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genres { get; set; }
        public string numTotalMovies { get; set; }

    }
}
