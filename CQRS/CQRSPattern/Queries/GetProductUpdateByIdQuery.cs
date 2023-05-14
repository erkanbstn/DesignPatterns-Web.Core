namespace CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }

    }
}
