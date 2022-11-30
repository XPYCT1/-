using static Program;

internal class Program
{
    static Random rnd = new Random();
    static void Main(string[] args)
    {
        int x, y, z, w;
        Console.Write("Начнем работу , введите характеристики покемона Пикачу; ");
        Console.Write("Введите его здоровье-");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его возраст-");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его ловкость-");
        z = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его броню-");
        w = Convert.ToInt32(Console.ReadLine());
        Pokemon Pokemon1 = new Pokemon();
        Pokemon1.Health = x;
        Pokemon1.Age = y;
        Pokemon1.Agility = z;
        Pokemon1.Armor = w;
        int a, b, c, d;
        Console.Write("Начнем работу , введите характеристики покемона Черизард; ");
        Console.Write("Введите его здоровье-");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его возраст-");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его ловкость-");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите его броню-");
        d = Convert.ToInt32(Console.ReadLine());
        Pokemon Pokemon2 = new Pokemon();
        Pokemon2.Health = a;
        Pokemon2.Age = b;
        Pokemon2.Agility = c;
        Pokemon2.Armor = d;

       
        while (Pokemon1.Health > 0 && Pokemon1.Agility > 0 && Pokemon1.Armor > 0 && Pokemon1.Age > 0 && Pokemon2.Health > 0 && Pokemon2.Agility > 0 && Pokemon2.Armor > 0 && Pokemon2.Age > 0)
        {
            string action;

            Console.WriteLine("Выберете,что сделать Пикачу- поймать атаку Черизарда(введите a), Блокировка удара(введите b), Уклониться(введите c)");
            action = Console.ReadLine();
            switch (action)
            {
                case "a":
                    Pokemon1.Attack(Pokemon1);
                    break;
                case "b":
                    Pokemon1.Block(Pokemon1);
                    break;
                case "c":
                    Pokemon1.Evasion(Pokemon1);
                    break;
                default:
                    Console.WriteLine("Не тот символ ,попробуйте снова)");
                    break;

            }
            switch (Pokemon1.Health)
            {
                case < 0:
                    Console.WriteLine("Пикачу проиграл ,попробуйте снова)");
                    break;

            }
            switch (Pokemon1.Agility)
            {
                case < 0:
                    Console.WriteLine("Пикачу проиграл ,попробуйте снова)");
                    break;

            }
            switch (Pokemon1.Armor)
            {
                case < 0:
                    Console.WriteLine("Пикачу проиграл ,попробуйте снова)");
                    break;

            }

            int act = rnd.Next(0, 3);
            if (act == 0)
            {
                Console.WriteLine("Черизард атакует,осторожно");
                Pokemon1.Attack1(Pokemon2);
                
            }
            else if (act ==1)
            {
                Console.WriteLine("Черизард блокирует,его броня ослабла");
                Pokemon1.Block1(Pokemon2);
                
            }
            else if (act == 2)
            {
                Console.WriteLine("Черизард уворачивается,его ловкость уменьшилась)");
                Pokemon1.Evasion1(Pokemon2);
                
            }
          
            switch (Pokemon2.Health)
            {
                case < 0:
                    Console.WriteLine("Черизард проиграл ,попробуйте снова)");
                    break;

            }
            switch (Pokemon2.Agility)
            {
                case < 0:
                    Console.WriteLine("Черизард проиграл ,попробуйте снова)");
                    break;

            }
            switch (Pokemon2.Armor)
            {
                case < 0:
                    Console.WriteLine("Черизард проиграл ,попробуйте снова)");
                    break;

            }
            
            Pokemon1.Get_Old(Pokemon1);
            Pokemon2.Get_Old1(Pokemon2);
            Console.WriteLine($"Покемон Пикачу постарел, Возраст {Pokemon1.Age},");

            Console.WriteLine($"Покемон Черизард постарел, Возраст {Pokemon2.Age},");
            switch (Pokemon1.Age)
            {
                case < 0:
                    Console.WriteLine("Пикачу проиграл ,попробуйте снова)");
                    break;

            }
            
            switch (Pokemon2.Age)
            {
                case < 0:
                    Console.WriteLine("Черизард проиграл ,попробуйте снова)");
                    break;
    
            }

            if (Pokemon1.Age <= 0 )
            {
                Console.WriteLine("Пикачу умер от старости");
               

            }
            else if (Pokemon2.Age <= 0)
            {
                Console.WriteLine("Черизард умер от старости");

            }
           
        }
    }

    internal class Pokemon
    {
        public int Health { get; set; }
        public int Age { get; set; }
        public int Agility { get; set; }
        public int Armor { get; set; }

        public void Attack(Pokemon Pokemon1 )
        {
            Pokemon1.Health -= 10;
            Pokemon1.Armor -= 10;
            Console.WriteLine($"Пикачу получил атаку-здоровье {Pokemon1.Health} , Возраст{Pokemon1.Age}, ловкость {Pokemon1.Agility}, броня {Pokemon1.Armor}");
        }
        public void Block(Pokemon Pokemon1)
        {


            Pokemon1.Armor -= 20;
            Console.WriteLine($"Пикачу заблокировал-здоровье {Pokemon1.Health} , Возраст{Pokemon1.Age}, ловкость {Pokemon1.Agility}, броня {Pokemon1.Armor}");
        }
        public void Evasion(Pokemon Pokemon1)
        {

            Pokemon1.Agility -= 20;

            Console.WriteLine($"Пикачу уклонился-здоровье {Pokemon1.Health} , Возраст{Pokemon1.Age}, ловкость {Pokemon1.Agility}, броня {Pokemon1.Armor}");
        }
        public void Attack1(Pokemon Pokemon2)
        {
            Pokemon2.Health -= 10;
            Pokemon2.Armor -= 10;
            Console.WriteLine($"Черизарда ударили-здоровье {Pokemon2.Health} , Возраст{Pokemon2.Age}, ловкость {Pokemon2.Agility}, броня {Pokemon2.Armor}");
        }
        public void Block1(Pokemon Pokemon2)
        {


            Pokemon2.Armor -= 20;
            Console.WriteLine($"Черизард заблокировал-здоровье {Pokemon2.Health} , Возраст{Pokemon2.Age}, ловкость {Pokemon2.Agility}, броня {Pokemon2.Armor}");
        }
        public void Evasion1(Pokemon Pokemon2)
        {

            Pokemon2.Agility -= 20;

            Console.WriteLine($"Черизард уклонился-здоровье {Pokemon2.Health} , Возраст{Pokemon2.Age}, ловкость {Pokemon2.Agility}, броня {Pokemon2.Armor}");
        }
        public void Get_Old1(Pokemon Pokemon2 )
        {
          
            Pokemon2.Age -= 1;
        }
        public void Get_Old(Pokemon Pokemon1)
        {

            Pokemon1.Age -= 1;
        }
    }
}