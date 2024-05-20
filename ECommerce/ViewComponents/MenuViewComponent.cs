using ECommerce.Data;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly Hshop2023Context db;
        public MenuViewComponent(Hshop2023Context context) => db=context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuVM
            {
                MaLoai = lo.MaLoai, 
                TenLoai = lo.TenLoai, SoLuong = lo.HangHoas.Count
            });
            return View(data);
        }
    }
}
