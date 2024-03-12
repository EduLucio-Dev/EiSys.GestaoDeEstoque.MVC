using EiSys.GestaoDeEstoque.Domain.Entities;


namespace EiSys.GestaoDeEstoque.Domain.Interface
{
    internal interface ICategoriaRepository
    {
        //Task seria uma ação assincrona (não são em tempo de execução.
        //Nas interfaces são assinaturas de metodos.
        //O recomendado é que no final do metodo colocamos Async

        //Pega uma lista de categorias
        Task<IEnumerable<Categoria>> GetCategoriesAsync();

        //Pega uma categoria
        Task<Categoria> GetByIdAsync(int? id);


        //passamos o objeto categoria do tipo Categoria
        Task<Categoria> CreateAsync(Categoria categoria);
        Task<Categoria> UpdateAsync(Categoria categoria);
        Task<Categoria> RemoveAsync(Categoria categoria);
    }
}
