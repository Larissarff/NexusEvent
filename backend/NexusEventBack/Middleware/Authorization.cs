using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using NexusEventBack.Enums;


namespace NexusEventBack
{
    public static class AuthorizationPolicies
    {
        public static void AddCustomAuthorizationPolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();


                options.AddPolicy("PendingUser", policy =>
                {
                    policy.RequireRole(
                        "Intern",
                        "Secretary",
                        "Developer",
                        "Designer",
                        "Manager",
                        "CEO",
                        "CTO",
                        "CFO",
                        "President",
                        "Administrator"
                    );
                    policy.RequireClaim("access_status", "Pending", "Approved");
                });


                options.AddPolicy("LoggedUser", policy =>
                {
                    policy.RequireRole(
                        "Intern",
                        "Secretary",
                        "Developer",
                        "Designer",
                        "Manager",
                        "CEO",
                        "CTO",
                        "CFO",
                        "President",
                        "Administrator"
                    );
                    policy.RequireClaim("access_status", "Approved");
                });


                options.AddPolicy("SpecialRoles", policy =>
                {
                    policy.RequireRole(
                        "Manager",
                        "CEO",
                        "CTO",
                        "CFO",
                        "President",
                        "Administrator"
                    );
                    policy.RequireClaim("access_status", "Approved");
                });


                options.AddPolicy("PowerRole", policy =>
                {
                    policy.RequireRole(
                        "Administrator",
                        "President"
                    );
                    policy.RequireClaim("access_status", "Approved");
                });
               
                options.AddPolicy("AdmRole", policy =>
                {
                    policy.RequireRole(
                        "Administrator"
                    );
                    policy.RequireClaim("access_status", "Approved");
                });
            });
        }
    }
}
