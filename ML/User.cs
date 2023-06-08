using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class User
    {
        public string NombreUsuario { get; set; }
        public string Curp { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public char Sexo { get; set; }
        public string celular { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string FechaDeRegistro { get; set; }
        public DL.AspNetUser AspNetUser { get; set; }

    }
}
