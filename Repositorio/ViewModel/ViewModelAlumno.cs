using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelAlumno:IViewModel<Alumno>                       // HABRÍA QUE CREAR LO MISMO TAMBIÉN PARA AULA, CURSO, PROFESOR, PROFESORCURSO... //
    {

        public string Nombre { get; set; }
        public string DNI { get; set; }
        public List<String>Cursos { get; set; }



        public Alumno ToBaseDatos()                                 // ESTO LO METE EN LA BBDD //
        {
            var al = new Alumno()

            {
                DNI = DNI,
                Nombre = Nombre
            };
            return al;
        }


         
        public void FromBaseDatos(Alumno modelo)                    // ESTO RECIBE LOS DATOS DE LA BBDD //
        {
            DNI = modelo.DNI;
            Nombre = modelo.Nombre;
        }




        public void UpdateBaseDatos(Alumno modelo)                    // ESTO ACTUALIZA LOS DATOS DE LA BBDD //
        {
            modelo.DNI = DNI;
            modelo.Nombre = Nombre;
        }

        public object[] GetKeys()
        {
            return new[] { DNI };
        }
    }

   




}
