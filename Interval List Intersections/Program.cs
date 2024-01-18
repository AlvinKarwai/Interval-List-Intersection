

using Interval_List_Intersections.Class;

Console.WriteLine("Welcome to Alvin Interval List Intersection project:");

int[,] exampleOnefirstList = { { 0, 2 }, { 5, 10 }, { 13, 23 }, { 24, 25 } };

int[,] exampleTwosecondList = { { 1, 5 }, { 8, 12 }, { 15, 24 }, { 25, 26 } };


int[,] example2FirstList = { { 1, 3 }, { 5, 9 } };

int[,] example2SecondList = { };


int[,] example3FirstList = { { 1, 7 } };

int[,] example3SecondList = {{ 3, 10 } };

var interval = new Interval();

Console.WriteLine("Example 1 Output:");

interval.GetIntersection(exampleOnefirstList, exampleTwosecondList);

Console.WriteLine("Example 2 Output:");

interval.GetIntersection(example2FirstList, example2SecondList);

Console.WriteLine("Example 3 Output:");

interval.GetIntersection(example3FirstList, example3SecondList);

