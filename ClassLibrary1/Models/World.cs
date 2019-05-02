using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class World
    {
        //private readonly List<Location> Locations = new List<Location>();
        //private readonly string _name;

        ////internal void AddLocation(int xCoordinate, int yCoordinate,
        ////                          string name, string description, string imageName)
        ////{
        ////    _locations.Add(new Location(xCoordinate, yCoordinate, name, description,
        ////                                $"/ClassLibrary1;component/Images/Locations/{imageName}"));
        ////}

        //public World(string name, List<Location> location)
        //{
        //    Locations = location;
        //    _name = name;
        //}

        //internal void AddLocation(Location location)
        //{
        //    Locations.Add(location);
        //}

            public List<Location> Locations { get; set; }
            public string Name { get; set; }

            public World(string name, List<Location> location)
            {
                Name = name;
                Locations = location;
            }
        

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in Locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
