using System.Security.Cryptography.X509Certificates;
using Core.obj;
using MediatR;

namespace Core.Domain
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly Store _store;

        public CreateProductCommandHandler(Store store)
        {
            _store = store;
        }

        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(1);
        }
    }
}