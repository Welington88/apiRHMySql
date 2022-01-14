using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace apiRhMySql.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public Usuario()
        {
        }

        [Key]
        [JsonIgnore]
        public int IdUsuario { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Senha { get; set; }

    }

}
