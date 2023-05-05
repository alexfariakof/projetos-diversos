using Cadastro.Domain.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Um valor é requerido.")]
        public string Value { get; set; }

        [Display(Name = "Disponível")]
        public bool Active { get; set; }

        [Display(Name = "IdCategoria")]
        public int IdCategory { get; set; }

        [Display(Name = "Categoria")]
        public Category Category  { get; set; }
        
        [Display(Name = "IdClient")]
        public int IdClient { get; set; }

        [Display(Name = "Cliente")]
        public ClientViewModel Client { get; set; }
        public List<ClientViewModel> ListClient { get; set; }
        public List<CategoryViewModel> ListCategoria  { get; set; }
    }

}
