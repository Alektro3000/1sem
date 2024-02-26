using System.ComponentModel.Design;

namespace Text
{
    internal class Program
    {

        static bool BuildString(int Count, params int[] nums)
        {
            int sum = 0;
            foreach (var q in nums)
                sum += q;
            Count -= nums.Length-1;

            double factor = (double)Count/sum;
            
            int[] outnums = new int[nums.Length];
            double[] errors = new double[nums.Length];

            int sumfact = 0;

            for (int i = 0; i < outnums.Length; ++i)
            {
                double CurrentNum = factor * nums[i];

                outnums[i] = (int)CurrentNum;

                errors[i] = CurrentNum % 1;

                sumfact += outnums[i];
            }
            int error = Count - sumfact;


            for (int i = 0; i < error; ++i)
            {
                int mxid = 0;
                double mxerr = 0;
                for (int j = 0; j < errors.Length; ++j)
                {
                    if(mxerr < errors[j])
                    {
                        mxid = j;
                        mxerr = errors[j];
                    }
                }
                outnums[mxid]++;
                errors[mxid] = 0.0;
            }

            foreach (var q in outnums)
                if (q == 0)
                    return false;
            

            for (int i = 0; i < outnums.Length; ++i)
            {
                if (i != 0)
                    Console.Write('|');

                Console.Write(new string('-', outnums[i]));
            }
            Console.WriteLine("");
            return true;
        }

        static void Main(string[] args)
        {
            //With error correction to have exactly correct number of symbols;

            if(!BuildString(12,3,2,3))
                Console.WriteLine("Error");
        }
    }
}