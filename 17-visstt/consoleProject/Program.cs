namespace consoleProject
{
    /*
     * ФИО студента: Скоморохов Егор Константинович
     * номер варианта: 20
     * условие задачи (скопировать из листа задания): Создать класс Subject описывающий предмет для изучения как сущность в приложении
     */
    using System;
    using System.Collections.Generic;

    namespace consoleProject
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ISubject subject1 = new SubjectImplementation("Основы алгоритмизации и программирования", 120, ControlType.Exam);
                subject1.PrintInfo();
                Console.WriteLine();
                ISubject subject2 = new SubjectImplementation("Мдк 04.02", 150, ControlType.Exam);
                subject2.PrintInfo();
                Console.WriteLine();
                ISubject subject3 = new SubjectImplementation("Физическая культура", 70, ControlType.Test);
                subject3.PrintInfo();

                Console.WriteLine();
                Console.WriteLine("Функционал IClonable");
                Console.WriteLine();

                ISubject subject4 = (ISubject)subject1.Clone();
                subject4.PrintInfo();

                Console.WriteLine();
                Console.WriteLine("Функционал IComparable");
                Console.WriteLine();

                List<ISubject> subjects = new List<ISubject>
            {
                new SubjectImplementation("Основы алгоритмизации и программирования", 120, ControlType.Exam),
                new SubjectImplementation("Мдк 04.02", 150, ControlType.Exam),
                new SubjectImplementation("Физическая культура", 70, ControlType.Test),
                new SubjectImplementation("Математика", 100, ControlType.Exam),
                new SubjectImplementation("Информатика", 130, ControlType.Exam),
                new SubjectImplementation("Литература", 80, ControlType.Test),
                new SubjectImplementation("История", 90, ControlType.Exam),
                new SubjectImplementation("Физика", 110, ControlType.Exam),
                new SubjectImplementation("Химия", 140, ControlType.Exam),
                new SubjectImplementation("Биология", 105, ControlType.Test)
            };

                subjects.Sort();
                Console.WriteLine("Сортированный список:");
                foreach (var subject in subjects)
                {
                    subject.PrintInfo();
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Функционал IDisposable");
                Console.WriteLine();

                using (ISubject subject = new SubjectImplementation("Пример предмета", 50, ControlType.Exam))
                {
                    subject.PrintInfo();
                }
            }
        }
    }
}