using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.DTOs;


namespace TUM.Application.Validators
{
    public class CrearEstadoTareaDtoValidator : AbstractValidator<CrearEstadoTareaDTO>
    {
        public CrearEstadoTareaDtoValidator()
        {
            RuleFor(x => x.Nombre).MinimumLength(3).WithMessage("Tiene que tener al menos 3 caracteres");
        }
    }
}
