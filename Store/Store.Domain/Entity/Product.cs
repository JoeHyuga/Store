﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Store.Domain.Entity
{
    public class Product
    {
        //[HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        //[Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }
        //[DataType(DataType.MultilineText)]
        //[Required(ErrorMessage = "Please enter a product description")]
        public string Description { get; set; }
        //[Required]
        //[Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }
        public string Count { get; set; }
        //[Required(ErrorMessage = "Please specify a category")]
        public string CateGory { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
