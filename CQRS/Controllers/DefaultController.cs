using CQRS.CQRSPattern.Commands;
using CQRS.CQRSPattern.Handlers;
using CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler  _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult CqrsIndex()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand createProductCommand)
        {
            _createProductCommandHandler.Handle(createProductCommand);
            return RedirectToAction("CqrsIndex");
        }
        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand updateProductCommand)
        {
            _updateProductCommandHandler.Handle(updateProductCommand);
            return RedirectToAction("CqrsIndex");
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("CqrsIndex");
        }
    }
}
