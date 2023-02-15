using System;
using System.Collections.Generic;

class Client
{

    private int client_id;
    private int client_balance;
    private string client_name;


    public Client()
    {
      
    }

    public int _Client_id
    {
        get { return client_id; }
        set { client_id = value; }
    }

    public int _Client_balance
    {
        get { return client_balance; }
        set { client_balance = value; }
    }

    public string _Client_name
    {
        get { return client_name; }
        set { client_name = value; }
    }

}