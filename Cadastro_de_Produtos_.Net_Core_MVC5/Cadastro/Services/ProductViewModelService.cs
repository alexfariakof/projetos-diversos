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
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _ProductRepository;
        private readonly IClientRepository _ClientRepository;
        private readonly ICategoryRepository _CategoryRepository;
        private readonly IMapper _mapper;

        public ProductViewModelService(IProductRepository ProductRepository, IClientRepository ClientRepository, ICategoryRepository CategoryRepository,  IMapper mapper)
        {
            _ProductRepository = ProductRepository;
            _ClientRepository = ClientRepository;
            _CategoryRepository = CategoryRepository;

            _mapper = mapper;

        }

        public void Delete(int id)
        {
            _ProductRepository.Delete(id);
        }

        public ProductViewModel Get(int id)
        {
            var entity = _ProductRepository.Get(id);

            entity.Client = _ClientRepository.Get(entity.IdClient);
            entity.Category = _CategoryRepository.Get(entity.IdCategory);

            if (entity == null)
                return null;

            return _mapper.Map<ProductViewModel>(entity);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var list = _ProductRepository.GetAll();
            if (list == null)
                return new ProductViewModel[] { };


            foreach (Product product in list)
            {
                product.Client = _ClientRepository.Get(product.IdClient);
                product.Category = _CategoryRepository.Get(product.IdCategory);
            }
            return _mapper.Map<IEnumerable<ProductViewModel>>(list);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _ProductRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _ProductRepository.Update(entity);
        }
    }
}

