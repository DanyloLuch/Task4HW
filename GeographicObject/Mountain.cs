namespace GeographicINamespace
{
    public class Mountain : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Altitude { get; set; }

        public string Information()
        {
            return $"Назва: {Name}\nКоординати: {X}, {Y}\nОпис: {Description}\nВисота: {Altitude}";
        }
    }
}
