using SOLIDPrinciples.Single_Responsibilty_Principle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Single_Responsibilty_Principle.TrueExample
{
    public class TrueEmployeeProcess
    {
        TrueLogerProcess logger;
        public TrueEmployeeProcess()
        {
            logger = new TrueLogerProcess();
        }

        string log;

        public bool InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\YMS5175Log.txt", log);

                log = logger.BuildLog("Employee insert succesfull: " + employee.Id);
                logger.LogFile(@"C:\YMS5175Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                log = logger.BuildLog("Hata Mesajı: " + ex.Message);
                logger.LogFile(@"C:\YMS5175Log.txt", log);

                return false;
            }
        }

    }
}
