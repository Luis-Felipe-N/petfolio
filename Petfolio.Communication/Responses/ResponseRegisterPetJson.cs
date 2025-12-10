using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petfolio.Communication.Responses
{
    public class ResponseRegisterPetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}