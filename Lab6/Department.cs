using System.Collections.Generic;

namespace Lab6
{
    public class Department : IObserver
    {
        public string Name { get; set; }
        public List<IObserver> teachers { get; set; }

        public Department(string name = "ВМ-1")
        {
            Name = name;
            teachers = new List<IObserver>();
        }

        public void BaseInitTeachers()
        {
            Teacher teacher1 = new Teacher("Дмитрий", this);
            teacher1.BaseInitialPerfomance();
            Teacher teacher2 = new Teacher("Кирилл", this);
            teacher2.BaseInitialPerfomance();
            Teacher teacher3 = new Teacher("Игорь", this);
            teacher3.BaseInitialPerfomance();

            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
        }

        public void FillAllPerfomance()
        {
            foreach (Teacher teacher in teachers)
                teacher.FillAllPerfomance();
        }

        public string GivePerfomance()
        {
            string result = "";
            foreach (var item in teachers)
            {
                string teacherResult = item.GivePerfomance();
                result += teacherResult;
                if (teacherResult.Equals("") == false)
                    result += "\n\n";
            }
            return result;
        }
    }
}
