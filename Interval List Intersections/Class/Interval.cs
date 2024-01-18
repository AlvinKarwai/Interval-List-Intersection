using Interval_List_Intersections.Interface;

namespace Interval_List_Intersections.Class
{
    public class Interval : IInterval
    {

        public void GetIntersection(int[,] firstList, int[,] secondList)
        {

            int firstListCounter = 0, secondListCounter = 0;
            int maxValueInFirstListSequence = 0;
            int maxValueInSecondListSequence = 0;

            int numberOfFirstListElements = firstList.GetLength(0);
            int numberOfSecondListElements = secondList.GetLength(0);

            var isGreaterCountFirstList = SequenceCheck(firstList);

            var isGreaterCountSecondList = SequenceCheck(secondList);

            if (isGreaterCountFirstList > 0)
            {
                Console.WriteLine("First List starti > endi");
            }

            if (isGreaterCountSecondList > 0)
            {
                Console.WriteLine("Second List startj > endj");
            }

            if (numberOfFirstListElements > 0)
            {
                maxValueInFirstListSequence = firstList.Cast<int>().Max();
            }

            if (numberOfSecondListElements > 0)
            {
                maxValueInSecondListSequence = secondList.Cast<int>().Max();
            }

            if (numberOfFirstListElements == 0)
            {
                Console.WriteLine("[]");
            }

            if (numberOfSecondListElements == 0)
            {
                Console.WriteLine("[]");
            }

            //constraint check 0 <= firstList.length, secondList.length <= 1000
            if (numberOfSecondListElements >= 1000)
            {
                Console.WriteLine("[]");
            }

            // constraint check 0 <= firstList.length, secondList.length <= 1000
            if (numberOfFirstListElements >= 1000)
            {
                Console.WriteLine("[]");
            }

            // constraint check can't be over 109 and constraint check firstList.length + secondList.length >= 1
            if ((numberOfFirstListElements + numberOfFirstListElements >= 1) && maxValueInFirstListSequence <= 109 && maxValueInSecondListSequence <= 109)
            {
                while (firstListCounter < numberOfFirstListElements && secondListCounter < numberOfSecondListElements)
                {

                    int left = Math.Max(firstList[firstListCounter, 0], secondList[secondListCounter, 0]);

                    int right = Math.Min(firstList[firstListCounter, 1], secondList[secondListCounter, 1]);

                    if (left <= right)
                    {
                        Console.WriteLine($"[{left}, {right}]");
                    }

                    if (firstList[firstListCounter, 1] < secondList[secondListCounter, 1])
                    {
                        firstListCounter++;

                    }
                    else
                    {
                        secondListCounter++;
                    }
                }
            }
            //Constraint check firstList.length + secondList.length >= 1
            else if (numberOfFirstListElements + numberOfFirstListElements < 1)
            {
                Console.WriteLine("Sequence must contain at least one element");
            }
            else if (maxValueInFirstListSequence > 109 || maxValueInSecondListSequence > 109)
            {
                Console.WriteLine("Sequence must not contain a value greater than equal to 110");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }


        // Constraint check endi < starti+1 and constraint check 0 <= starti < endi
        //Constraint Check endj < startj+1 and constraint check 0 <= startj < endj 

        private int SequenceCheck(int[,] list)
        {
            var sequence = new List<int>();
            var isGreaterCount = 0;

            foreach (int i in list)
            {
                sequence.Add(i);
            }

            for (int i = 1; i < sequence.Count; i++)
            {
                var previous = sequence[i - 1];
                var current = sequence[i];

                if (previous < current)
                {

                }
                else if (previous > current)
                {
                    isGreaterCount++;
                }
            }
            return isGreaterCount;
        }
    }
}
