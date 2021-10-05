using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int reg = 0;
            foreach (var num in numbers) 
            {
                if (num % 2 == 0) 
                {
                    reg += num;
                }
                else 
                {
                    reg -= num;
                }

            }
            return reg;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] myList = { str1, str2, str3, str4 };
            var num = myList.Min();
            var length = num.Length;
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] myArray = { number1, number2, number3, number4 };
            var numbers = myArray.Min();
            return numbers;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
                return false;
            else
                return true;
        }

        public bool IsStringANumber(string input)
        {
            double n;
            var isNumber = double.TryParse(input, out n);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            {
                int itemCount = objs.Length;
                int nullCount = 0;
                foreach (object obj in objs)
                {
                    if (obj == null) nullCount++;
                }
                if (nullCount > itemCount / 2)
                {
                    return true;
                }
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number == 0) return 1;
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return number;
            }
        }
    }
}
