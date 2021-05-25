using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vega.Controllers.Resources
{
    public class MakeResource : KeyValuePairResource
    {
        //we will use the new KeyValuePairResource instead iheretit
        // public int Id { get; set; }

        // public string Name { get; set; }

        public ICollection<KeyValuePairResource> Models { get; set; }

        //initializing the collections inside the constructor
        public MakeResource()
        {
            Models = new Collection<KeyValuePairResource>();
        }
    }
}
