using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace JsonFileUpload.Pages
{
    public class JsonFileLoadViewModel
    {
        public string MaterialValue { get; set; }
        public decimal Quantity { get; set; }


    }
}
