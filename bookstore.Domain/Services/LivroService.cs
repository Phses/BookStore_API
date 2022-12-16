﻿using bookstore.Domain.Entities;
using bookstore.Domain.Interfaces.Repositories;
using bookstore.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Domain.Services
{
    public class LivroService : BaseService<Livro>, ILivroService
    {

        private readonly ILivroRepository _LivroRepository;

        public LivroService(ILivroRepository livroRepository, IHttpContextAccessor httpContextAccessor) : base(livroRepository, httpContextAccessor)
        {
        }
    }
}
