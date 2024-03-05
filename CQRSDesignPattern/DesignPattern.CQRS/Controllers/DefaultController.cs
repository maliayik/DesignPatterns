using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _handler;
        private readonly CreateProductCommandHandler _createProductHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler handler, CreateProductCommandHandler createProductHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _handler = handler;
            _createProductHandler = createProductHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPRoduct()
        {
            return View();

        }


        [HttpPost]
        public IActionResult AddPRoduct(CreateProductCommand command)
        {
            _createProductHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult GetProduct(int id)
        {
            var values=_getProductByIDQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
           _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


    }
}
