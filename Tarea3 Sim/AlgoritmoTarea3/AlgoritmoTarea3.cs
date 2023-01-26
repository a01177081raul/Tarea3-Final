using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3_Sim.Clases3;

namespace Tarea3_Sim.AlgoritmoTarea3
{
    public class Algoritmotarea3
    {
        public List<Clase3> listaNumeros = new List<Clase3>();
        public Algoritmotarea3()
        {

        }
        public int CalcularMetodo(List<Clase3> listaNumeros)
        {
            int a =0, b=0,c=0,semilla=0, numeroDatos=0, x=0, y=0, z=0;
            //Creo que tenemos que borrar int semilla arriba
            for (int i = 0; i < numeroDatos; i++)
            {
                x = semilla;
                y = (a*x) + b;
                z = y % c; 
            }
            return x;
            return y;
            return z;

        }
        public void llenarDatos(int numeroDatos, int x, int y, int z, List<int>listaDatos)
        {
            Clase3 demanda3 = new Clase3();
            demanda3.IdDemanda=x;
            demanda3.CantidadRequerida=y;
            demanda3.CantidadProgramada=z;
            demanda3.numeroDatos=numeroDatos;
            listaNumeros.Add(demanda3);
        }
        //Main
        public int CalcularZ(List<Clase3> listaNumeros, int a, int b, int c)
        {
            int x = 0, y = 0, z = 0;
            foreach (Clase3 demanda3 in listaNumeros)
            {
                y = (a * x) + b;
                z = y % c;
            }
            if (listaNumeros.Count() > 0)
            {
                x = z;
            }
            return x;
            return y;
            return z;
        }

    }
}