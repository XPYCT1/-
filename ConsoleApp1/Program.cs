internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Clear();
            string action;
            char a,b,c;
           
            Student student1 = new Student();
            student1.Health = 100;
            student1.Intelligence = 100;
            student1.Happiness = 100;
            student1.Knowledge = 100;
            Console.WriteLine("Вот ваш студент Павел,все характеристики по 100 ");
               
                Console.WriteLine("Выберете операцию Party(введите a), Study(введите b), VisitedCSharp(введите c)");
               
                action = Console.ReadLine();
                
                switch (action)
                {
                    case "a":
                        student1.Party();

                        break;
                    case "b":
                        student1.Study();

                        break;
                    case "c":
                        student1.VisitedCSharp();

                        break;
                }
            }
 catch (Exception)
                    {
                
                Console.ReadLine();
                continue;
            }
            Console.ReadLine();
        }

            
    }



    internal class Student
    {
        public int Health;
        public int Intelligence;
        public int Happiness;
        public int Knowledge;

        public void Party()
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
        public void VisitedCSharp()
        {

            Health += 10;
            Intelligence += 10;
            Happiness += 20;
            Knowledge += 20;

            Console.WriteLine($"Студент сходил на С# в субботу! Здоровье ={Health} , Интеллект ={Intelligence}, Счастье {Happiness}, Знания {Knowledge}");
        }
    }
}
