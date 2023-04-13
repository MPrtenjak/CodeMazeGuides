using BenchmarkDotNet.Attributes;

namespace ListAllThePermutationsOfStringInCSharp
{
    [MemoryDiagnoser]
    public class MemoryAlgorithmsBenchmark
    {
        [Params(4, 6, 8)]
        public byte numberOfItems;

        [Benchmark]
        public void BasicAlgorithmBenchmark()
        {
            IPermutation algorithm = new BasicAlgorithm();
            algorithm.BenchmarkPermutations(numberOfItems);
        }

        [Benchmark]
        public void ImprovedAlgorithmBenchmark()
        {
            IPermutation algorithm = new ImprovedAlgorithm();
            algorithm.BenchmarkPermutations(numberOfItems);
        }

        [Benchmark]
        public void RecursiveAlgorithmBenchmark()
        {
            IPermutation algorithm = new RecursiveAlgorithm();
            algorithm.BenchmarkPermutations(numberOfItems);
        }

        [Benchmark]
        public void HeapsAlgorithmBenchmark()
        {
            IPermutation algorithm = new HeapsAlgorithm();
            algorithm.BenchmarkPermutations(numberOfItems);
        }

        [Benchmark]
        public void PanditasAlgorithmBenchmark()
        {
            IPermutation algorithm = new PanditasAlgorithm();
            algorithm.BenchmarkPermutations(numberOfItems);
        }
    }
}
