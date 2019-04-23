using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Models
{
    [DataContract]
    public class ServerGroupItem : ServerItem
    {
        [DataMember(Name = "items")]
        public ObservableCollection<ServerItem> Items { get; set; }
    }
}
