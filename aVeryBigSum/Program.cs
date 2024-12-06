namespace aVeryBigSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1000000001 1000000002 1000000003 1000000004 1000000005";

            List<long> ar = input.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            Console.ReadLine();
        }
    }


    class Result
    {

        /*
         * Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
         */

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;

            foreach (long arTemp in ar)
            {
                sum += arTemp;
            }

            return sum;
        }

    }
}
