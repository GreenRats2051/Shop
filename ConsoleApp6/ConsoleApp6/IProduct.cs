using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IProduct
    {
        string GetName();
        decimal GetPrice();
        string GetDescription();
        decimal CalculateDeliveryCost(decimal distance);
    }
}
