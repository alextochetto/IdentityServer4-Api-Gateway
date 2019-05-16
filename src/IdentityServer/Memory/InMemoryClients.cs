using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Memory
{
    public class InMemoryClients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new Client[]
            {
                new Client
                {
                    ClientId = "Integracao",
                    ClientName = "Client para Integração Externa",
                    ClientSecrets = { new Secret("123456789".Sha256()) },
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "IntegracaoApiResource" } //Labes of the resources that we want do protect
                },
                new Client
                {
                    ClientId = "Servico",
                    ClientName = "Client para Serviços",
                    ClientSecrets = { new Secret("123456789".Sha256()) },
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "ServicoApiResource" } //Labes of the resources that we want do protect
                },
                new Client
                {
                    ClientId = "ServicoApp",
                    ClientName = "Client para Mobile",
                    ClientSecrets = { new Secret("123456789".Sha256()) },
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "ServicoAppApiResource" }, //Labes of the resources that we want do protect
                    AccessTokenLifetime = 86400 //In seconds - 24h
                }
            };
        }
    }
}