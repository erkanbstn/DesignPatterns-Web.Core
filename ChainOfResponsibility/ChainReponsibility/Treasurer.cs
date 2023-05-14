using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;
using System.Diagnostics;
using Process = ChainOfResponsibility.DAL.Process;

namespace ChainOfResponsibility.ChainReponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(ProcessViewModel processViewModel)
        {
            Context context = new Context();
            if (processViewModel.Amount <= 100000)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Veznedar - Erkan Bostan";
                process.EmployeeName = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi.";
                context.Processes.Add(process);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Veznedar - Erkan Bostan";
                process.EmployeeName = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Şube Müdür Yardımcısına Yönlendirildi.";
                context.Processes.Add(process);
                context.SaveChanges();
                NextApprover.ProcessRequest(processViewModel);
            }

        }
    }
}
