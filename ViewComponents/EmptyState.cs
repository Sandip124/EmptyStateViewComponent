using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmptyState.ViewComponents
{
    [ViewComponent(Name = "EmptyState")]
    public class EmptyState : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(EmptyStateViewModel emptyStateViewModel)
        {
            return await Task.Run(() => View(emptyStateViewModel));
        }
    }
}