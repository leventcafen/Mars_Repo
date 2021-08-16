using System;
namespace Mars_Rover.Repo.Classes
{
    /// <summary>
    /// Position Interface
    /// </summary>
    public interface IPosition
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
    }

    /// <summary>
    /// Position class structure
    /// </summary>
    public class Position : IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
