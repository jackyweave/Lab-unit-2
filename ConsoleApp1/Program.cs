using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

Console.WriteLine("Welcome to Grand Circus Room Generator! :) ");

Console.WriteLine("Please enter the length:");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the width:");
double width = Convert.ToDouble(Console.ReadLine());

double area = length * width;
double perimeter = 2 * (length + area);


Console.WriteLine($"Area of the room: {area} ");
Console.WriteLine($"Perimeter of the room: {perimeter} ");




 if (area <= 250)
{
    Console.WriteLine("This room is a small size");

}

else if (area > 250 && area > 650)
{ Console.WriteLine("The room is a medium size"); }


else
{
    Console.WriteLine("The Room is Large");
}