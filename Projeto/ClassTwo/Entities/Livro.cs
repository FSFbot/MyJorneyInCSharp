using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTwo.Entities
{
    public class Livro
    {
        // Atributos
        private string _titulo;
        private string _autor;
        private string _isbn;
        private int _quantidadeDePaginas;
        private string _sinopse;

        // Propriedades
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int QuantidadeDePaginas
        {
            get { return _quantidadeDePaginas; }
            set { _quantidadeDePaginas = value; }
        }

        public string Sinopse
        {
            get { return _sinopse; }
            set { _sinopse = value; }
        }

        // Construtor
        public Livro(string titulo, string autor, string isbn, int quantidadeDePaginas, string sinopse)
        {
            _titulo = titulo;
            _autor = autor;
            _isbn = isbn;
            _quantidadeDePaginas = quantidadeDePaginas;
            _sinopse = sinopse;
        }

        // Métodos
        public void Ler()
        {
            Console.WriteLine($"Você está lendo o livro '{_titulo}' de {_autor}.");
        }

        public void Resumir()
        {
            Console.WriteLine($"Sinopse de '{_titulo}': {_sinopse}");
        }
    }

}
