﻿using System;

namespace ProjetoAspNetAPI01.Data.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
