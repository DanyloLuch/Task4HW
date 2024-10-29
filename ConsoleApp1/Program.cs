using System;
using GeographicNamespace;

class Progrom
{
    static void Main(string[] args)
    {
        River river = new River
        {
            X = 29.11,
            Y = 50.44,
            Name = "Ірпінь",
            Description = "права притока Дніпра",
            Speed = "14км/год",
            Length = "162км"
        };

        Mountain mountain = new Mountain
        {
            X = 12.34,
            Y = 56.78,
            Name = "Говерла",
            Description = "Найвища гора в Україні",
            Altitude = 2061
        };

        Console.WriteLine(river.Information());
        Console.WriteLine(mountain.Information());
    }
}
