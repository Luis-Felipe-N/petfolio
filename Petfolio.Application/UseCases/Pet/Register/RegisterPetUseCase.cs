using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPetJson Execute(RequestRegisterPetJson request)
        {
            // Implementation of the use case to register a pet
            return new ResponseRegisterPetJson
            {
                Id = 1,
                Name = request.Name
            };
        }
    }
}