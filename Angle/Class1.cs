namespace Angle;

public class Angle
{
    double gradus;
    double min;
    double sec;
    bool isCorrect=true;

    public double Gradus
    {
        get
        {
            return gradus;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Значение некорректно!");
                isCorrect = false;

            }

            else gradus = value;
        }
    }
    public double Min
    {
        get
        {
            return min;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Значение некорректно!");
                isCorrect = false;

            }

            else min = value;
        }
    }
    public double Sec
    {
        get
        {
            return sec;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Значение некорректно!");
                isCorrect = false;

            }

            else sec = value;
        }
    }

    public Angle (int gradus, int min, int sec)
    {
        this.Gradus = gradus;
        this.Min = min;
        this.Sec = sec;
 
    }
    public double ToRadian(int gradus, int min, int sec)
    {
        return gradus * (Math.PI / 180)+(min/60)/(Math.PI / 180)+ (sec / 3600) / (Math.PI / 180);
    }

    
}



