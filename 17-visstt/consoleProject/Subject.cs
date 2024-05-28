using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    enum ControlType { Exam, Test }

    // Интерфейс ISubject
    public interface ISubject : ICloneable, IComparable<ISubject>, IDisposable
    {
        string Title { get; set; }
        int Duration { get; set; }


        void PrintInfo();
        void RegisterSubject();
        void RemoveSubject();
    }

    // Реализация интерфейса ISubject
    internal class SubjectImplementation : ISubject
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public ControlType ControlType { get; set; }

        public SubjectImplementation(string title, int duration, ControlType controlType)
        {
            this.Title = title;
            this.Duration = duration;
            this.ControlType = controlType;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Название предмета: {Title} \n" +
                $"Продолжительность в часах: {Duration} \n" +
                $"Вид экзамена: {ControlType}");
        }

        public void RegisterSubject()
        {
            Console.WriteLine($"Предмет '{Title}' был зарегистрирован.");
        }

        public void RemoveSubject()
        {
            Console.WriteLine($"Предмет '{Title}' был удален.");
        }

        public object Clone()
        {
            return new SubjectImplementation(this.Title, this.Duration, this.ControlType);
        }

        public int CompareTo(ISubject other)
        {
            if (other == null) return 1;
            return this.Duration.CompareTo(other.Duration);
        }

        public void Dispose()
        {
            Console.WriteLine($"Ресурсы предмета '{Title}' были освобождены.");
        }
    }
}
