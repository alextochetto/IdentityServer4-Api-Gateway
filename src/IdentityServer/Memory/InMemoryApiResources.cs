using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Memory
{
    public class InMemoryApiResources
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                //new ApiResource
                //{
                //    Name = "IntegracaoApiResource",
                //    DisplayName = "Permite acesso a API de Integração Externa"
                //},
                new ApiResource("IntegracaoApiResource", "Permite acesso a API de Integração Externa"),
                new ApiResource("ServicoApiResource", "Permite acesso a API dos Serviços"),
                new ApiResource("ServicoAppApiResource","Permite acesso a Api dos Serviçõs para Mobile")
            };
        }
    }
}