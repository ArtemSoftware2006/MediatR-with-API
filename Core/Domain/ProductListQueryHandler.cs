using MediatR;

namespace Core.Domain
{
    public class ProductListQueryHandler : IRequestHandler<ProductListQuery, List<ProductDTO>>
    {
        private readonly Store _store;
        public ProductListQueryHandler(Store store)
        {
            _store = store;
        }

        public Task<List<ProductDTO>> Handle(ProductListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}