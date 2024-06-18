﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Menu
    {
        [Key]
       public int Id { get; set; }

        public int IdPrato { get; set; }
        public int IdExtra { get; set; }
        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }
        public int Quantidade { get; set; }
        public TimeSpan Horario { get; set; }


        public Menu( int idPrato, int idExtra, decimal precoEstudante, decimal precoProfessor, int quantidade,TimeSpan horario)
        {
           
            IdPrato = idPrato;
            IdExtra = idExtra;
            PrecoEstudante = precoEstudante;
            PrecoProfessor = precoProfessor;
            Quantidade = quantidade;
            Horario = horario;
        }

        public override string ToString()
        {
            var db = new ApplicationContext();
            var nomePrato = db.Pratos.Find(IdPrato);
            var nomeExtra = db.Extras.Find(IdExtra);
            return " Prato: " + nomePrato.DescricaoPrato + "     Extra: " + nomeExtra.DescricaoExtra + "     Preço Estudante: " + PrecoEstudante + "€    Preço Professor: " + PrecoProfessor + "€   Quantidade: " + Quantidade;
        }
    }
}
