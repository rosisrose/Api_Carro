using Carro.Contexts;
using Carro.Interface;
using Carro.Models;
using static Carro.Interface.IConcessionariaReposity;

namespace Carro.Repository
{
    public class ConcessionariaRepository: IConcessionariaReposity
    {
        private readonly ConcessionariaContext _context;

        //Injecao de depedencia> a API entrega o EscolaContext pronto
        public ConcessionariaRepository(ConcessionariaContext context)
        {
            _context = context;
        }


        //INSERT INTO CURSO
        public void Cadastrar(Marca marca)
        {
            _context.Marca.Add(marca); //coloca na fila //marca para Inserir
            _context.SaveChanges(); //grava no banco
        }


        // SELECT *  FROM CURSO
        public List<Marca> ListarTodos()
        {
            return _context.Marca.ToList();  //ToList() -> Busca todos os registros.

        }    }
}
