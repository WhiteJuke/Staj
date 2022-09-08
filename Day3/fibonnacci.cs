using System;
using System.Collections.Generic;

public class last2 : IEquatable<last2>
{
    public int fibid { get; set; }
    public int fibnumber { get; set; }

    public override string ToString()
    {
        return "Id: " + fibid + "   Number " + fibnumber;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        last2 objAsPart = obj as last2;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }

    public override int GetHashCode()
    {
        return fibid;
    }
    public bool Equals(last2 other)
    {
        if (other == null) return false;
        return (this.fibid.Equals(other.fibid));
    }
}

public class fibonnacci
{
    public static void Main()
    {
        List<last2> lasts = new List<last2>();
        lasts.Add(new last2() { fibid = 1, fibnumber = 1 });
        lasts.Add(new last2() { fibid = 2, fibnumber = 1 });
        for (int count = 0; count <= 20; count++)
        {
            lasts.Add(new last2() { fibid = lasts.Count + 1});
        }
        foreach (last2 alast in lasts)
        {
            Console.WriteLine(alast);
        }
    }
}