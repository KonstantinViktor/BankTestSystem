using System;

class Meneger : Konsultate, IPerson
{
    public override void WorkSotrudnik(DataPerson pers)
    {
        Console.WriteLine("Здравствуйте, вы вошли как менеджер и имеете следующие возможности: ");
        Console.WriteLine("1. Просмотр полного ФИО клиента");
        Console.WriteLine("2. Просмотр, при наличии, паспортных данных");
        Console.WriteLine("3. Просмотр номера телефона");
        Console.WriteLine("4. Изменение номера телефона");
        Console.WriteLine("5. Изменение паспортные данные");
        Console.WriteLine("6. Изменение ФИО");

        Console.WriteLine("\n\nВыберите функцию = ");

        int serch = Program.InputInt();

        switch (serch)
        {
            case 1:
                Console.WriteLine("Вот полное ФИО клиента: ");
                Console.WriteLine(FullNameChanger(pers));
                break;
            case 2:
                Console.WriteLine("Вот паспортные данные клиента: ");
                Console.WriteLine(PasportDataChanger(pers));
                break;
            case 3:
                Console.WriteLine("Вот номер телефона клиенат: ");
                Console.WriteLine(PhonNumberChanger(pers));
                break;
            case 4:
                Console.WriteLine("Вы можете поменять номер телефона клиента: ");
                PhonNumberModic(pers);
                Console.WriteLine("Все готово!\n");
                break;
            case 5:
                Console.WriteLine("Вы можете поменять паспортные данные клиента: ");
                PasportDataChanger(pers);
                Console.WriteLine("Все готово!\n");
                break;
            case 6:
                Console.WriteLine("Вы можете поменять ФИО клиента: ");
                FullNameModic(pers);
                Console.WriteLine("Все готово!\n");
                break;
            default:
                Console.WriteLine("\nТакой функции нет\n");
                break;
        }
    }

    public override string PasportDataChanger(DataPerson pers) => pers.PasportData;

    public override string PasportDataModic(DataPerson pers) => pers.PasportData = Console.ReadLine();

    public override string FullNameModic(DataPerson pers) => pers.FullName = Console.ReadLine();
}