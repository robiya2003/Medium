using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<UserModel> Users { get; set; }
        Task SaVeChangeAsync(CancellationToken cancellationToken = default);
    }
}
