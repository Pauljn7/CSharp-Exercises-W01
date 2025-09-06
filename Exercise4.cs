// Exercise 4: Lists
// This one collects 5 numbers from the user, stores them in a list, and shows the total sum.

using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++) {
            int input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);
        }

        int sum = 0;
        foreach (int n in numbers) {
            sum += n;
        }

        Console.WriteLine($"The total sum is {sum}");
    }
}
