using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
    public interface ICategoryViewModelService
    {
        CategoryViewModel Get(int id);
        IEnumerable<CategoryViewModel> GetAll();
        void Insert(CategoryViewModel viewModel);
        void Update(CategoryViewModel viewModel);
        void Delete(int id);
    }
}
