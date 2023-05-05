using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryViewModelService _categoryViewModelService;
        public CategoryController(ICategoryViewModelService categoryViewModelService)
        {
            _categoryViewModelService = categoryViewModelService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var list = _categoryViewModelService.GetAll();
            return View(list);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _categoryViewModelService.Get(id);
            return View(viewModel);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel viewModel)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    _categoryViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _categoryViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoryViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _categoryViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoryViewModelService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _categoryViewModelService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _categoryViewModelService.Get(id);
                return View(viewModel);
            }
        }
    }
}
