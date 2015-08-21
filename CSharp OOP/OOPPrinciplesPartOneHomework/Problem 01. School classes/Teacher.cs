using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher : Person, IComment
    {
        // Field
        private List<Discipline> disciplines;
        // Constructor
        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : base(firstName, lastName)
        {
            this.Disciplines = disciplines;
        }
        // Property
        public List<Discipline> Disciplines 
        { 
            get
            {
                return new List<Discipline>(this.disciplines);
            }
            private set
            {
                this.disciplines = value;
            }
        }
        // Method
        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
        // ToString() override
        public override string ToString()
        {
            var result = new List<string>();
            foreach (var discipline in Disciplines)
            {
                result.Add(discipline.Name);
            }
            return string.Format("Teacher: {0}\nDisciplines: {1}", FirstName + " " + LastName, string.Join(", ", result.ToArray()));
        }
    }
}
