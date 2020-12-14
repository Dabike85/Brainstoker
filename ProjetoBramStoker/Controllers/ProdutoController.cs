using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoBramStoker.Models;
using ProjetoBramStoker.Services;
using ProjetoBramStoker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Controllers
{
    public class ProdutoController : Controller
    {
        private static IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public ActionResult Index()
        {
            if (SessionDados.Logado)
            {
                var produtos = _produtoService.GetAll().ToList();
                var mapped = produtos.Select(p =>
                {
                    return new ProdutoViewModel
                    {
                        Descricao = p.Descricao,
                        Imagem = p.Imagem,
                        ProdutoID = p.ProdutoID,
                        Titulo = p.Titulo
                    };
                });
                return View(mapped);
            } else
            {
                return RedirectToAction("Login", "Authentication");
            }
        }

        // GET: ProdutoController/Details/5
        public ActionResult Details(int produtoId)
        {
            var produto = _produtoService.GetOne(produtoId);
            var mapped = new ProdutoViewModel
            {
                Descricao = produto.Descricao,
                Titulo = produto.Titulo,
                Imagem = produto.Imagem,
                ProdutoID = produto.ProdutoID,
                //Usuario = produto.Usuario,
                Modelo = produto.Modelo,
                Cor = produto.Cor
            };
            return View(mapped);
        }

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            if (SessionDados.Logado)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Authentication");
            }
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConfirm(ProdutoViewModel ent)
        {
            try
            {
                var mapped = new Produto { 
                    Descricao = ent.Descricao, 
                    Imagem = ent.Imagem, 
                    Titulo = ent.Titulo, 
                    UsuarioID = SessionDados.UsuarioLogado.UsuarioID,
                    Modelo = ent.Modelo,
                    Cor = ent.Cor
                };
                _produtoService.Save(mapped);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult PegarConfirm(int produtoId)
        {
            _produtoService.Delete(produtoId);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel ent)
        {
            try
            {
                var mapped = new Produto
                {
                    Descricao = ent.Descricao,
                    Imagem = ent.Imagem,
                    Titulo = ent.Titulo,
                    ProdutoID = ent.ProdutoID,
                    UsuarioID = SessionDados.UsuarioLogado.UsuarioID
                };
                _produtoService.Update(mapped);
                //_produtoService.Update(ent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _produtoService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
