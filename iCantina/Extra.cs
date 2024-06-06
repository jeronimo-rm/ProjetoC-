using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    [Serializable]
    public class Extra
    {
        [Key]
        public int Id { get; set; }
        public string DescricaoExtra { get; set; }
        public decimal PrecoExtra { get; set; }
        public string EstadoExtra { get; set; }
        public int QuantidadeExtra { get; set; }

        public Extra()
        {

        }

        public Extra(string descricaoExtra, decimal precoExtra, string estadoExtra, int quantidadeExtra)
        {
            DescricaoExtra = descricaoExtra;
            PrecoExtra = precoExtra;
            EstadoExtra = estadoExtra;
            QuantidadeExtra = quantidadeExtra;
        }

        public override string ToString()
        {
            return "Extra: " + DescricaoExtra + "    Preço: " + PrecoExtra + "€     Estado: " + EstadoExtra + "     Quantidade: " + QuantidadeExtra;
        }
    }
}
