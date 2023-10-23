using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class CalculatorProcessor
    {
        public string EvaluateExpression(string expression)
        {

            //DataTable = new DataTable();
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);

            DataRow row = table.NewRow();
            table.Rows.Add(row);

            table.Columns.Add("result", typeof(double), expression);

            double result = (double)row["result"];
            return result.ToString();
        }
    }
}
