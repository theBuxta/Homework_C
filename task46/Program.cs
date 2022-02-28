﻿// Написать программу масштабирования фигуры

using System.Linq;

string squareCoordinates = "(2,7) (7,5) (9,4) (3,6)"
                .Replace("(", "")
                .Replace(")", "");
Console.WriteLine(squareCoordinates);
var data = squareCoordinates.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: double.Parse(e[0]), y: double.Parse(e[1])))
                .Select(point => (point.x / 2, point.y / 2))
                .ToArray();
for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}