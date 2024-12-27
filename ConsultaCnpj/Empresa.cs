using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCnpj
{
    public class Empresa
    {
        [JsonProperty("NOME FANTASIA")]
        public string NOMEFANTASIA { get; set; }

        [JsonProperty("RAZAO SOCIAL")]
        public string RAZAOSOCIAL { get; set; }
        public string CNPJ { get; set; }
        public string STATUS { get; set; }

        [JsonProperty("CNAE PRINCIPAL DESCRICAO")]
        public string CNAEPRINCIPALDESCRICAO { get; set; }

        [JsonProperty("CNAE PRINCIPAL CODIGO")]
        public string CNAEPRINCIPALCODIGO { get; set; }
        public string CEP { get; set; }

        [JsonProperty("DATA ABERTURA")]
        public string DATAABERTURA { get; set; }
        public string DDD { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }

        [JsonProperty("TIPO LOGRADOURO")]
        public string TIPOLOGRADOURO { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string MUNICIPIO { get; set; }
        public string UF { get; set; }
        public string error { get; set; }
    }
}
