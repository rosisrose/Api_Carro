
using Carro.Models;
using System.Collections.Generic;
namespace Carro.Interface
{
    public interface IConcessionariaReposity
    {


            
            //Create - cadastrar um curso novo
            void Cadastrar(Marca marca);
        //R - read -devolve todos os cursos.
        List<Marca> ListarTodos();


    }
}



