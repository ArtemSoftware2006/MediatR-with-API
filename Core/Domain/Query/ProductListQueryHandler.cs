using MediatR;

namespace Core.Domain
{
    public class ProductListQueryHandler : IRequestHandler<ProductListQuery, ProductListVM>
    {
        private readonly Store _store;
        public ProductListQueryHandler(Store store)
        {
            _store = store;
        }

        public Task<ProductListVM> Handle(ProductListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}