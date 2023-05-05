using Cadastro.Domain.Entities;
using Cadastro.Interfaces;
using Cadastro.Services;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductViewModelService _productViewModelService;
        private readonly IClientViewModelService _clientViewModelService;
        private readonly ICategoryViewModelService _categoryViewModelService;
        
        public ProductController(IProductViewModelService productViewModelService, IClientViewModelService ClientViewModelService, ICategoryViewModelService CategoryViewModelService)
        {
            _productViewModelService = productViewModelService;
            _categoryViewModelService = CategoryViewModelService;
            _clientViewModelService = ClientViewModelService;
        }
        

        // GET: Product
        public ActionResult Index()
        {
            var list = _productViewModelService.GetAll();
            return View(list);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _productViewModelService.Get(id);

            var client = _clientViewModelService.Get(viewModel.IdClient);
            viewModel.Client = client;

            return View(viewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {            

            var productViewModel = new ProductViewModel();
            var categoryModels = _categoryViewModelService.GetAll();
            var categoryViewModels = categoryModels.Select(cm => new CategoryViewModel
            {
                Id = cm.Id,
                Name = cm.Name
            }).ToList();
            productViewModel.ListCategoria = categoryViewModels;
                        
            var clientModels = _clientViewModelService.GetAll();
            var clientViewModels = clientModels.Select(cl => new ClientViewModel
            {
                Id = cl.Id,
                Name = cl.Name
            }).ToList();
            productViewModel.ListClient = clientViewModels;



            return View(productViewModel);
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    _productViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _productViewModelService.Get(id);

            
            var categoryModels = _categoryViewModelService.GetAll();
            var categoryViewModels = categoryModels.Select(cm => new CategoryViewModel
            {
                Id = cm.Id,
                Name = cm.Name
            }).ToList();
            categoryViewModels.Add(new CategoryViewModel() { Id = 0, Name = "Selecione uma Categoria" });

            var clientModels = _clientViewModelService.GetAll();
            var clientViewModels = clientModels.Select(cl => new ClientViewModel
            {
                Id = cl.Id,
                Name = cl.Name
            }).ToList();
            
            viewModel.ListClient = clientViewModels;
            viewModel.ListCategoria = categoryViewModels;




            return View(viewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
        }
    }
}
