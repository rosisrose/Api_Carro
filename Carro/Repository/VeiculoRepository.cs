using Carro.Contexts;
using Carro.Interface;
using Carro.Models;

namespace Carro.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
      
        
            private readonly ConcessionariaContext _context;

            //Injecao de depedencia> a API entrega o EscolaContext pronto
            public VeiculoRepository(ConcessionariaContext context)
            {
                _context = context;
            }


            //INSERT INTO CURSO
            public void Cadastrar(Veiculo veiculo)
            {
                _context.Veiculo.Add(veiculo); //coloca na fila //marca para Inserir
                _context.SaveChanges(); //grava no banco
            }


            // SELECT *  FROM CURSO
            public List<Veiculo> ListarTodos()
            {
                return _context.Veiculo.ToList();  //ToList() -> Busca todos os registros.

            }
        }
    }


