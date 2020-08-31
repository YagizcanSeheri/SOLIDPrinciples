using SOLIDPrinciples.Single_Responsibilty_Principle.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Single_Responsibilty_Principle.FalseExample
{
    public class FalseEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                //Çalışan ekleme işlemi
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                File.WriteAllText(@"C:\YMS5175EmployeeData.txt", sb.ToString());

                //Çalışan ekleme işlemini logları
                sb = new StringBuilder();
                sb.Append("Kayıt Ekleme Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newEmployee.Id);
                File.WriteAllText(@"C:\YMS5175Log.txt", sb.ToString());
            }
            catch (Exception ex)
            {
                //Ekleme işleminde hata alınırsa
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\YMS5175Log.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Hata..!");
            }
        }
    }
}
