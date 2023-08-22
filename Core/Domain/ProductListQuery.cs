using MediatR;

namespace Core.Domain
{
    public class ProductListQuery : IRequest<List<ProductDTO>>
    {
        
    }
}