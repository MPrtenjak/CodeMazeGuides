namespace ListAllThePermutationsOfStringInCSharp
{
    public class RecursiveAlgorithm : IPermutation
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
            Benchmarks = doBenchmarks;
            size = number;

            var input = Enumerable.Range(0, number).Select(i => (byte)i).ToArray();
            var result = new List<byte[]>();
            RecursiveGenerator(result, input, 0, input.ToList());
            return result;
        }

        private void RecursiveGenerator(List<byte[]> result, byte[] input, byte fixedPosition, List<byte> freeNumbers)
        {
            if (fixedPosition == size)
            {
                if (!Benchmarks) result.AddCopy(input);
            }
            else
            {
                for(int i = 0; i < freeNumbers.Count; ++i)
                {
                    var newFreeNumbers = new List<byte>(freeNumbers);
                    newFreeNumbers.RemoveAt(i);

                    input[fixedPosition] = freeNumbers[i];
                    RecursiveGenerator(result, input, (byte)(fixedPosition + 1), newFreeNumbers);
                }
            }
        }

        private bool Benchmarks;
        private byte size;
    }
}
