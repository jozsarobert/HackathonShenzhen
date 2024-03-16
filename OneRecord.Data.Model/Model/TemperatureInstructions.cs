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

        public int PieceId { get; set; }
        public int Id { get; set; }
        public Piece Piece { get; set; }
    }
}
