﻿using LanchesMequi.Models;
using LanchesMequi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMequi.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, 
            CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Checkout() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido) 
        {
            return View();
        }
    }
}
