using System;

// Small panel I used to practice the C# I started at iCode.
// Steady conduction through a flat wall: q = k * A * dT / L.
class Program
{
    static int Main(string[] args)
    {
        double k = Arg(args, 0, 0.6);      // W/m-K, brick-ish
        double area = Arg(args, 1, 12.0);  // m^2
        double thickness = Arg(args, 2, 0.2);
        double hotC = Arg(args, 3, 35.0);
        double coldC = Arg(args, 4, 22.0);

        if (thickness <= 0 || area <= 0 || k <= 0)
        {
            Console.Error.WriteLine("thickness, area, and k must be positive");
            return 1;
        }

        double dT = hotC - coldC;
        double watts = k * area * dT / thickness;
        Console.WriteLine($"k={k:0.###} W/m-K  A={area:0.###} m^2  L={thickness:0.###} m");
        Console.WriteLine($"hot={hotC:0.#} C ({CToF(hotC):0.#} F)  cold={coldC:0.#} C ({CToF(coldC):0.#} F)");
        Console.WriteLine($"heat flow={watts:0.##} W");
        return 0;
    }

    static double CToF(double c) => c * 9.0 / 5.0 + 32.0;

    static double Arg(string[] args, int i, double fallback)
    {
        if (i >= args.Length) return fallback;
        return double.TryParse(args[i], out double v) ? v : fallback;
    }
}
