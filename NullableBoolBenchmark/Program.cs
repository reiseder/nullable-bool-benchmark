/***********************************************************************
 * Copyright (c) 2021 Matthias Reiseder. All rights reserved.
 * Licensed under the MIT License.
 * See LICENSE file in the repository root for full license information.
 * 
 * Made with BenchmarkDotNet
 * https://github.com/dotnet/BenchmarkDotNet
 **********************************************************************/

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace NullableBoolBenchmark
{
    public class NullableBoolBenchmark
    {
        private readonly bool? isNull = null;
        private readonly bool? isTrue = true;
        private readonly bool? isFalse = false;

        [Benchmark]
        public bool IsNullTrue()
        {
            if (isNull == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsNullTrueLong()
        {
            if (isNull != null ? isNull.Value : false == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsNullFalse()
        {
            if (isNull ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsNullFalseLong()
        {
            if ((isNull != null ? isNull.Value : default(bool?)) ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsNullDefault()
        {
            if (isNull.GetValueOrDefault())
                return true;

            return false;
        }

        [Benchmark]
        public bool IsTrueTrue()
        {
            if (isTrue == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsTrueTrueLong()
        {
            if ((isTrue != null ? isTrue.Value : false) == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsTrueFalse()
        {
            if (isTrue ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsTrueFalseLong()
        {
            if ((isTrue != null ? isTrue.Value : default(bool?)) ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsTrueDefault()
        {
            if (isTrue.GetValueOrDefault())
                return true;

            return false;
        }

        [Benchmark]
        public bool IsFalseTrue()
        {
            if (isFalse == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsFalseTrueLong()
        {
            if ((isFalse != null ? isFalse.Value : false) == true)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsFalseFalse()
        {
            if (isFalse ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsFalseFalseLong()
        {
            if ((isFalse != null ? isFalse.Value : default(bool?)) ?? false)
                return true;

            return false;
        }

        [Benchmark]
        public bool IsFalseDefault()
        {
            if (isFalse.GetValueOrDefault())
                return true;

            return false;
        }
    }

    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<NullableBoolBenchmark>();
            Console.ReadKey();
        }
    }
}
