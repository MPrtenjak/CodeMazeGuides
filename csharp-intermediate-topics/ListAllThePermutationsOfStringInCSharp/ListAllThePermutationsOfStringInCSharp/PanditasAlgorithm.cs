using System.Drawing;

namespace ListAllThePermutationsOfStringInCSharp
{
    public class PanditasAlgorithm : IPermutation
    {
        public List<byte[]> GetPermutations(byte number)
        {
            return GeneratePermutations(number, false);
        }

        public void BenchmarkPermutations(byte number)
        {
            GeneratePermutations(number, true);
        }

        private List<byte[]> GeneratePermutations(byte number, bool doBenchmarks)
        {
            _Benchmarks = doBenchmarks;

            var input = Enumerable.Range(0, number).Select(i => (byte)i).ToArray();
            var result = new List<byte[]>();
            result.AddCopy(input);
            while (NextPermutation(input)) 
            {
                if (!_Benchmarks) result.AddCopy(input);
            }

            return result;
        }

        public bool NextPermutation(byte[] a)
        {
            int i = a.Length - 2;
            while (i >= 0 && a[i] >= a[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = a.Length - 1;
                while (a[j] <= a[i])
                {
                    j--;
                }
                (a[i], a[j]) = (a[j], a[i]);
            }
            else
                return false;

            Reverse(a, i + 1);
            return true;
        }

        private void Reverse(byte[] a, int start)
        {
            int i = start;
            int j = a.Length - 1;
            while (i < j)
            {
                (a[i], a[j]) = (a[j], a[i]);
                i++;
                j--;
            }
        }

        private bool _Benchmarks;
    }
}
