using System;
using EQuipu.utils;

namespace EQuipu
{
    public class Miembro
    {
        private int codigo;
        private string nombre;
        private DateTime fecha_nacimiento;
        private string direccion;
        private string email;
        private Sexo sexo;

        public Miembro(int codigo, string nombre, DateTime fecha_nacimiento, string direccion, string email, Sexo sexo)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Direccion = direccion;
            this.Email = email;
            this.Sexo = sexo;
        }

        public int Codigo { get => codigo; private set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public Sexo Sexo { get => sexo; set => sexo = value; }
    }
}
