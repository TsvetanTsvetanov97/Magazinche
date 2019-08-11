using Magazinche.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazinche.Services.CategoryServices
{
    public interface ICategoryService
    { 
        void Add<TViewModel>(TViewModel model);
        IEnumerable<TViewModel> All<TViewModel>();
    }
}
