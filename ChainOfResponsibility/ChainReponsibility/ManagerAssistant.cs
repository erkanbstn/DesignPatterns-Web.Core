using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainReponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(ProcessViewModel processViewModel)
        {
            Context context = new Context();
            if (processViewModel.Amount <= 150000)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Şube Müdür Yardımcısı - Büşra Hekimoğlu";
                process.EmployeeName = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi.";
                context.Processes.Add(process);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Şube Müdür Yardımcısı - Büşra Hekimoğlu";
                process.EmployeeName = "Para Çekme Tutarı Şube Müdür Yardımcısının Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Şube Müdürüne Yönlendirildi.";
                context.Processes.Add(process);
                context.SaveChanges();
                NextApprover.ProcessRequest(processViewModel);
            }
        }
    }
}
