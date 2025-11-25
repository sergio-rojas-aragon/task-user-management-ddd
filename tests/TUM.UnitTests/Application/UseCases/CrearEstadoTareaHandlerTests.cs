using TUM.Application.DTOs;
using TUM.Application.UseCases.EstadoTareaCases;
using TUM.UnitTests.Fakes;

namespace TUM.UnitTests.Application.UseCases
{
    
    public class CrearEstadoTareaHandlerTests
    {
        [Fact]
        public async Task CrearEstado_DeberiaCrearEstadoCorrectamente()
        {
            var estadoTareaRepo = new FakeEstadoTareaRepository();
            var handler = new CrearEstadoTareaHandler(estadoTareaRepo);

            var dto = new CrearEstadoTareaDTO
            {
                Nombre = "nuevo estado"
            };

            string userId = Guid.NewGuid().ToString();
            //Act

            var estadoTareaId = await handler.Handle(dto, userId);

            //Assert
            Assert.True(estadoTareaId > 0);
            var estadoTareas = estadoTareaRepo.GetAll();
            Assert.Single(estadoTareas);
        }
    }
}
