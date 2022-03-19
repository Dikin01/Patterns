using System;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeanOffice deanOffice = new DeanOffice();

            Department department = new Department("Права");

            //Подписка Observer на Notify Observable, для Фёдорова нужно Add использовать с этим же кодом
            deanOffice.CollectReport += department.GivePerfomance;

            department.BaseInitTeachers();
            department.FillAllPerfomance();            

            Console.WriteLine("Первая неделя");
            Console.WriteLine(deanOffice.NextWeek());

            Console.WriteLine("\nВторая неделя");
            Console.WriteLine(deanOffice.NextWeek());

            department.FillAllPerfomance();
            Teacher newTeacher = new Teacher("Николай", department);
            newTeacher.BaseInitialPerfomance();
            department.teachers.Add(newTeacher);
            department.teachers.Remove(newTeacher);

            Console.WriteLine("\nТретья неделя");
            Console.WriteLine(deanOffice.NextWeek());

        }
    }
}
