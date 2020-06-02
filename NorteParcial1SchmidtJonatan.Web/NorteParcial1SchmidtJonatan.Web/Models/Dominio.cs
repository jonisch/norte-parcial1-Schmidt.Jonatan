using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorteParcial1SchmidtJonatan.Web.Models
{
    public class Dominio
    {
        private static List<Constelacion> constelaciones = new List<Constelacion>();

        public static void Add(Constelacion constelacion)
        {
            constelaciones.Add(constelacion);
        }


        public static List<Constelacion> Get()
        {
            return constelaciones;
        }
    }
}