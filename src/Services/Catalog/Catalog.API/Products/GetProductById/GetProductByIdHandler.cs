
namespace Catalog.API.Products.GetProducts;

public record GetProductByIdQuery(Guid Id): IQuery<GetProductByIdResult>;

public record GetProductByIdResult(Product Product);


internal class GetProductByIdQueryHandler(IDocumentSession session, ILogger<GetProductByIdQueryHandler> logger)
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductByIdQueryHandler.Handle called with {@Query}", query);

        var product = await session.LoadAsync<Product>(query.Id, cancellationToken);
        if (product is null)
        {
            logger.LogWarning("Product with Id {Id} not found", query.Id);
            throw new ProductNotFoundException($"Product with Id {query.Id} not found in the catalog.");
        } else
        {
            return new GetProductByIdResult(product);
        }
    }
}
