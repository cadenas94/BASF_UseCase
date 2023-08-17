using AutoMapper;
using AutoMapper.QueryableExtensions;
using BASF_UseCase.Entities;
using BASF_UseCase.Migrations;
using BASF_UseCase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BASF_UseCase.Controllers
{
    public class MaterialController : Controller
    {
        private readonly ApplicationDbContext context;

        public IMapper mapper { get; }

        public MaterialController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> PostValues(MaterialViewModel modelo)
        {
            var mat = modelo.MaterialValue;
            var quantity = modelo.Quantity;

            var material = new Material() { MaterialValue = modelo.MaterialValue, Quantity = modelo.Quantity };

            context.Add(material);
            await context.SaveChangesAsync();
            return RedirectToAction("DataSaved");
        }

        [HttpGet]
        public async Task<IActionResult> DataSaved()
        {

            
            var modelo = await context.Materials.ToListAsync();
            var model = mapper.Map<MaterialListViewModel>(modelo);

            // Without Automapper:

            //var materialListViewModel = new MaterialListViewModel
            //{
            //    MaterialList = modelo.Select(material => new MaterialViewModel
            //    {
            //        MaterialValue = material.MaterialValue,
            //        Quantity = material.Quantity
            //        // Initialize other properties as needed
            //    }).ToList()
            //};


            return View(model);
        }
    }
}
