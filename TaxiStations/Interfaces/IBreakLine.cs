using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStations.Models;

namespace TaxiStations.Interfaces
{
    public interface IBreakLine
    {

        string[] ReturnWordArr(char symbol, string str);
    }
}
