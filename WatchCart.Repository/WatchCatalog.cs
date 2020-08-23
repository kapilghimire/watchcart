using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WatchCart.Models;
using WatchCart.Models.Constants;

namespace WatchCart.Repository
{
    public class WatchCatalog : IWatchCatalog
    {
        public List<Watch> Catalog { get; set; }
        public WatchCatalog()
        {
            this.Catalog = new List<Watch>()
            {
                 new AnalogWatch(){WatchId=1101, BrandName="FASTTRACK",StrapType="METALIC",StrapColor="BLACK",Segment="BASIC",Price=4000, NumberOfHands=2,HasCalender=false},
                 new AnalogWatch(){WatchId=1102, BrandName="FASTTRACK",StrapType="METALIC",StrapColor="BLACK",Segment="BASIC",Price=4000},
                 new AnalogWatch(){WatchId=1103, BrandName="FASTTRACK",StrapType="METALIC",StrapColor="BLACK",Segment="BASIC",Price=4000},
                 new AnalogWatch(){WatchId=1104, BrandName="FASTTRACK",StrapType="METALIC",StrapColor="BLACK",Segment="BASIC",Price=4000},
                 new DigitalWatch(){WatchId=1105,BrandName="FASTTRACK",StrapType="METALIC",StrapColor="BLACK",Segment="BASIC",Price=4000},
            };
        }

       

    }
}
