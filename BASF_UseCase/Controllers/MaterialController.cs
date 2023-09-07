using AutoMapper;
using AutoMapper.QueryableExtensions;
using BASF_UseCase.Entities;
using BASF_UseCase.Migrations;
using BASF_UseCase.Models;
using JsonFileUpload.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Reflection.PortableExecutable;

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
        //Return the view to add a new material to the app
        public IActionResult Create()
        {
            return View();
        }
        //Collect the data introduced by the user to save the material and quantity from the view
        [HttpPost]
        public  async Task<IActionResult> PostValues(MaterialViewModel model)
        {
            var mat = model.MaterialValue;
            var quantity = model.Quantity;

            var material = new Material() { MaterialValue = model.MaterialValue, Quantity = model.Quantity };

            context.Add(material);
            await context.SaveChangesAsync();
            return RedirectToAction("DataSaved");
        }
        //Show all the data saved in the database
        [HttpGet]
        public async Task<IActionResult> DataSaved()
        {           
            var modelo = await context.Materials.ToListAsync();
            var model = mapper.Map<MaterialListViewModel>(modelo);

            return View(model);
        }
        //View to load a JSON file with material data
        public IActionResult LoadFile()
        {
            return View();
        }
        //Method to get the file picked by the user and save in the DB
        [HttpPost]
        public async Task<IActionResult> LoadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return RedirectToAction("LoadFile");
            }
            List<JsonFileLoadViewModel> materialList = null;
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var content = await reader.ReadToEndAsync();
                materialList = JsonConvert.DeserializeObject<List<JsonFileLoadViewModel>>(content);
            }

            // Convert JsonFileLoadViewModel objects to Material entities using LINQ
            var materialEntities = materialList.Select(materialViewModel => new Material
            {
                MaterialValue = materialViewModel.MaterialValue,
                Quantity = materialViewModel.Quantity
            }).ToList();


            context.AddRange(materialEntities);
            await context.SaveChangesAsync();
            return RedirectToAction("DataSaved");
        }
    }
}
