﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNewSysacad
{
    public class Estudiante : Persona
    {
        private string dni;
        private string calle;
        private string altura;
        private string telefono;
        public bool debeCambiarPassword;
        private int legajo;
        private List<int> codigoPagosLista;
        private List<Curso> cursosInscripto;

        public Estudiante()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.eMail = string.Empty;
            this.password = string.Empty;
            this.dni = string.Empty;
            this.calle = string.Empty;
            this.altura = string.Empty;
            this.telefono = string.Empty;

            codigoPagosLista = new List<int>();

            cursosInscripto = new List<Curso>();
            ActualizarCursosInscripto();
        }
        public Estudiante(string nombre, string apellido, string nombreUsuario, string eMail, string password, string dni, string calle, string altura, string telefono, bool debeCambiarPassword) : base(nombre, apellido, nombreUsuario, eMail, password) 
        {
            this.dni = dni;
            this.calle = calle;
            this.altura = altura;
            this.telefono = telefono;
            this.debeCambiarPassword = debeCambiarPassword;
            codigoPagosLista = new List<int>();

            cursosInscripto = new List<Curso>();
            ActualizarCursosInscripto();

        }

        public string Dni 
        {
            get => dni;
            set 
            {
                if(Validaciones.ValidarNumero(value, 7, 9))
                {
                    dni = value;
                }
            }
        }
        public string Calle
        {
            get => calle;
            set
            {
                if (Validaciones.ValidarCalle(value))
                {
                    calle = value;
                }
            }
        }

        public string Altura
        {
            get => altura;
            set
            {
                if (Validaciones.ValidarAltura(value))
                {
                    altura = value;
                }
            }
        }
        public string Telefono
        {
            get => telefono;
            set
            {
                if (Validaciones.ValidarNumero(value, 8, 12))
                {
                    telefono = value;
                }
            } 
        }

        public bool DebeCambiarPassword
        {
            get => debeCambiarPassword;
            set => debeCambiarPassword = value;
        }

        public int Legajo
        {
            get => legajo;
            set
            {
                if (legajo == default)
                { 
                    legajo = value; 
                }
            }
        }

        public List<Curso> CursosInscripto
        { 
            get => cursosInscripto; 
        }

        //CURSOS
        public bool ChequearDisponibilidad(Curso curso)
        {
            if(cursosInscripto.Count > 0)
            {
                foreach (Curso cursoInscripto in cursosInscripto)
                {
                    if (cursoInscripto.DiaCursada == curso.DiaCursada && cursoInscripto.TurnoCursada == curso.TurnoCursada)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;

        }

        public void AgregarCurso(Curso curso)
        {
            if(ChequearDisponibilidad(curso))
            {
                cursosInscripto.Add(curso);
            }
            
        }
        public void ActualizarCursosInscripto()
        {
            foreach(Curso curso in NewSysacad.ListaCursos)
            {
                foreach(int estudiante in curso.EstudiantesInscriptos) 
                { 
                    if(estudiante == this.Legajo) 
                    {
                        AgregarCurso(curso);
                    }
                }
            }
        }

    }
}
