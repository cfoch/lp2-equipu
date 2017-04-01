using System;
using EQuipu.utils;

namespace EQuipu
{
    public class Alumno : Miembro
    {
        private int codigoAlumno;
        private double _CRAEST;

        public Alumno(int codigo, int codigoAlumno, string nombre, DateTime fechaNacimiento, string direccion,
            string email, Sexo sexo, double CRAEST)
            : base(codigo, nombre, fechaNacimiento, direccion, email, sexo)
        {
            this.CodigoAlumno = CodigoAlumno;
            this._CRAEST = CRAEST;
        }

        public int CodigoAlumno { get => codigoAlumno; set => codigoAlumno = value; }
        public double CRAEST { get => _CRAEST; set => _CRAEST = value; }
    }
}
