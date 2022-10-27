using System;

class Program
{
    private static DataPerson[] _persons;
    private static IPerson _sotrudnik;

    public static int InputInt(string str = "")
    {
        Console.WriteLine(str);

        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Console.Write("Вы вошли как глава банка\nУстановите количество клиентов: ");

        CreatKlient(InputInt());

        while (true)
        {
            _sotrudnik = CreatWorker();

            Console.Write("Выберите номер клиента = ");

            _sotrudnik.WorkSotrudnik(_persons[InputInt("\n")]);
        }

        Console.ReadKey();
    }
    
    private static void CreatKlient(int size)
    {
        _persons = new DataPerson[size];

        for (int i = 0; i < _persons.Length; i++)
        {
            _persons[i] = new DataPerson("Agent_15." + i, "SS_15." + i, "Fath_15." + i, "+7900100201" + i, 287020 + i, 1119 + i);
        }
    }

    private static IPerson CreatWorker()
    {
        Console.WriteLine("\nВыберите за кого войти в систему банка\n1. Консультант\n2. Менеджер: ");

        switch (InputInt("\n"))
        {
            case 1:
                Console.WriteLine("Вы зашли как кансультант!\n");
                return new Konsultate();
            case 2:
                Console.WriteLine("Вы зашли как менеджер!\n");
                return new Meneger();
            default:
                Console.WriteLine("Такого нету,поэтому вы получаете самый маленький доступ, заходите как кансультант!");
                break;
        }


        return new Konsultate();
    }
}