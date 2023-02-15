using System;
using System.Collections.Generic;

class UdeM_Bank
{


    public static void Main()
    {
        UdeM_Bank bank1 = new UdeM_Bank();
        bank1.welcome();

    }


    void welcome()
    {
        Manager manager = new Manager();
        int option;
        Console.WriteLine("Bienvenido a UdeM Bank! \n");
        Console.WriteLine("Seleccione la opcíon que desee \n");
        Console.WriteLine("1. Retirar Dinero \n" + "2.Registros \n" + "3. Revisar Registros \n");
        option = int.Parse(Console.ReadLine());
        if (option == 1)
        {
            return;
        }
        if (option == 2)
        {
            ;
            int option2;
            Console.WriteLine("Seleccione la opcíon que desee \n");
            Console.WriteLine("1. Registrar Usuario \n" + "2.Registrar ATM: \n");
            option2 = int.Parse(Console.ReadLine());
            if (option2 == 1)
            {
                manager.add_client();
                welcome();

            }
            if (option2 == 2)
            {
                manager.add_ATM();
                welcome();

            }
        }

        if (option == 3)
        {
            manager.read_options();
        }

    }
}


