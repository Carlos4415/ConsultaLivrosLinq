// Este programa utiliza LINQ para consultar uma lista de livros, retornando apenas os títulos dos livros publicados após o ano 2000. 
// Os títulos são ordenados alfabeticamente antes de serem exibidos.
using ConsultaLivrosLinq;

List<Livro> livros = new List<Livro>
{
    new Livro { Titulo = "Aprendendo LINQ", Autor = "0 Silva", AnoPublicacao = 2005 },
    new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
    new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
    new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
    new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
};

var titulosLivros = livros
    .Where(l => l.AnoPublicacao > 2000)
    .OrderBy(l => l.Titulo)
    .Select(l => l.Titulo);

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");

foreach (var titulo in titulosLivros)
{
    Console.WriteLine(titulo);
}