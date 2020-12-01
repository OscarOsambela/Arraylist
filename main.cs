using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    //declarar un arraylist indeterminado
    ArrayList miarray = new ArrayList();

    //declarar un arraylist determinado
    ArrayList miarray2 = new ArrayList(100);

    //agregar elementos al primer array
    miarray.Add(25);
    miarray.Add("Oscar");
    miarray.Add('A');
    miarray.Add(3.56);
    miarray.Add(true);

    foreach(object obj in miarray){
      Console.WriteLine(obj);
    }
  }
}
