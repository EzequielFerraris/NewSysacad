﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BibliotecaNewSysacad
{
    public enum dia
    {
        Lunes,
        Martes,
        Miércoles,
        Jueves,
        Viernes,
    }

    public enum turno
    {
        Mañana,
        Tarde,
        Noche
    }
    public class Curso
    {
        private string nombre;
        private int codigo;
        private string descripcion;
        private int cupoMaximo;
        private List<int> estudiantesInscriptos;
        private dia diaCursada;
        private turno turnoCursada;
        
        public Curso()
        {
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.cupoMaximo = 0;
            this.codigo = 0;
            estudiantesInscriptos = new List<int>();
        }
        public Curso(string nombre, string descripcion, int cupoMaximo, int codigo, dia diaCursada, turno turnoCursada)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cupoMaximo = cupoMaximo;
            this.codigo = codigo;
            this.diaCursada = diaCursada;
            this.turnoCursada = turnoCursada;
            estudiantesInscriptos = new List<int>();
        }

        public string Nombre 
        { 
            get => nombre;
            set
            {
                if (Validaciones.ValidarNombreCurso(value))
                {
                    nombre = value;
                }
            }
        }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value > 0 && value < 100000)
                {
                    codigo = value;
                }
            }
        }

        public string Descripcion 
        { 
            get => descripcion; 
            set
            {
                if (Validaciones.ValidarDescripcion(value))
                {
                    descripcion = value;
                }
            }
        }

        public int CupoMaximo
        {
            get => cupoMaximo;
            set
            {
                if(value > 0 && value < 100)
                {
                    cupoMaximo = value;
                }
            }
        }

        public List<int> EstudiantesInscriptos
        {
            get => estudiantesInscriptos;
            set => estudiantesInscriptos = value;
        }
        public dia DiaCursada
        {
            get => diaCursada;
            set => diaCursada = value;
        }
        public turno TurnoCursada
        {
            get => turnoCursada;
            set => turnoCursada = value;
        }

        public bool InscribirEstudiante(Estudiante estudianteNuevo, out string error) 
        {
            bool resultado = true;
            error = "";

            if (this.CupoMaximo == this.CantidadInscriptos())
            {
                error = "Curso sin cupos.";
                resultado = false;
            }
            else
            {
                foreach (int legajo in estudiantesInscriptos)
                {
                    if (legajo == estudianteNuevo.Legajo)
                    {
                        error = "Usuario ya inscripto.";
                        resultado = false;
                        break;
                    }
                }
            }
            
            if(resultado)
            {
                estudiantesInscriptos.Add(estudianteNuevo.Legajo);
            }
            
            return resultado;
        }

        public int CantidadInscriptos()
        { 
            return estudiantesInscriptos.Count(); 
        }
    }

   
}