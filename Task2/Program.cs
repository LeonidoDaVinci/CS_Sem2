﻿int X = -5;
int Y = 6;
if (X > 0 && Y > 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится в первой четверти");
}
else 
{
if (X < 0 && Y > 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится во второй четверти");
} 
else
{
if (X < 0 && Y < 0)
{
    Console.WriteLine($"Точка X={X} Y={Y} находится в третьей четверти");
}    
else
{
   Console.WriteLine($"Точка X={X} Y={Y} находится в четвертой четверти"); 
}
}
}