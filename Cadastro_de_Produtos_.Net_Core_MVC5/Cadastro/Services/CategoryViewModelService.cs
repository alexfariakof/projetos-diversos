using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Infrastructure.Data.Repositories;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Services
{
    public class CategoryViewModelService : ICategoryViewModelService
    {
        private readonly ICategoryRepository _CategoryRepository;
        private readonly IMapper _mapper;

        public CategoryViewModelService(ICategoryRepository CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }

       public CategoryViewModel Get(int id)
        {
            var entity = _CategoryRepository.Get(id);
            if (entity == null)
                return null;

            CategoryViewModel viewModel = new CategoryViewModel { Id = entity.Id, Name = entity.Name };


            return viewModel;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            var list = _CategoryRepository.GetAll();
            if (list == null)
                return new CategoryViewModel[] { };

            List<CategoryViewModel> listCategory = new List<CategoryViewModel>();
            foreach ( Category category in list)
            {
                listCategory.Add(new CategoryViewModel { Id = category.Id, Name = category.Name});
            }

            return listCategory;
        }
        
        public void Insert(CategoryViewModel viewModel)
        {

            //var entity = _mapper.Map<Category>(viewModel);
            Category entity = new Category { Name = viewModel.Name };
            _CategoryRepository.Insert(entity);
        }

        public void Update(CategoryViewModel viewModel)
        {
            //var entity = _mapper.Map<Category>(viewModel);
            Category entity = new Category { Id= viewModel.Id, Name = viewModel.Name };

            _CategoryRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _CategoryRepository.Delete(id);
        }

    }
}
