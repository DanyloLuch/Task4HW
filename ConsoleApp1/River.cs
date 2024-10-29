namespace GeographicNamespace
{
    public class River : GeographicObject
    {
        public string Speed { get; set; }
        public string Length { get; set; }

        public override string Information()
        {
            return $"{base.Information()}\nШвидкість: {Speed}\nДовжина: {Length}";
        }
    }
}
