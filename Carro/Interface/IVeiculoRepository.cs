using Carro.Models;

namespace Carro.Interface
{
    public interface IVeiculoRepository
    {

        //Create - cadastrar um curso novo
        void Cadastrar(Veiculo veiculo);
        //R - read -devolve todos os cursos.
        List<Veiculo> ListarTodos();

    }
}
