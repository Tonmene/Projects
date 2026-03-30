//In a public access modifier the code is accessible outside its class
//In a private access modifier the code is accessible only within the class
//In a protected access modifier the code is accessible within the same class or in a class the is inherited from that class
//In an Internal access modifier the code is accesible to within its own assembly
//In a protected internal class
//In a private protected class

//This is an example of a public access modifer
class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}