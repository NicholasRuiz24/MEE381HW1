//This code will make an array of random doubles and integers and then use various functions to test how long it takes to compute multiplication/addition of integers and doubles
//The code will also test how long it takes to run mulitiplication by itself as well as using the math.pow and math.sqrt functions and seeing how long they take to compute
using System;
using System.Diagnostics;

class Program{
    static void Main(){
        int n = 80000; //number of random numbers to generate

        //makes an empty array for both doubles and ints
        double[,] numbers;
        int[,] numbersInt;

        //setups a timer to time how long each function takes to compute
        Stopwatch timer = new Stopwatch();
        
        //calls the random number generator functions to store them into the empty arrays for later use
        numbers = GenRandomNumbersDouble(n);
        numbersInt = GenRandomNumbersInt(n);

        //Times how long it takes to multiply integers
        timer.Start();
        MultiplyNumbersInt(numbersInt,n);
        timer.Stop();
        Console.WriteLine("Multiplication of Integers");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");

        //Times how long it takes to add integers
        timer.Restart();
        AddNumbersInt(numbersInt,n);
        timer.Stop();
        Console.WriteLine("Addition of Integers");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");

        //Times how long it takes to multiply doubles
        timer.Restart();
        MultiplyNumbersDouble(numbers,n);
        timer.Stop();
        Console.WriteLine("Multiplication of Doubles");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");

        //Times how long it takes to add doubles
        timer.Restart();
        AddNumbersDouble(numbers,n);
        timer.Stop();
        Console.WriteLine("Addition of Doubles");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");

        //Times how long it takes to square numbers through self multiplication
        timer.Restart();
        SquareNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Square of Numbers by itself");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");

        //Times how long it takes to multiply numbers using math.pow
        timer.Restart();
        MathPowNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Square of Numbers with math.pow Function");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");
        
        //Times how long it takes to square root numbers using math.sqrt
        timer.Restart();
        MathSqrtNumbers(numbers,n);
        timer.Stop();
        Console.WriteLine("Square Root of numbers with math.sqrt Function");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " Ticks\n");
    }

//Function to generate random double array
static double[,] GenRandomNumbersDouble(int count){
    Random rand = new Random();
    double[,] num = new double[count,3];
    for(int i=0; i<count; ++i){
        num[i,0] = 100.0 * (rand.NextDouble());
        num[i,1] = 100.0 * (rand.NextDouble()); 
    }
    return num; //returns array to main function
}

//Function to generate random int array
static int[,] GenRandomNumbersInt(int count){
    Random rand = new Random();
    int[,] num = new int[count,3];
    for(int i=0; i<count; ++i){
        num[i,0] = (int)(100.0 * (rand.NextDouble()));
        num[i,1] = (int)(100.0 * (rand.NextDouble())); 
    }
    return num; //returns array to main function
}

//Function to mulitply integer values
static void MultiplyNumbersInt(int[,] numbers, int count){
    int i;
    for(i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] * numbers[i,1];
    }
}

//Function to add integer values
static void AddNumbersInt(int[,] numbers, int count){
    int i;
    for (i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] + numbers[i,1];
    }
}

//function to add double values
static void AddNumbersDouble(double[,] numbers, int count){
    int i;
    for (i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] + numbers[i,1];
    }
}

//function to multiply double values 
static void MultiplyNumbersDouble(double[,] numbers, int count){
    int i;
    for (i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] + numbers[i,1];
    }
}

//Function to multiply numbers via multiplication
static void SquareNumbers(double[,] numbers, int count){
    int i;
    for(i=0; i<count; ++i){
        numbers[i,2] = numbers[i,0] * numbers[i,0];
    }
}

//Function to multiply numbers via math.pow
static void MathPowNumbers(double[,] numbers, int count){
    int i;
    for(i=0; i<count; ++i){
        numbers[i,2] = Math.Pow(numbers[i,0],2);
    }
}

//Function to squart root numbers via math.sqrt
static void MathSqrtNumbers(double[,] numbers, int count){
    int i;
    for(i=0; i<count; ++i){
        numbers[i,2] = Math.Sqrt(numbers[i,0]);
    }
}
}