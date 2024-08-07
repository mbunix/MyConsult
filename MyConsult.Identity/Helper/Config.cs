
using Duende.IdentityServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Myconsult.Identity.Helper;


namespace MyConsult.Identity.Helper
{

    public class Config
    {
        public const string Admin = "admin";
        public const string User = "user";

        private IOptions<IdentitySettings> Settings;
        private static string SharedSecret;
        public Config(IOptions<IdentitySettings> settings)
        {
            Settings = settings;
            SharedSecret = settings.Value.SharedSecret;

        }

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


        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("medical_api", "Medical API"),
                new ApiScope("financial_api", "Financial API"),
                new ApiScope("insurance_api","Insurance API"),
                new ApiScope("motorvehicle_api","Motor Vehicle API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {

                new Client
                {
                    ClientId = "medical.client",
                    ClientSecrets= { new Secret( SharedSecret.Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "medical_api" }
                },

                new Client
                {
                    ClientId = "financial.client",
                    ClientSecrets = { new Secret(SharedSecret.Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "financial_api" }
                },
                new Client
                {
                    ClientId = "insurance.client",

                    ClientSecrets = { new Secret(SharedSecret.Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "insurance_api" }
                },

                new Client
                {
                    ClientId = "motorvehicle.client",
                    ClientSecrets = { new Secret(SharedSecret.Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "motorvehicle_api" },
                    RedirectUris = { "https://localhost:5004/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:5004/signout-callback-oidc" },
                    AllowedCorsOrigins = { "https://localhost:5004" }

                }



            };


    }
}