using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.CategoryDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList() 
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.GetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true;
            _categoryService.Add(_mapper.Map<Category>(createCategoryDto));
            return Ok("Kategori Eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            var value = _categoryService.GetById(id);
            _categoryService.Delete(value);
            return Ok("Kategori Silinmiştir.");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.Update(_mapper.Map<Category>(updateCategoryDto));
            return Ok("Kategori Güncellenmiştir.");
        }
    }
}
