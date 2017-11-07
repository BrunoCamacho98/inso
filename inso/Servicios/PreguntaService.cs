using inso.Models;
using inso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inso.Servicios
{
    public class PreguntaService : IPreguntaServices
    {
        IPreguntaRepository preg;

        public PreguntaService()
        {
            preg = new PreguntaRepository();
        }
        public List<Pregunta> ReadPreg()
        {
            return preg.Reader();
        }
    }
}