using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;
using System.Security.Claims;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("ECommerce.API", "E-Commerce API")
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "client",
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                ClientSecrets = { new Secret("secret".Sha256()) },

                AllowedScopes = { "myapi" }
            }
        };

    public static List<TestUser> TestUsers =>
        new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1",
                Username = "alice",
                Password = "password",
                Claims = new List<Claim>
                {
                    new Claim("name", "Alice"),
                    new Claim("website", "https://alice.com")
                }
            }
        };
}
