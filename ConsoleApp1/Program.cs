internal class Program
{
    static void Main(string[] args)
    {
        int x, y, z, w;
        Console.Write("Начнем работу , введите характеристики студента; ");
        Console.Write("Введите его здоровье-");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его интеллект-");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его счастье-");
        z = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его знания-");
        w = Convert.ToInt32(Console.ReadLine());
        Student student1 = new Student();
        student1.Health = x;
        student1.Intelligence = y;
        student1.Happiness = z;
        student1.Knowledge = w;
        string order = Console.ReadLine();
        while (order != "Выход")
        {
            string action;

          
            

            Console.WriteLine("Выберете операцию Party(введите a), Study(введите b), VisitedCSharp(введите c)");

            action = Console.ReadLine();
            switch (action)
            {
                case "a":
                    student1.GoToParty();
                    break;
                case "b":
                    student1.Study();
                    break;
                case "c":
                    student1.VisitCSharp();
                    break;
                default:
                                    Console.WriteLine("Не тот символ ,попробуйте снова)");
                    break;

            }

            Console.WriteLine("Продолжить ?Если нет введите:Выход");
            order = Console.ReadLine();
           
        }
    }

        








    internal class Student
    {
        public int Health { get; set; }
        public int Intelligence { get; set; }
        public int Happiness { get; set; }
        public int Knowledge { get; set; }

        public void GoToParty()
        {

            Health -= 10;
            Intelligence -= 10;
            Happiness += 20;
            Knowledge -= 20;
            Console.WriteLine($"Студент сходил на вечеринку! Здоровье ={Health} , Интеллект ={Intelligence}, Счастье {Happiness}, Знания {Knowledge}");

        }
        public void Study()
        {

            Health -= 10;
            Intelligence += 10;
            Happiness -= 20;
            Knowledge += 20;
            Console.WriteLine($"Студент Сделал Дз! Здоровье ={Health} , Интеллект ={Intelligence}, Счастье {Happiness}, Знания {Knowledge}");

        }
        public void VisitCSharp()
        {

            Health += 10;
            Intelligence += 10;
            Happiness += 20;
            Knowledge += 20;

            Console.WriteLine($"Студент сходил на С# в субботу! Здоровье ={Health} , Интеллект ={Intelligence}, Счастье {Happiness}, Знания {Knowledge}");
        }
    }
}



