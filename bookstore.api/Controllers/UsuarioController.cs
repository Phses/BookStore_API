﻿using AutoMapper;
using bookstore.Domain.Contracts.Request;
using bookstore.Domain.Contracts.Response;
using bookstore.Domain.Entities;
using bookstore.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.api.Controllers
{
    public class UsuarioController : BaseController<Usuario, UsuarioRequest, UsuarioResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioService _UsuarioService;
        public UsuarioController(IMapper mapper, IUsuarioService UsuarioService) : base(mapper, UsuarioService)
        {
            _mapper = mapper;
            _UsuarioService = UsuarioService;
        }
    }
}
