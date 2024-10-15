using Microsoft.AspNetCore.Mvc;
using asp_servicios.Nucleo;
using Microsoft.EntityFrameworkCore;

namespace asp_servicios.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CitasController : ControllerBase
    {
        [HttpGet(Name = "GetCitas")]
        public IEnumerable<Citas> Get()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=LAPTOP-1ITG8EDT\\SQLEXPRESS;database=db_veterinaria;Integrated Security=True;TrustServerCertificate=true;";
            conexion.Database.Migrate();

            conexion.Guardar(EntidadesHelper.ObtenerCitas3());
            conexion.SaveChanges();
            return conexion.Listar<Citas>();
        }
    }
}
