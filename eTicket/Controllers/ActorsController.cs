using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;//aktör verilerini alacağımız sınıfın nesnesini oluşturduk
        public ActorsController(IActorsService service)//ve bu nesneleri di ile kullanılabilir hale getirdik
        {
                _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await  _service.GetAllAsync();//aktör bilgilerini data verisine aktardık ve beş aktör verisi sıralandı
            return View(data);
        }
        //get actors/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if(ModelState.IsValid)//bu kontrol modelin dolu olup olmadığını konrol eder eğer doluysa actor parametresini dönderir
            {
                return View(actor);
            }
            _service.AddAsync(actor);//eğer model doldurulmamışsa yenisi eklenir ve Index sayfamıza yönlendirilir
            return RedirectToAction(nameof(Index));
            
        }

        public async Task<IActionResult> Details(int id)
        {
            
            var data =await _service.GetByIdAsync(id);
            if (data == null) return View("Empty");
            return View(data);

        }

        //get actors/delete
        public async Task<IActionResult> Delete(int id)
        {

            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");
            return View(data);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var data = await _service.GetByIdAsync(id);
            if (data == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }

        //get actors/edit

        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
