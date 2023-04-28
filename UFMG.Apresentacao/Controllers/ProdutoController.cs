﻿
using Microsoft.AspNetCore.Mvc;

using UFMG.Apresentacao.Exceptions;
using UFMG.Apresentacao.Interfaces;


namespace Umfg.Apresentacao.Controllers
{
    [ApiController]
    [Route("umfg/api/v1/produto")]
    public sealed class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico _service;

        public ProdutoController(IProdutoServico service)
        {
            _service = service;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_service.ObterTodos());
        }

        [HttpGet("{codigoBarra}")]
        public IActionResult Get(string codigoBarra)
        {
            try
            {
                return Ok(_service.ObterPorCodigoBarra(codigoBarra));
            }
            catch (NotFoundException)
            {
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
