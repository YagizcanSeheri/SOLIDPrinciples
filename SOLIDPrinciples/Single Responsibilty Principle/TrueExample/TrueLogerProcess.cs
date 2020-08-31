using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Single_Responsibilty_Principle.TrueExample
{
    public class TrueLogerProcess
    {
        public void LogFile(string filePath, string log)
        {
            File.WriteAllText(filePath, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information: ").Append(information);

            return sb.ToString();
        }
    }
}
