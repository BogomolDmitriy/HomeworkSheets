using NUnit.Framework;
using LibraryHomeworkSheets;

namespace LibraryHomeworkSheets
{
    public class SheetsTest
    {
        [TestCase(new[] { 1, 2, 9 }, 8, new[] { 1, 2, 9, 8 })]
        [TestCase(new[] { 1 }, 8, new[] { 1, 8 })]

        public void Task1(int[] arr, int value, int[] expected)
        {
            int[] actual = Sheets.Task1(arr, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 8, new[] { 8, 1, 2, 9 })]
        [TestCase(new[] { 1 }, 8, new[] { 8, 1 })]

        public void Task2(int[] arr, int value, int[] expected)
        {
            int[] actual = Sheets.Task2(arr, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 8, 1, new [] { 1, 8, 2, 9 })]
        [TestCase(new[] { 1, 2, 9 }, 8, 0, new[] { 8, 1, 2, 9 })]
        [TestCase(new[] { 1, 2, 9 }, 8, 3, new[] { 1, 2, 9, 8 })]
        [TestCase(new[] { 1 }, 8, 0, new[] { 8, 1 })]
        public void Task3(int[] arr, int value, int index, int[] expected)
        {
            int [] actual = Sheets.Task3(arr, value, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, new[] { 1, 2 })]

        public void Task4(int[] arr, int[] expected)
        {
            int[] actual = Sheets.Task4(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, new[] { 2, 9 })]

        public void Task5(int[] arr, int[] expected)
        {
            int[] actual = Sheets.Task5(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 9 }, 0, new[] { 2, 9 })]
        [TestCase(new[] { 3, 4, 20, 0, 4 }, 1, new[] { 3, 20, 0, 4 })]

        public void Task6(int[] arr, int index, int[] expected)
        {
            int[] actual = Sheets.Task6(arr, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 4, 20, 0, 4 }, 2, new[] { 3, 4, 20 })]

        public void Task7(int[] arr, int number, int[] expected)
        {
            int[] actual = Sheets.Task7(arr, number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 3, 4, 20, 0, 4 }, 2, new[] { 20, 0, 4 })]

        public void Task8(int[] arr, int number, int[] expected)
        {
            int[] actual = Sheets.Task8(arr, number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 1, 3, new[] { 1, 5, 6, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 0, 4, new[] { 6, 7 })]

        public void Task9(int[] arr, int beginning, int end, int [] expected)
        {
            int[] actual = Sheets.Task9(arr, beginning, end);
            Assert.AreEqual(expected, actual);
        }
    }
}