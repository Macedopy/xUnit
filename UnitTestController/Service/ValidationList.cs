using System.Reflection.Metadata;

namespace UnitTestController
{
    public class ValidationList
    {
        public List<int> RemoveNegativeNumbers(List<int> list)
        {
            var NegativeList = list.Where(x => x > 0);
            return NegativeList.ToList();
        }

        public bool ListContainsNumber(List<int> list, int number)
        {
            var contains = list.Contains(number);
            return contains;
        }

        public List<int> MultiplyNumbersofList(List<int> list, int number)
        {
            var listMulplied = list.Select(x => x * number).ToList();
            return listMulplied;
        }

        public int ReturnHighestNumber(List<int> list, int number)
        {
            return list.Max();
        }

        public int ReturnLowestNumber(List<int> list)
        {
            return list.Min();
        }
    }
}