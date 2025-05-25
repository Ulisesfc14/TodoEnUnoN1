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
     //Laboratorio con metodos

     //Metodos sin parametros
     void MetodoUno()
      {
        Console.WriteLine("Metodo sin parametros. Void\n");

      }
     //Metodo con parametros del mismo tipo
     void MetodoDos(string strNombre)
      {
        Console.Writeline(strNombre + "es mi primer nombre");
      }
      //Metodo con dos parametros de distintos tipos
      void MetodoTres(string strNombre, double dblNota1)
      {
        Console.WriteLine(strNombre + ", es mi nombre."+
                                 " y mi nota final fue" + dblNota1):
      }

    }//main
  }
} 
