using ECommerce.Data;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Helper;
namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly Hshop2023Context db;

        public CartController(Hshop2023Context context)
        {
            db = context;
        }
        const string CART_KEY = "MYCART";
        public List<CardItem> Cart =>HttpContext.Session.Get<List<CardItem>>(CART_KEY)  ?? new List<CardItem>();
        public IActionResult Index()
        {
            return View(Cart);
        }
        public IActionResult AddToCart(int id , int quantity = 1)
        {
            var gioHang = Cart;
            var item = gioHang.SingleOrDefault(p => p.MaHH == id);  
            if (item == null)
            {
                var hangHoa = db.HangHoas.SingleOrDefault(p => p.MaHh == id);
                {
                    if (hangHoa == null)
                    {
                        return NotFound();
                    }
                    item = new CardItem
                    {
                        MaHH = hangHoa.MaHh,
                        TenHH = hangHoa.TenHh,
                        DonGia = hangHoa.DonGia ?? 0,
                        Hinh = hangHoa.Hinh ?? string.Empty,
                        SoLuong = quantity
                    };
                    gioHang.Add(item);
                    
                }
               
                
            }
            else
            {
                item.SoLuong += quantity;
            }
            HttpContext.Session.Set(CART_KEY, gioHang);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCart(int id)
        {
            var gioHang = Cart;
           var item = gioHang.SingleOrDefault(p=>p.MaHH == id);
            if (item != null) { 
            gioHang.Remove(item);
                HttpContext.Session.Set(CART_KEY, gioHang);
                
            }
            return RedirectToAction("Index");
        }
    }
}
