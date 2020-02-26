using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// In this assignment we calculate the distance 
/// between two points and the angle a game character 
/// would need to move in to go from the second point 
/// to the first point.
/// </summary>
namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a welcome message
            Console.WriteLine("This app will calculate the distance between two points and the angle between those points");

            float x1, y1, x2, y2;

            // Get first point values
            Console.Write("1st point X coordinate: ");
            x1 = float.Parse(Console.ReadLine());
            Console.Write("1st point Y coordinate: ");
            y1 = float.Parse(Console.ReadLine());

            // Get second point values
            Console.Write("2nd point X coordinate: ");
            x2 = float.Parse(Console.ReadLine());
            Console.Write("2nd point Y coordinate: ");
            y2 = float.Parse(Console.ReadLine());

            // Calculate delta between two points
            float deltaX = x2 - x1;
            float deltaY = y2 - y1;

            // Calculate the distance between two points
            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            // Calculate the angle to go from point 1 to point 2
            float rad = (float)Math.Atan2(deltaY, deltaX);
            float deg = 180 * rad / (float)Math.PI;

            // Print the answers
            Console.WriteLine("Distance between two points: " + distance);
            Console.WriteLine("Angle between two points: " + deg + " degrees");

            Console.ReadLine();
        }
    }
}
