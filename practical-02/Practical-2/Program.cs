using System;

public class Customer_Account
{
    private string bank_name;
    private long customer_accountNo;
    private string customer_name;
    
    public string BankName
    {
        get 
        { 
            return bank_name; 
        }
        set 
        { 
            bank_name = value; 
        }
    }

    public Customer_Account(long accountNo, string customerName)
    {
        customer_accountNo = accountNo;
        customer_name = customerName;
    }

    /* PrintInfo */
    // This method will print the customer account details
    // Return type of this method is void

    public void PrintInfo()
    {
        Console.WriteLine($"\nBank name\t\tAccount number\t\tCustomer name");
        Console.WriteLine($"\n{this.BankName}\t{this.customer_accountNo}\t\t{this.customer_name}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        Customer_Account customerAccount1 = new Customer_Account(190170116026, "Jay Koshti");
        customerAccount1.BankName = "State Bank Of India";
               
        customerAccount1.PrintInfo();

        Console.ReadLine();
    }
}