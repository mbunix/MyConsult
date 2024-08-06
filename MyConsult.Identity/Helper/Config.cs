
using Duende.IdentityServer.Models;


namespace MyConsult.Identity.Helper
{
    public static class Config
    {
        public const string Admin = "admin";
        public const string User = "user";
        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("medical_api", "Medical API"),
                new ApiResource("financial_api", "Financial API"),
                new ApiResource("insurance_api","Insurance API"),
                new ApiResource("motorvehicle_api","Motor Vehicle API")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };
            

        
    }
}