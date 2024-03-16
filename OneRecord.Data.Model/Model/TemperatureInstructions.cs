using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecord.Data.Model.Model
{
    public class TemperatureInstructions
    {
        public Value MinTemperature { get; set; }
        public Value MaxTemperature { get; set; }

        public string PieceId { get; set; }
        public string Id { get; set; }
    }
}
