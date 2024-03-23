using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.CategoryDto;
using RestaurantProject.Core.DataAccess.Dtos.ContactDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.GetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateContactDto createContactDto)
        {
            _contactService.Add(_mapper.Map<Contact>(createContactDto));
            return Ok("İletişim Bilgileri Eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.GetById(id);
            _contactService.Delete(value);
            return Ok("İletişim Bilgileri Silinmiştir.");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.Update(_mapper.Map<Contact>(updateContactDto));
            return Ok("İletişim Bilgileri Güncellenmiştir.");
        }
    }
}
