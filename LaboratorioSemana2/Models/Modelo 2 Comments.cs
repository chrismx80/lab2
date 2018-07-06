using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioSemana2.Models
{
    public class Modelo_2_Comments// Este modelo es par los commments

    {
public string Contenido { get => Contenido1; set => Contenido1 = value; }
        public string Contenido1 { get => Contenido; set => Contenido = value; }
        public String Title { get; set; }
        public string Categoria { get; private set; }

       
    }
}