using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    private int val;
    private Date date;

    public Transaction() { }
    public Transaction(int val, Date date)
    {
        this.val = val;
        this.date = date;
    }
    
    public void SetVal(int val) { this.val = val; }
    public void SetDate(Date date) { this.date = date; }
    public int GetVal() { return val; }
    public Date GetDate() { return date; }

}