using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev___backend___PlanoNutricional_HealthMate.Views
{
    [Table("PlanosAlimentar")]
    public class PlanoNutricional
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a idade")]
        public int  Idade { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o peso atual")]
        public float PesoAtual { get; set; }
    }
}
