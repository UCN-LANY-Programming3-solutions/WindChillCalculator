﻿using MeteorologyCalculator;
using System;

Console.WriteLine("Windchill Calculator v1.0");
Console.WriteLine();

// TODO: Utilize the MeteorologyCalculator class library to
//       calculate the wind chill factor of a given temperature
//       and wind speed.

// HINT: The code to call the wind chill calculator could look
//       something like this:
Temperature temperature = new(5, Temperature.Scale.Celsius);
WindSpeed speed = new(9, WindSpeed.Unit.MetersPerSecond);
WindChillFactor wcf = new(temperature, speed);

Console.WriteLine(temperature);
Console.WriteLine(speed);
Console.WriteLine($"Calculated chill factor: {wcf.CalculateWindChillFactor(Temperature.Scale.Celsius)}");