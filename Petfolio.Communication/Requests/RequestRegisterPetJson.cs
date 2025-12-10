using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests
{
    public class RequestRegisterPetJson
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Breed { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public PetType Type { get; set; } = PetType.Cat;
    }
}