using System;
using System.Collections.Generic;
using System.Text;

namespace Magazinche.Services.ProductServices
{
    public interface IProductService
    {
        void Add<TViewModel>(TViewModel productModel);
        IEnumerable<TViewModel> All<TViewModel>();
    }
}
