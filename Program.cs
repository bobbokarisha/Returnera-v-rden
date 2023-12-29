﻿

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.15, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex) // double returnerar ett värde som är double.
{
  
    /*double result = items[itemIndex] * (1 - discounts[itemIndex]); 
    return result; // för att returnera värde i metod ange return.
    */
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input) // Hur blev input = double total?
{
    return input.ToString().Substring(0, 5);
}