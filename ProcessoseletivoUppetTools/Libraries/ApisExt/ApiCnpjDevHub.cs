

using ProcessoseletivoUppetTools.Models;
using ProcessoseletivoUppetTools.Models.RetornoApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProcessoseletivoUppetTools.Libraries.ApisExt
{

    public class ApiCnpjDevHub
    {
        private string URL = "http://ws.hubdodesenvolvedor.com.br/v2/cnpj/?";
        private string parametros = "?formato=json";
        private string token = // colocar  o token do site https://www.hubdodesenvolvedor.com.br


        public Root RetornoApi(string Cnpj)
        {

            HttpClient client = new HttpClient();
            var baseAddress = new Uri(URL);
            client.BaseAddress = baseAddress;

            HttpResponseMessage response = client.GetAsync("?cnpj=" + Cnpj + "&token=" + token).Result;

            string json = response.Content.ReadAsStringAsync().Result;

            Root objetos = JsonSerializer.Deserialize<Root>(json);


            return objetos;
        }

        public Empresa AdicionarEmpresa(Result result)
        {
            AtividadePrincipal principal = result.atividade_principal;


            Empresa empresa = new Empresa()
            {
                Nome = result.nome,
                Fantasia = result.fantasia,
                Logradouro = result.logradouro,
                Numero = result.numero,
                Bairro = result.bairro,
                Cep = result.cep,
                UF = result.uf,
                Situacao = result.situacao,
                Porte = result.porte,

                Cnpj = Convert.ToUInt64(result.numero_de_inscricao).ToString(@"00\.000\.000\/0000\-00"),
                // Preencher os dados da empresa usando o result e o principal para a atvprinc TODO
            };


            return empresa;
        }
    }
}
