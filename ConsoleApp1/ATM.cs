using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class ATM

{

    private int atm_id;
    private int atm_balance;
    private int amt_to_withdrawal;
    private int new_amount;


    public ATM()
    {

    }

    public int _atm_id
    {
        get { return atm_id; }
        set { atm_id = value; }
    }

    public int _atm_balance
    {
        get { return atm_balance; }
        set { atm_balance = value; }
    }






    public void Add_ATM()
    {
        Console.WriteLine("Ingrese la Identficación del cajero: \n");
        _atm_id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el balance del cajero: \n");
        _atm_balance = int.Parse(Console.ReadLine());
        Console.WriteLine("El cajero " + atm_id + " Con un balance de: " + atm_balance + " USD " + "Ha sido registrado satisfactoriamente.\n");
    }

    public void Withdraw_ATM() {
        Console.WriteLine("Ingrese su identificación: ");

    
    }
}
