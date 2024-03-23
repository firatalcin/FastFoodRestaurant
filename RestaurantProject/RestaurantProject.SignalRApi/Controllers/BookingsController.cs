using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.BookingDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingsController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            _bookingService.Add(_mapper.Map<Booking>(createBookingDto));
            return Ok("Rezervasyon Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.GetById(id);
            _bookingService.Delete(value);
            return Ok("Rezervasyon Alanı Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            _bookingService.Update(_mapper.Map<Booking>(updateBookingDto));
            return Ok("Rezervasyon Tablosu Güncellendi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.GetById(id);
            return Ok(value);
        }
    }
}
