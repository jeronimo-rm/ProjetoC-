using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    public class Multa
    {
        [Key]
        public string Valor { get; set; }
        public string Horas { get; set; }
        public string ID{ get; set; }

        //Constructor
        public Multa(string valor, string horas)
        {
            this.Valor = valor;
            this.Horas = horas;
            
        }

        public Multa()
        {
            // Construtor vazio necessário para o Entity Framework
        }

        // OVERRIDE PARA DIZER COMO VAI ESCREVER NA LISTBOX
       

      
    }
}

    

