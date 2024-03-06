using Microsoft.AspNetCore.Mvc;

namespace StocksApp.Components
{
    public class SelectedStockViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Dictionary<string, object> stockDetails)
        {
            return View(stockDetails);
        }
    }
}
