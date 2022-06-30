using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChapterFST1.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int QuantidadePaginas { get; set; }

        public bool Disponivel { get; set; }
}