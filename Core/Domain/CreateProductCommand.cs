using MediatR;

namespace Core.obj
{
    public class CreateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Coust { get; set; }
        public string Key { get; set; }
    }
}