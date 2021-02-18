using System;

class MainClass {
  public static void Main (string[] args) {
    int i=0;

    Console.WriteLine ("Enter Name");
    string name = Console.ReadLine();

    Console.WriteLine("Enter Height")
    double heightInches = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter pounds");
    double weightPounds = Convert.ToDouble(Console.ReadLine());

    bmi = (703 * weightPounds) / (heightInches * heightInches);


    for(i = bmi; weightPounds <= heightInches; i++)
    {

      if(bmi < 18.5)
      Console.WriteLine(bmi + "you are underweight ");
      
      else(bmi <= 18.5 && bmi < 24.9)
      Console.WriteLine(bmi + "you are normal");

      if (bmi >= 24.9 && bmi < 30.0)
      Console.WriteLine(bmi + "you are overweight ");

      else (bmi >= 30.0)
      Console.WriteLine(bmi + "you are obese ");
      i++;
    }

    //cant firgure it out :(
  }
}