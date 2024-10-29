namespace GeographicNamespace
{
    public class Mountain : GeographicObject
    {
        public double Altitude { get; set; }

        public override string Information()
        {
            return $"{base.Information()}\nВисота: {Altitude}";
        }
    }
}
