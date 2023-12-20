namespace HelloWorld;
using System;
using System.Diagnostics;
using UserInput;
using Calculator;

class Program
{
    static void Main(string[] args)
    {
        if(args.Length > 0 && args[0] == "start") 
        {
            foreach(string arg in args) 
            {
                Console.WriteLine(arg);
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c dotnet run";
            startInfo.CreateNoWindow = true; // Set CreateNoWindow to true
            startInfo.UseShellExecute = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        UserInput userInput = new UserInput();
        Calculator calculator = new Calculator();
        userInput.start();
        do 
        {
            int method = userInput.getMethod();
            var results = new string[4];
            switch (method)
            {
                case 1:
                    int radius = userInput.getRadius();
                    results = calculator.calculateViaRadius(radius);
                    break;
                case 2:
                    int diameter = userInput.getDiameter();
                    results = calculator.calculateViaDiameter(diameter);
                    break;
                case 3:
                    int area = userInput.getArea();
                    results = calculator.calculateViaArea(area);
                    break;
                case 4:
                    int perimeter = userInput.getPerimeter();
                    results = calculator.calculateViaPerimeter(perimeter);
                    break;
            }
            Console.WriteLine("Area: " + results[0]);
            Console.WriteLine("Circumference: " + results[1]);
            Console.WriteLine("Diameter: " + results[2]);
            Console.WriteLine("Radius: " + results[3]);
        } while(userInput.continuePrompt());
        userInput.close();
    }
}
