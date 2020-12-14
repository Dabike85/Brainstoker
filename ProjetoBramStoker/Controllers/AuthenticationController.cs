using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjetoBramStoker.Models;
using ProjetoBramStoker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Controllers
{
    public class AuthenticationController : Controller
    {
        private static ProjetoBramStoker.Services.IAuthenticationService _authenticationService;
        private static ProjetoBramStoker.Services.IEnderecoService _enderecoService;

        public AuthenticationController(
            ProjetoBramStoker.Services.IAuthenticationService authenticationService, 
            ProjetoBramStoker.Services.IEnderecoService enderecoService
        ) {
            _authenticationService = authenticationService;
            _enderecoService = enderecoService;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarConfirm(UsuarioViewModel ent)
        {
            try
            {
                var endereco = _enderecoService.Save(ent.Endereco);
                var mapped = new Usuario {
                    Senha = ent.Senha,
                    Username = ent.Username,
                    Email = ent.Email,
                    EnderecoID = endereco.EnderecoID
                };
                var result = _authenticationService.Cadastrar(mapped);
                return Json(new { message = "Cadastrado com sucesso!", status = 1 });
            }
            catch (Exception e)
            {
                return Json(new { message = e.Message, status = 0 });
            }
        }
        
        [HttpPost]
        public IActionResult LoginConfirm(UsuarioViewModel ent)
        {
            try
            {
                var mapped = new Usuario
                {
                    Senha = ent.Senha,
                    Username = ent.Username
                };
                var usuario = _authenticationService.Login(mapped);
                if (usuario != null)
                {
                    SessionDados.FezLogin(usuario);
                    return Json(new { message = "Sucesso", status = 1, url= Url.Action("Index", "Produto") });
                } else {
                    return Json(new { message = "Usuario Invalido", status = 0 });
                }
            }
            catch (Exception e)
            {
                return Json(new { message = e.Message, status = 0 });
            }
        }

    }
}
