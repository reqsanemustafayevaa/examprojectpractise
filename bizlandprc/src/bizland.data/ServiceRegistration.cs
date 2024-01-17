using bizland.core.Repository.Interfaces;
using bizland.data.Repository.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bizland.data
{
    public static class ServiceRegistration
    {
        public static void AddReposiories(this IServiceCollection services)
        {
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
        }
    }
}
