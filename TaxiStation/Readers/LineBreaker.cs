using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TaxiStations.Interfaces;
using TaxiStations.Models;
using System.Text.RegularExpressions;

namespace TaxiStations.Readers
{
    class LineBreaker : IBreakLine
    {
        public string [] ReturnWordArr(char symbol, string str)
        {
            return str.Split(new char[] { symbol }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
        }
    }
}
