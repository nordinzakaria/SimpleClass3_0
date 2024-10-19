using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Date
{
    private int day;
    private int month;
    private int year;

    public Date() { }
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int GetDay() { return day; }
    public int GetMonth() { return month; }
    public int GetYear() { return year; }
    public void SetDay(int day) { this.day = day; }
    public void SetMonth(int month) { this.month = month; }
    public void SetYear(int year) { this.year = year; }
}