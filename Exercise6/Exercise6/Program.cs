

// See https://aka.ms/new-console-template for more information
// prompt for and get angle
Console.Write("Enter angle in degrees: ");
float angle = float.Parse(Console.ReadLine());

// calculate and print cosine and sine
// the line of code below is shorthand for
// angle = angle * Math.PI / 180;
angle *= (float)Math.PI / 180;
Console.WriteLine("Cosine: " + Math.Cos(angle));
Console.WriteLine("Sine:   " + Math.Sin(angle));