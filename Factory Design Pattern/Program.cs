// See https://aka.ms/new-console-template for more information
using Factory_Design_Pattern;
using System;

Console.WriteLine("Hello, World!");

ShapeFactory shapeFactory = new ShapeFactory();
var shape = shapeFactory.getShape("Square");
shape.drawShape();

Console.ReadLine();