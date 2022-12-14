﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Domain.Contracts.Request
{
    public class UsuarioRequest
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatorio")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]*$", ErrorMessage = "Use apenas letras no campo 'Nome'")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatorio")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [StringLength(18, MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Senha inválida")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo 'Id' é obrigatorio")]
        public int PerfilId { get; set; }

    }
}
