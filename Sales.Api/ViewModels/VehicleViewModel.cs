using Sales.Infrastructure.UsefulModels.Hateoas;

namespace Sales.Api.ViewModels
{
    public class VehicleViewModel: LinkedResourceBaseViewModel
    {
        public string Model { get; set; }
        public string Owner { get; set; }
    }
}