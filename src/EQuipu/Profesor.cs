using System;
using EQuipu.utils;

namespace EQuipu
{
    public class Profesor : Miembro
    {
        private int codigoProfesor;
        private string estado;

        public Profesor(int codigo, int codigoProfesor, string nombre, DateTime fechaNacimiento, string direccion,
            string email, Sexo sexo, string estado = null)
            : base(codigo, nombre, fechaNacimiento, direccion, email, sexo)
        {
            this.CodigoProfesor = codigoProfesor;
            this.Estado = estado;
        }

        public int CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
