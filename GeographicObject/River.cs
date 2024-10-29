namespace GeographicINamespace
{
    public class River : IGeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }

        public string Information()
        {
            return $"Назва: {Name}\nКоординати: {X}, {Y}\nОпис: {Description}\nШвидкість: {Speed}\nДовжина: {Length}";
        }
    }
}
