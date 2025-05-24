using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //SECCION DE VARIABLES
      string NombreEstudiante, CiudadEstudiante,
      CorreoEstudiante,
      TelefonoEstudiante, EstadoCurso;

      int EdadEstudiante, TotalRegistros = 10, cont = 1;

      double promedio, DctoTotal, PrecioMatricula, PrecioFinal;

      ////CUESTIONARIO
      ////Solicitar edad;
      //Console.WriteLine("Por favor digitar la edad:");
      //EdadEstudiante = Convert.ToInt32(Console.ReadLine());

      ////Si edad >= 18 entonces
      ////Solicitar datos;
      //if (EdadEstudiante >= 18)
      //{
      //  //Solicitar Nombre;
      //  Console.WriteLine("Digitar nombre:");
      //  NombreEstudiante = Console.ReadLine();
      //  //Solicitar Ciudad;
      //  Console.WriteLine("Digitar ciudad:");
      //  CiudadEstudiante = Console.ReadLine();
      //  //Solicitar Correo;
      //  Console.WriteLine("Digitar correo:");
      //  CorreoEstudiante = Console.ReadLine();
      //  //Solicitar Telefono;
      //  Console.WriteLine("Digitar telefono:");
      //  TelefonoEstudiante = Console.ReadLine();

      //  Console.WriteLine("Se procede a registrar a estudiante");
      //  //RegistrarEstudiante(); // Método. 

      //}
      //else
      //{
      //  Console.WriteLine("No cumple con la edad Minima");
      //}
      ///
      // EVALUAR ESTADO DEL CURSO (ACTIVO/INACTIVO)
      if (TotalRegistros >= 10)
      {
        //Modificar ESTADOCURSO a Activo
        EstadoCurso = "Activo";
        Console.WriteLine("Curso en estado:" + EstadoCurso);
        Console.ReadKey();

        //Proceso de evaluar promedio y aplicacion del descuento
        //EXISTE REGISTRO EN BASE DE DATOS DE 5 ESTUDIANTES

        while (cont <= TotalRegistros)
        {
          //Solicitar promedio
          Console.WriteLine("Cuál es su promedio:");
          promedio = double.Parse(Console.ReadLine());
          if (promedio >= 4.5)
          {
            //Solicitar Precio matricula
            Console.WriteLine("Cuál es el precio de Matricula:");

            PrecioMatricula = double.Parse(Console.ReadLine());
            DctoTotal = PrecioMatricula * 0.10;
            //PrecioFinal
            PrecioFinal = PrecioMatricula - DctoTotal;
            //Resultado
            Console.WriteLine("El total del descuento aplicado: {0:C}\n", DctoTotal);
            Console.WriteLine("El total de la matricula es: {0:C}\n", PrecioFinal);
            Console.ReadKey();
          }
          else
          {
            Console.WriteLine("No se aplica descuento");
            Console.ReadKey();
          }
          //Incremento de contador
          cont++;
        }//while

      }
      else
      {
        EstadoCurso = "Inactivo";
        Console.WriteLine("Curso en estado:" + EstadoCurso);
        Console.ReadKey();
      }
    }
  }
}
