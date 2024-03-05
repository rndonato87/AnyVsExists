using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace AnyVsExists
{
    [MemoryDiagnoser]
    public class AnyVsExistsBenchmark
    {
        private const int Start = 0;
        private const int End = 10000;
        private const int NumberToBeFound = 2480;

        private IEnumerable<int> _enumerable = Enumerable.Range(Start, End);
        private List<int> _list = new();

        public AnyVsExistsBenchmark()
        {
            for (var i = Start; i < End; i++)
                _list.Add(i);
        }

        [Benchmark]
        public void AnyEnumerable()
        {
            var res = _enumerable.Any();
        }

        [Benchmark]
        public void AnyEnumerableWithPredicate()
        {
            var res = _enumerable.Any(x => x == NumberToBeFound);
        }

        [Benchmark]
        public void AnyList()
        {
            var res = _list.Any();
        }

        [Benchmark]
        public void AnyListWithPredicate()
        {
            var res = _list.Any(x => x == NumberToBeFound);
        }

        [Benchmark]
        public void ExistsListWithPredicate()
        {
            var res = _list.Exists(x => x == NumberToBeFound);
        }
    }
}