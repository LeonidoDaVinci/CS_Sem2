﻿int a = 322;
int b = a % 7;
int c = a % 23;
if (b == 0 && c == 0)
{
    Console.WriteLine($"Число '{a}' КРАТНО 7 и 23");
}
else
{
    Console.WriteLine($"Число  '{a}' НЕ КРАТНО 7 и 23");
}