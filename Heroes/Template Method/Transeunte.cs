using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Template_Method
{
    public class Transeunte : IInfartable
    {
        double  probabilidad = 0.2;
      
        Random probabilidadAComparar = new Random();

        //implementacoion de la interface IInfartable
        public bool estasConciente() {
            return probabilidadAComparar.NextDouble() < probabilidad;
        }

        public bool estasRespirando() {

            return probabilidadAComparar.NextDouble() < probabilidad;
        }
 
        public bool tieneRidmoCardiaco() {
            return probabilidadAComparar.NextDouble() < probabilidad;
        }         
    }
}
