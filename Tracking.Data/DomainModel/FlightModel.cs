using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracking.Data.DomainModel
{
    public class FlightModel
    {
        public string FlightNo { get; set; }
        public string OriginCode { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string DestinationlCode { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public List<ShipmentModel> Shipments { get;}
    }
}
