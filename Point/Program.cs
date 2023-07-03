

Point point = new Point(1, 2);
System.Console.WriteLine(point.ToString());
System.Console.WriteLine(point.GetXY()[0] + " " + point.GetXY()[1]);
point.SetXY(1, 0);
System.Console.WriteLine(point.GetXY()[0] + " " + point.GetXY()[1]);
Point point1 = new Point(3, 0);
System.Console.WriteLine(point.Distance(point1));
System.Console.WriteLine(point.Distance());
System.Console.WriteLine(point.Distance(3, 0));
System.Console.WriteLine("__________________________________________________");
Line line = new Line(1, 0, 2, 0);
line.end = point1;
System.Console.WriteLine(line.Begin);
System.Console.WriteLine(line.ToString());
System.Console.WriteLine(line.GetLength());