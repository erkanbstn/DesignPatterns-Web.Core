﻿using Mediator.MediatorPattern.Commands;
using Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> MediatorIndex()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _mediator.Send(new GetProductUpdatedQuery(id));
            return View(values);
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var values = await _mediator.Send(new GetProductUpdatedQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand updateProductCommand)
        {
            await _mediator.Send(updateProductCommand);
            return RedirectToAction("MediatorIndex");
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand createProductCommand)
        {
            await _mediator.Send(createProductCommand);
            return RedirectToAction("Index");
        }
    }
}