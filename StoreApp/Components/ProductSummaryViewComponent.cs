namespace StoreApp;

using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services;

public class ProductSummaryViewComponent : ViewComponent
{
    private readonly IServiceManager _manager;

    public ProductSummaryViewComponent(IServiceManager manager)
    {
        _manager = manager;
    }

    public string Invoke(){
        return _manager.ProductService.GetAllProducts(false).Count().ToString();
    }
}
