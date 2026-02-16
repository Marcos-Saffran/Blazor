using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Por favor use um Nome maior que 3 letras."), MaxLength(100, ErrorMessage = "Por favor use um Nome menor que 100 letras.")]
        public string Name { get; set; }

        [Required, MinLength(5, ErrorMessage = "Por favor use um Endereço maior que 5 letras."), MaxLength(100, ErrorMessage = "Por favor use um Endereço menor que 100 letras.")]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Por favor use uma Cidade maior que 3 letras."), MaxLength(50, ErrorMessage = "Por favor use uma Cidade menor que 50 letras.")]
        public string City { get; set; }

        [Required, MinLength(3, ErrorMessage = "Por favor use uma Região maior que 3 letras."), MaxLength(20, ErrorMessage = "Por favor use uma Região menor que 20 letras.")]
        public string Region { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Por favor use um Código Postal válido com cinco números.")]
        public string PostalCode { get; set; }
    }
}
