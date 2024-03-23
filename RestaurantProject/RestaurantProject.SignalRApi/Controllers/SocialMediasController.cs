using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.SocialMediaDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediasController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.GetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {            
            _socialMediaService.Add(_mapper.Map<SocialMedia>(createSocialMediaDto));
            return Ok("Sosyal Medya Bilgisi Eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            _socialMediaService.Delete(value);
            return Ok("Sosyal Medya Bilgisi Silinmiştir.");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.Update(_mapper.Map<SocialMedia>(updateSocialMediaDto));
            return Ok("Sosyal Medya Bilgisi Güncellenmiştir.");
        }
    }
}
