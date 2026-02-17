using MediatR;

namespace Application.Features.Products.Commands
{
    public class CreateProductCommandHandler
    : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // later we will save to database
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
