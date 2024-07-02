using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace MyConsult.Identity.Helper
{
    public class Config
    {
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
            };
            

        
    }
}