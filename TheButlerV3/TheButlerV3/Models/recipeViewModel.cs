using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheButlerV3.Models
{
    public class recipeViewModel
    {

        public int Recipe_ID { get; set; }

        public string Recipe_Name { get; set; }

        public string Recipe_ingredince { get; set; }

        public string Recipe_Insructions { get; set; }

        public int Recipe_Type { get; set; }

        public string recipe_photo { get; set; }
    }
}