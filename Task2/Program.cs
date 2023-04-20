//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



double GetImputNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

(double X, double Y, double Z) GetPointIn3DArea()
{
    double X = GetImputNumber("Введите координату X");
    double Y = GetImputNumber("Введите координату Y");
    double Z = GetImputNumber("Введите координату Z");

    return (X,Y,Z);
}
double GetDistanceIn3DArea((double X, double Y, double Z) point1, (double X, double Y, double Z) point2)
{
    double lengthX = Math.Pow(point2.X - point1.X, 2);
    double lengthY = Math.Pow(point2.Y - point1.Y, 2);
    double lengthZ = Math.Pow(point2.Z - point1.Z, 2);
    return Math.Sqrt(lengthX + lengthY + lengthZ);
}

(double X, double Y, double Z) point1 = GetPointIn3DArea();
(double X, double Y, double Z) point2 = GetPointIn3DArea();

Console.WriteLine("Расстояние между точками: " + Math.Round(GetDistanceIn3DArea(point1, point2)), 2);

