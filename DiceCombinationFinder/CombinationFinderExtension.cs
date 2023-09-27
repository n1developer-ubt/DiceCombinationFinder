using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DiceCombinationFinder
{
    public static class CombinationFinderExtension
    {
        static string EvenOddPattern(List<int> arr)
        {
            if (arr.Count == 0)
            {
                return "";
            }

            string pattern = string.Join("", arr
                .Select((num, index) => (num % 2 == 0) ? "e" : "o")
                .ToArray());

            return pattern.ToUpper();
        }

        public static ExportOutput Export(this List<Output> output)
        {
            var exportData = new ExportOutput()
            {
                Min = 1,
                Max = int.MinValue,
                Data = new List<ExportData>()
            };

            var sums = new List<int>();

            foreach (var co in output)
            {  

                var cp = EvenOddPattern(co.Filter); 
                var cs = co.Filter.Sum();

                if(!sums.Contains(cs))
                    sums.Add(cs);

                ExportData ced = null;
                // Check if cs is already in outs
                if (exportData.Data.FirstOrDefault(d=>d.Name.Equals(cs+"")) == null)
                {
                    ced = new ExportData()
                    {
                        Name = cs + "",
                        Data = new Dictionary<string, int>()
                    };
                    exportData.Data.Add(ced); 
                }
                else
                {
                    ced = exportData.Data.FirstOrDefault(d => d.Name.Equals(cs + ""));
                }

                // Check if cp is already in outs[cs]
                if (!ced.Data.ContainsKey(cp))
                {
                    ced.Data[cp] = 0;
                } 
                 
                ced.Data[cp] += 1;
                exportData.Max = Math.Max(exportData.Max, ced.Data[cp]);  
            }

            //sum all patters value

            foreach (var cd in exportData.Data)
            {
                var sum = 0;

                foreach (var @out2 in cd.Data)
                {
                    sum += @out2.Value;
                }

                cd.Sum = sum;
            }

            sums.Sort();
            exportData.Sums = sums;
            return exportData;
        }
    }

    public class ExportOutput
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 0;
        public List<int> Faces { get; set; }
        public int Rolls { get; set; }
        public List<int> Sums { get; set; } = new List<int>();
        public List<ExportData> Data { get; set; }
    }

    public class ExportData
    {
        public string Name { get; set; } = "";
        public int Sum { get; set; } = 0;
        public Dictionary<string, int> Data = new Dictionary<string, int>();
    }
}
