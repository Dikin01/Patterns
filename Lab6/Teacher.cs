using System;
using System.Collections.Generic;

namespace Lab6
{
    public class Teacher : IObserver
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public Dictionary<string, bool> Performance { get; set; }

        public Teacher(string name = "Иван")
        {
            Name = name;
            Department = null;
            Performance = new Dictionary<string, bool>();
        }

        public Teacher(string name, Department department)
        {
            Name = name;
            Department = department;
            Performance = new Dictionary<string, bool>();
        }

        public void BaseInitialPerfomance()
        {
            for (int i = 0; i < 3; i++)
                Performance.Add($"Предмет-{i}", false);
        }

        public void FillAllPerfomance()
        {
            foreach(string name in Performance.Keys)
                Performance[name] = true;
        }
        
        public string GivePerfomance()
        {
            string result = "";
            foreach(var item in Performance)
            {
                if(item.Value == false)
                {
                    result += $"{Name} из {Department?.Name} не подготовил успеваемость" +
                        $" по {item.Key}\n";
                }

                Performance[item.Key] = false;
            }
            return result;
        }
    }
}
