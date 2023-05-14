using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainReponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
        }
        public abstract void ProcessRequest(ProcessViewModel processViewModel);
        
    }
}
