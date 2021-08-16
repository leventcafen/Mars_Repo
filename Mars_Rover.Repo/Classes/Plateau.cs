using System;
namespace Mars_Rover.Repo.Classes
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
