using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                /*int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;*/
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int n = numbers.Length;

            for(int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] >  numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;

            for(int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] arr = (int[]) numbers.Clone();
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                (arr[i], arr[maxIndex]) = (arr[maxIndex], arr[i]);
            }

            foreach (var n_ in arr)
            {
                Debug.Log(n_);
            }

            return arr;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] arr = (int[])numbers.Clone();
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }

            foreach (var n_ in arr)
            {
                Debug.Log(n_);
            }

            return arr;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] arr = (int[])numbers.Clone();
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            foreach (var n_ in arr)
            {
                Debug.Log(n_);
            }

            return arr;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] arr = (int[])numbers.Clone();
            System.Array.Sort(arr);
            System.Array.Reverse(arr);

            int max = arr[0];
            foreach (var n in arr)
            {
                if (n < max)
                {
                    return n;
                }
            }
            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int[] arr = (int[])numbers.Clone();
            System.Array.Sort(arr); // เรียงจากน้อยไปมาก

            int maxStreak = 1;
            int currentStreak = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    continue; // ข้ามค่าซ้ำ

                if (arr[i] == arr[i - 1] + 1) // ถ้าเป็นเลขต่อกัน
                {
                    currentStreak++;
                }
                else // ถ้าขาดช่วง
                {
                    currentStreak = 1;
                }

                if (currentStreak > maxStreak)
                    maxStreak = currentStreak;
            }

            Debug.Log($"The longest consecutive sequence is: {maxStreak}");
            return maxStreak;
        }

        #endregion
    }
}
