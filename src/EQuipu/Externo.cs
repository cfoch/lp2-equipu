using System;
using EQuipu.utils;

namespace EQuipu
{
    public class Externo : Miembro
    {
        private Dedicacion dedicacion;
        private string tipo;
   
        public Externo(int codigo, string nombre, DateTime fechaNacimiento, string direccion, string email, Sexo sexo,
            Dedicacion dedicacion, string tipo)
            : base(codigo, nombre, fechaNacimiento, direccion, email, sexo)
        {
            this.Dedicacion = dedicacion;
            this.Tipo = tipo;
        }

        public Dedicacion Dedicacion { get => dedicacion; set => dedicacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
