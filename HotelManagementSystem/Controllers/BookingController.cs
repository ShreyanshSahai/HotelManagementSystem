using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.Controllers
{
    public class BookingController : Controller
    {

        Order finalOrder = new Order();
        private HotelDbContext db;
        public BookingController(HotelDbContext db)
        {
            this.db = db;
        }

        public UserManager<User> UserManager { get; }
        public SignInManager<User> SignInManager { get; }

        [HttpGet]
        public IActionResult Book()
        {
            List<Room> emptyRooms = new List<Room>();
            foreach(Room room in db.Rooms.ToList())
            {
                if(!room.IsBooked)
                {
                    emptyRooms.Add(room);
                }
            }
            return View(emptyRooms);
        }
        public IActionResult RoomSelect(string roomName)
        {
            Room tobeBooked = db.Rooms.FirstOrDefault(r => r.RoomName.Equals(roomName));
            return RedirectToAction("TimeSelect", tobeBooked);
        }
        [HttpGet]
        public IActionResult TimeSelect(Room room)
        {
            Order order = new Order
            {
                Room = room,
                RoomName = room.RoomName
            };
            return View(order);
        }
        [HttpPost]
        public IActionResult TimeSelect(Order order)
        {
            Room toBeBooked = db.Rooms.FirstOrDefault(r => r.RoomName.Equals(order.RoomName));
            finalOrder.Room = toBeBooked;
            finalOrder.RoomName = toBeBooked.RoomName;
            finalOrder.CheckIn = order.CheckIn;
            finalOrder.CheckOut = order.CheckOut;
            finalOrder.User = db.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            finalOrder.Email = finalOrder.User.Email;
            toBeBooked.IsBooked = true;
            db.Orders.Add(finalOrder);
            db.SaveChanges();
            return RedirectToAction("History", "Dashboard");
        }
    }
}
