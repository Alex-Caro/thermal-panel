# thermal-panel

C# console check for steady conduction through a flat wall.

```
q = k * A * (T_hot - T_cold) / L
```

I started C# at iCode. This is the piece I can open and walk through: parse args, reject bad input, convert C to F, print watts.

```
dotnet run -- 0.6 12 0.2 35 22
```

Defaults are brick-ish conductivity, 12 m^2, 0.2 m thick, 35 C to 22 C.
