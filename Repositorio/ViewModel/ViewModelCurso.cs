using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelCurso : IViewModel<Curso>
    {



        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public System.DateTime Inicio { get; set; }
        public System.DateTime Fin { get; set; }
        public int IdAula { get; set; }




        public void FromBaseDatos(Curso modelo)
        {
            IdCurso = modelo.IdCurso;
            Nombre = modelo.Nombre;
            Duracion = modelo.Duracion;
            Inicio = modelo.Inicio;
            Fin = modelo.Fin;

        }


        public Curso ToBaseDatos()
        {
            return new Curso()
            {
                IdAula = IdAula,
                IdCurso = IdCurso,
                Nombre = Nombre,
                Duracion = Duracion,
                Inicio = Inicio,
                Fin = Fin
            };
        }

        public void UpdateBaseDatos(Curso modelo)
        {
            modelo.IdAula = IdAula;
            modelo.IdCurso = IdCurso;
            modelo.Nombre = Nombre;
            modelo.Duracion = Duracion;
            modelo.Inicio = Inicio;
            modelo.Fin = Fin;
        }



        public object[] GetKeys()
        {
            throw new NotImplementedException();
        }

    }



}
