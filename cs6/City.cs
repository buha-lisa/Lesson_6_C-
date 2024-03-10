namespace cs6
{
    internal class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }

        public static City operator +(City city, int increment)
        {
            return new City { Population = city.Population + increment };
        }
        public static City operator -(City city, int increment)
        {
            return new City { Population = city.Population - increment };
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }
        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
        public override bool Equals(object obj)
        {
            if (obj is City)
            {
                City other = (City)obj;
                return this.Population == other.Population;
            }
            return false;
        }
    }
}
