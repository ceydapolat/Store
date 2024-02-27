using Services.Contracts;

namespace Services;

public class ServiceManager : IServiceManager
{
    private IProductService _productService;
    private ICategoryService _categoryService;
    private IOrderService _orderService;
    private IAuthService _authService;

    public ServiceManager(IProductService productService, ICategoryService categoryService, IOrderService orderService, IAuthService authService)
    {
        _productService = productService;
        _categoryService = categoryService;
        _orderService = orderService;
        _authService = authService;
    }

    public IProductService ProductService => _productService;

    public ICategoryService CategoryService => _categoryService;

    public IOrderService OrderService => _orderService;

    public IAuthService AuthService => _authService;
}
