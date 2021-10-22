using Microsoft.Azure.Search.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace AlunoApp.Models
{
    [DataContract]
    [Index(nameof(Matricula),IsUnique=true)]
    public class AlunoModel
    {
        [Key]
        [Display(Name ="Busca Id")]
        [Required]
        public  int AlunoId {   get;  set; }


        [Display(Name ="Nome : ")]
        [Required(ErrorMessage ="nao deve faltar o nome")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento : ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage ="Não deve faltar a data")]
        public DateTime DataDeNascimento { get; set; }


        [Display(Name = "Matricula : ")]
        [Required(ErrorMessage ="Não deve ter matriculas repitidas")]
        public string Matricula { get; set; }
    }
}
