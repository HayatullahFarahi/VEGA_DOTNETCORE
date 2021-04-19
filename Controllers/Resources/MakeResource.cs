using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }

        //initializing the collections inside the constructor
        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}
