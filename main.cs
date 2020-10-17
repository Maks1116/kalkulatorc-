using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    //tutaj
    Console.WriteLine("1 - aby dodać 2 - aby odjąć 3 - aby pomnożyć 4 - aby podzielić");
    string odp = Console.ReadLine();
    if(odp == "1"){
      //wykonamy dodawanie 
      Console.WriteLine("podaj liczbę 1");
      float liczba1 = float.Parse(Console.ReadLine());
      Console.WriteLine("podaj liczbę 2");
      float liczba2 = float.Parse(Console.ReadLine());
      Console.WriteLine(liczba1 + liczba2);
    } else if(odp == "2"){
      //wykonamy odejmowanie
      Console.WriteLine("podaj liczbę 1");
      float liczba1 = float.Parse(Console.ReadLine());
      Console.WriteLine("podaj liczbę 2");
      float liczba2 = float.Parse(Console.ReadLine());
      Console.WriteLine(liczba1 - liczba2);
    }
    else if(odp == "3"){
      //wykonamy odejmowanie
      Console.WriteLine("podaj liczbę 1");
      float liczba1 = float.Parse(Console.ReadLine());
      Console.WriteLine("podaj liczbę 2");
      float liczba2 = float.Parse(Console.ReadLine());
      Console.WriteLine(liczba1 * liczba2);
    }
    else if(odp == "4"){
      //wykonamy odejmowanie
      Console.WriteLine("podaj liczbę 1");
      float liczba1 = float.Parse(Console.ReadLine());
      Console.WriteLine("podaj liczbę 2");
      float liczba2 = float.Parse(Console.ReadLine());
      Console.WriteLine(liczba1 / liczba2);
    }
  }
}