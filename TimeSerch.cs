using System;

public struct TimeSerch
{
    private DateTime _time;
    private TypeSerch _type;

    private string _data;
    private string _person;

    public void SetData(object person)
    {
        _time = DateTime.Now;
        _person = person.ToString();
    }

    public void SetData(string data, int type)
    {
        _data = data; _type = (TypeSerch)type;
    }
}

public enum TypeSerch
{
    Print = 0,
    Redact = 1
}