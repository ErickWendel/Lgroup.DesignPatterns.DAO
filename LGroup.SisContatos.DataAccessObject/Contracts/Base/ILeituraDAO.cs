using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.SisContatos.DataAccessObject.Contracts.Base
{
    //As vezes não é legal criar um repositorio generico
    //pq obrigamos todas as tabelas as terem o CRUD completo
    //Uma forma legal de nao ficar tao abertao, é fazer
    //a segregaacao de interface (Interface Segregation)
    //Isso é um principio da programacao que nos auxilia a nunca levar
    //mais do que o necessario para a classe
    //temos que dividir em interfaces por responsabilidades
   public interface ILeituraDAO
    {
       void Listar();
    }
}
