using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Manager
{
    int manager_id;
    int manager_pass;

    public List<Client> clients = new List<Client>();
    List<ATM> ATMs = new List<ATM>();

    public Manager()
    {

    }

    public int _Manager_id
    {
        get { return manager_id; }
        set { manager_id = value; }
    }

    public int _manager_pass
    {
        get { return manager_pass; }
        set { manager_pass = value; }

    }

    public void add_client()
    {
        Client client = new Client();
        clients.Add(client);

        Console.WriteLine("Ingrese la Identficación del cliente: \n");
        client._Client_id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance de la cuenta del cliente: \n");
        client._Client_balance = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance de la cuenta del cliente: \n");
        client._Client_name = Console.ReadLine();
        Console.WriteLine(client);
        Console.WriteLine(clients);
        Console.WriteLine("El cliente " + client._Client_name + " Identificado con " + client._Client_id + " Con un balance de " + client._Client_balance + " Ha sido registrado satisfactoriamente.\n ");
    }

    public void add_ATM()
    {
        ATM atm = new ATM();
        ATMs.Add(atm);
        Console.WriteLine("Ingrese la Identficación del cajero: \n");
        atm._atm_id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance del cajero: \n");
        atm._atm_balance = int.Parse(Console.ReadLine());
        Console.WriteLine("El cajero " + atm._atm_id + " Con un balance de: " + atm._atm_balance + " USD " + "Ha sido registrado satisfactoriamente.\n");
        Console.WriteLine(atm);
    }


    public void read_options()
    {
        Console.WriteLine("Que registros desea visitar?: ");
        Console.WriteLine("1. Revisar clientes \n" + "2.Revisar  ATMs: \n");
        int r_option = int.Parse(Console.ReadLine());
        if (r_option == 1) 
        { 
        Read_list_clients();
        }

        if (r_option == 2) 
        { 
        Read_list_ATM();
        }
    }
        

    
    public void Read_list_clients()
    {
        
        clients.ForEach(client =>
        {
            Console.WriteLine("Nombre del cliente: " + client._Client_name);
            Console.WriteLine("Identificación del cliente: " + client._Client_id);
            Console.WriteLine("Balance del cliente: " + client._Client_id);

        });
        read_options();

    }
    public void Read_list_ATM()
    {
        foreach (ATM atm in ATMs)
        {
            Console.WriteLine("ID del cajero: " + atm._atm_id);
            Console.WriteLine("Balance del cajero: " + atm._atm_balance);
            return;
        }
    }
}


