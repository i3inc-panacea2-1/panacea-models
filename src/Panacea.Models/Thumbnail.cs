using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Models
{
    [DataContract]
    public class Thumbnail
    {
        [DataMember(Name = "image")]
        public string Image { get; set; }

    }
}
