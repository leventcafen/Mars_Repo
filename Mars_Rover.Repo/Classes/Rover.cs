using System;
namespace Mars_Rover.Repo.Classes
{
    public enum Directions
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }

    public interface IRover
    {
        IPlateau RoverPlateau { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string ToString();
    }


    public class Rover : IRover
    {
        public IPlateau RoverPlateau { get; set; }
        public IPosition RoverPosition { get; set; }
        public Directions RoverDirection { get; set; }


        public Rover(IPlateau roverPlateau, IPosition roverPosition, Directions roverDirection)
        {
            RoverPlateau = roverPlateau;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }

        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }

        private void TurnLeft()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverDirection = Directions.W;
                    break;
                case Directions.E:
                    RoverDirection = Directions.N;
                    break;
                case Directions.S:
                    RoverDirection = Directions.E;
                    break;
                case Directions.W:
                    RoverDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void TurnRight()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverDirection = Directions.E;
                    break;
                case Directions.E:
                    RoverDirection = Directions.S;
                    break;
                case Directions.S:
                    RoverDirection = Directions.W;
                    break;
                case Directions.W:
                    RoverDirection = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void Move()
        {
            if (RoverDirection == Directions.N)
            {
                RoverPosition.YCoordinate++;
            }
            else if (RoverDirection == Directions.E)
            {
                RoverPosition.XCoordinate++;
            }
            else if (RoverDirection == Directions.S)
            {
                RoverPosition.YCoordinate--;
            }
            else if (RoverDirection == Directions.W)
            {
                RoverPosition.XCoordinate--;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.XCoordinate, RoverPosition.YCoordinate, RoverDirection);
        }

    }
}