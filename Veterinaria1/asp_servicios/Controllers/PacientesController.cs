using Microsoft.AspNetCore.Mvc;
using asp_servicios.Nucleo;
using Microsoft.EntityFrameworkCore;

namespace asp_servicios.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PacientesController : ControllerBase
    {

        [HttpGet(Name = "GetPacientes")]
        public IEnumerable<Pacientes> Get()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=LAPTOP-1ITG8EDT\\SQLEXPRESS;database=db_veterinaria;Integrated Security=True;TrustServerCertificate=true;";
            conexion.Database.Migrate();

            conexion.Guardar(EntidadesHelper.ObtenerPacientes4());
            conexion.SaveChanges();
            return conexion.Listar<Pacientes>();
        }
        //[HttpPost]
        //public List<int> EdadPaciente()
        //{
        //    var conexion = new Conexion();
        //    conexion.StringConnection = "server=LAPTOP-1ITG8EDT\\SQLEXPRESS;database=db_veterinaria;Integrated Security=True;TrustServerCertificate=true;";
        //    var lista = conexion.Listar<Pacientes>();
        //    var Fecha = DateTime.Today;
        //    List<int> Edad = new List<int>();
        //    foreach (var x in lista)
        //    {
        //        Edad.Add(Fecha.Year - x.Fecha_Nacimiento.Year);
        //    }
        //    return Edad;
        //}

        [HttpPost]
        public List<int> EdadPaciente()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=LAPTOP-1ITG8EDT\\SQLEXPRESS;database=db_veterinaria;Integrated Security=True;TrustServerCertificate=true;";
            var lista = conexion.Listar<Pacientes>();
            var Fecha = DateTime.Today;
            List<int> Edad = new List<int>();
            foreach (var x in lista)
            {
                Edad.Add(Fecha.Subtract(x.Fecha_Nacimiento).Days/365);
            }
            return Edad;

        }
    }
}
