using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.DTOs;
using TUM.Application.Validators;

namespace TUM.UnitTests.Validators
{
    public class CreaEstadoTareaValidatorTests
    {
        [Fact]
        public void DeberiaFallarSiTieneMenosCaracteres()
        {
            var dto = new CrearEstadoTareaDTO
            {
                Nombre = "a"
            };

            var validator = new CrearEstadoTareaDtoValidator();
            var result = validator.Validate(dto);

            // valido que valida
            Assert.False(result.IsValid);

            // valido que la respuesta esta bien, si no es la misma saldra error
            Assert.Contains(result.Errors, e => e.ErrorMessage.Contains("Tiene que tener al menos 3 caracteres"));

        }

    }
}
