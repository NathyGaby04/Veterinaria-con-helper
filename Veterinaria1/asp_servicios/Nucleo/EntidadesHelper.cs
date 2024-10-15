using System.Net.NetworkInformation;

namespace asp_servicios.Nucleo
{
    public class EntidadesHelper
    {
        public static Pacientes ObtenerPacientes()
        {
            return new Pacientes()
            {
                Nombre = "Cloy",
                Fecha_Nacimiento = DateTime.Parse("2014/02/12"),
                Raza = "Pudel",
                Estado = true,
            };
        }
        public static Pacientes ObtenerPacientes2()
        {
            return new Pacientes()
            {
                Nombre = "Juana",
                Fecha_Nacimiento = DateTime.Parse("2020/06/25"),
                Raza = "Pudel",
                Estado = false,
            };
        }
        public static Pacientes ObtenerPacientes3()
        {
            return new Pacientes()
            {
                Nombre = "Cesar",
                Fecha_Nacimiento = DateTime.Parse("2019/08/22"),
                Raza = "Angora",
                Estado = true,
            };
        }
        public static Pacientes ObtenerPacientes4()
        {
            return new Pacientes()
            {
                Nombre = "Mango",
                Fecha_Nacimiento = DateTime.Parse("2018/12/22"),
                Raza = "Negro",
                Estado = false,
            };
        }
        public static Citas ObtenerCitas()
        {
            return new Citas()
            {
                Fecha = DateTime.Parse("2024/10/02"),
                Diagnostico = "Muy linda",
                Paciente = 1,
            };
        }
        public static Citas ObtenerCitas2()
        {
            return new Citas()
            {
                Fecha = DateTime.Parse("2024/10/19"),
                Diagnostico = "...",
                Paciente = 2,
            };
        }
        public static Citas ObtenerCitas3()
        {
            return new Citas()
            {
                Fecha = DateTime.Parse("2021/09/10"),
                Diagnostico = "Muy lindo",
                Paciente = 3,
            };
        }
    }
}