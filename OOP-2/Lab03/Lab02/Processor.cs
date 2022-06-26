using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    [Serializable]
    public class Processor
    {
        public string Producer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int CountOfCores { get; set; }
        public int Frequency { get; set; }
        public int MaxFrequency { get; set; }
        public int BitArchitecture { get; set; }
        public int CacheL1 { get; set; }
        public int CacheL2 { get; set; }
        public int CacheL3 { get; set; }

        public Processor() { }
        public Processor( string producer, string series, string model, int cores, int freq, int maxFreq, int bitArch, int l1, int l2, int l3)
        {
            Producer = producer;
            Series = series;
            Model = model;
            CountOfCores = cores;
            Frequency = freq;
            MaxFrequency = maxFreq;
            BitArchitecture = bitArch;
            CacheL1 = l1;
            CacheL2 = l2;
            CacheL3 = l3;

        }
        
    }
}
