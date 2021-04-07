using System;

namespace POO
{
    public class Estudiantes
    {
        public string nombre;
        public string carnet;
        public int edad;
        public Boolean solvente;
        public Estudiantes(string nombre, string carnet, int edad, Boolean solvente){
            this.nombre = nombre;
            this.carnet = carnet;
            this.edad = edad;
            this.solvente = solvente;
        }
    }
}
