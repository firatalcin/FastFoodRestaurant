using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.TestimonialDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
         private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList() 
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.GetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {            
            _testimonialService.Add(_mapper.Map<Testimonial>(createTestimonialDto));
            return Ok("Müşteri Yorum Bilgisi Eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id) 
        {
            var value = _testimonialService.GetById(id);
            _testimonialService.Delete(value);
            return Ok("Müşteri Yorum Bilgisi Silinmiştir.");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.Update(_mapper.Map<Testimonial>(updateTestimonialDto));
            return Ok("Müşteri Yorum Bilgisi Güncellenmiştir.");
        }
    }
}
