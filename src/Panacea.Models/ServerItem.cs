using Panacea.Multilinguality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Models
{
    [DataContract]
    public class ServerItem : Translatable
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [IsTranslatable]
        [DataMember(Name = "name")]
        public string Name
        {
            get => GetTranslation();
            set => SetTranslation(value);
        }

        [DataMember(Name = "img_thumbnail")]
        public Thumbnail ImgThumbnail { get; set; }

        [DataMember(Name = "categories")]
        public List<string> Categories { get; set; }
    }
}
