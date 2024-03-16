
namespace Task1;
//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут,
//sec - угловых секунд. Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных.
//Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
//Создать объект на основе разработанного класса.
//Осуществить использование объекта в программе.
class Program
{
    static void Main(string[] args)
    {
        Angle angle;
        do
        {
            Console.WriteLine("Введите градусы");
            double gr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            double s = Convert.ToDouble(Console.ReadLine());

            angle = new Angle(gr, m, s);
        }
        while (angle.isCorrect == false);

        double all_in_rad = angle.ToRadian();
        Console.WriteLine($"В угле {all_in_rad} радиан");
        Console.ReadKey();

       


        
        
    }
}

