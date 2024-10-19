using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionList
{
    private Transaction[] dataset;
    private int numTrans = 0;

    public TransactionList(int size)
    {
        dataset = new Transaction[size];
    }

    public void Add(Transaction transaction)
    {
        dataset[numTrans++] = transaction;
    }

    public void Read(int num)
    {
        Console.WriteLine("Enter " + num + " transaction values:");

        for (int i = 0; i < num; i++)
        {
            Console.Write(" Enter Val, Day, Month, Year: ");
            string val = Console.ReadLine();
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            string year = Console.ReadLine();

            Transaction tr = new Transaction(int.Parse(val), 
                            new Date(int.Parse(day), int.Parse(month), int.Parse(year)));
            Add(tr);
        }

    }

    public void Write()
    {
        Console.WriteLine("Transaction values:");
        for (int i = 0; i < numTrans; i++)
        {
            Console.WriteLine("Val: " + dataset[i].GetVal());
            Console.WriteLine("Day: " + dataset[i].GetDate().GetDay());
            Console.WriteLine("Month: " + dataset[i].GetDate().GetMonth());
            Console.WriteLine("Year: " + dataset[i].GetDate().GetYear());
        }
    }

}

