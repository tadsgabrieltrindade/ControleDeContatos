using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        //Construdor
        public BancoContext(DbContextOptions <BancoContext> options) : base(options) 
        { 
               
        }   

        //Configuração do contexto - No caso, cria um banco de dados do com o nome Contato
        public DbSet<ContatoModel> Contato { get; set; }
    }
}
