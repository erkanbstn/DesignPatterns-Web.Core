namespace CQRS.CQRSPattern.Commands
{
    public class RemoveProductCommand
    {
        public int ProductId { get; set; }

        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }
    }
}
