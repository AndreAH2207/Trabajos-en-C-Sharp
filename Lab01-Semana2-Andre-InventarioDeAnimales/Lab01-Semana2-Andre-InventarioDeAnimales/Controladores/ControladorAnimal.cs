using Lab01_Semana2_Andre_InventarioDeAnimales.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Semana2_Andre_InventarioDeAnimales.Controladores
{
    internal class ControladorAnimal
    {
        private CAnimal[] animales = new CAnimal[100];
        private int contador = 0;

        public CAnimal[] ListarTodo()
        {
            return animales;
        }

        public void Registrar(CAnimal animal)
        {
            animales[contador] = animal;
            contador++;
        }

        public void Eliminar(string id)
        {
            int posicion = Array.FindIndex(animales, animal => animal.Id.Equals(id));

            for (int i = 0; i < contador; i++)
            {
                if (i >= posicion)
                {
                    animales[i] = animales[i + 1];
                }
            }
            contador--;
        }
        private class MetodoComparar: IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                //validar nulos
                if (x == null || y == null)
                {
                    return 1;
                }
                double Peso1 = ((CAnimal)x).Peso;
                double Peso2 = ((CAnimal)y).Peso;

                if (Peso1 < Peso2) return 1;
                else return -1;
            }
        }
        public CAnimal[] Ordenar()
        {
            Array.Sort(animales, 0, contador, new MetodoComparar());
            return animales;
        }
    }
}
