using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _contex;
        public CinemasController(AppDbContext context)
        {
            _contex = context;
        }
        //Bir metot async olarak işaretlendiğinde, bu metot içinde asenkron işlemler gerçekleştirilebilir hale gelir.
        //Metot, başka bir iş parçacığı üzerinde çalışmaya devam edebilir, böylece ana iş parçacığı kitlenmez.
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _contex.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
