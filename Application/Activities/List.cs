using System.Collections.Generic;
using Domain;
using MediatR;



namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>>{}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context
            }

            public Task<LinkedList<Activity>> Handler(Query request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException;
            }
        }
    }
}