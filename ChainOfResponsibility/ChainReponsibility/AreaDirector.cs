using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainReponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(ProcessViewModel processViewModel)
        {
            Context context = new Context();
            if (processViewModel.Amount <= 350000)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Bölge Müdürü - Fatoş Kara";
                process.EmployeeName = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi.";
                context.Processes.Add(process);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                Process process = new Process();
                process.Amount = processViewModel.Amount.ToString();
                process.Name = processViewModel.Name;
                process.EmployeeName = "Bölge Müdürü - Fatoş Kara";
                process.EmployeeName = "Para Çekme Tutarı Bölge Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi. Müşterinin Maksimum Çekebileceği Tutar 400.000₺ Olduğundan Daha Fazlası İçin Şubeye Farklı Günlerde Gelmesi Gerekmektedir.";
                context.Processes.Add(process);
                context.SaveChanges();
                NextApprover.ProcessRequest(processViewModel);
            }
        }
    }
}
