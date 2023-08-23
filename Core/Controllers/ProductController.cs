using AutoMapper;
using Core.Domain;
using Core.obj;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new ProductListQuery()));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductDTO product)
        {
            var command = _mapper.Map<CreateProductCommand>(product);
            return Ok(await _mediator.Send(command));
        }
    }
}