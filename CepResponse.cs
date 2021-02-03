﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Consulta_de_cep
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidades")]
        public string Localidades { get; set; }
        [JsonProperty("uf")]
        public string UF { get; set; }
        [JsonProperty("ibge ")]
        public string IBGE { get; set; }
        [JsonProperty("gia")]
        public string GIA { get; set; }
        [JsonProperty("ddd")]
        public string DDD { get; set; }
        [JsonProperty("siafi")]
        public string SIAFI { get; set; }
    }
}
