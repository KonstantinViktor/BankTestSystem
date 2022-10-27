using System;

class Konsultate : IPerson
{
    public virtual void WorkSotrudnik(DataPerson pers)
    {
        Console.WriteLine("Здравствуйте, вы вошли как консультант и имеете следующие функции:");
        Console.WriteLine("1. Просмотр полного ФИО клиента");
        Console.WriteLine("2. Просмотр, при наличии, паспортных данных");
        Console.WriteLine("3. Просмотр номера телефона");
        Console.WriteLine("4. Изменение номера телефона");

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
            default:
                Console.WriteLine("\nТакой функции нет\n");
                break;
        }
    }

    public virtual string PasportDataChanger(DataPerson pers)
    {
        int length = pers.PasportData.Length;

        string off = "";

        for (int i = 0; i < length; i++)
        {
            off += "*";
        }

        return off;
    }

    public virtual string FullNameChanger(DataPerson pers) => pers.FullName;

    public virtual string PhonNumberChanger(DataPerson pers) => pers.PhoneNumber;

    public virtual string FullNameModic(DataPerson pers) => "Нехватает доступа";

    public virtual string PasportDataModic(DataPerson pers) => "Нехватает доступа";

    public virtual string PhonNumberModic(DataPerson pers) => pers.PhoneNumber = Console.ReadLine();
}