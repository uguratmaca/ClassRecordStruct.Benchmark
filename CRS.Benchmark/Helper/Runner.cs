using BenchmarkDotNet.Attributes;
using System.Threading.Tasks;

namespace CRS.Benchmark.Helper
{
    [MemoryDiagnoser]
    [HtmlExporter]
    public class Runner
    {
        [Params(20)]
        public int iterationCount;

        [Benchmark]
        public async Task IterationRecord()
        {
            var dt = new DataGenerator();
            for (int i = 0; i < iterationCount; i++)
            {
                dt.GenerateRecord();
            }
        }

        [Benchmark]
        public async Task IterationClass()
        {
            var dt = new DataGenerator();
            for (int i = 0; i < iterationCount; i++)
            {
                dt.GenerateClass();
            }
        }

        [Benchmark]
        public async Task IterationStruct()
        {
            var dt = new DataGenerator();
            for (int i = 0; i < iterationCount; i++)
            {
                dt.GenerateStruct();
            }
        }
    }
}