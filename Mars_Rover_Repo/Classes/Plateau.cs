using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover_Repo.Classes
{
    /// <summary>
    /// Plateau Interface
    /// </summary>
    public interface IPlateau
    {
        Position PlateauPosition { get; }
    }

    /// <summary>
    /// Plateau class structure
    /// </summary>
    public class Plateau : IPlateau
    {
        public Position PlateauPosition { get; private set; }

        public Plateau(Position position)
        {
            PlateauPosition = position;
        }
    }

}
