using EiSys.GestaoDeEstoque.Domain.Entities;

namespace EiSys.GestaoDeEstoque.Domain.Interface
{
    public interface IProdutoRepository
    {
        //Task seria uma ação assincrona (não são em tempo de execução).
        //Nas interfaces são assinaturas de metodos.

        //Pega uma lista de Produtos
        Task<IEnumerable<Produto>> GetProductAsync();

        //Pega um Produto
        Task<Produto> GetByIdAsync(int? id);

        Task<Produto> GetProductCategoryAsync(int? id);


        //passamos o objeto produto do tipo Produto
        Task<Produto> CreateAsync(Produto produto);
        Task<Produto> UpdateAsync(Produto produto);
        Task<Produto> RemoveAsync(Produto produto);
    }
}
