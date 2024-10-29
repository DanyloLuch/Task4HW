using Microsoft.VisualBasic;

namespace GeographicNamespace
{
    public abstract class GeographicObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual string Information()
        {
            return $"Назва: {Name}\nКоординати: {X}, {Y}\nОпис: {Description}";
        }
    }
}
