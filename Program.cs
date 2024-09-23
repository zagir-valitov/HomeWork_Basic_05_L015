using HomeWork_Basic_05;


Console.WriteLine(" ---- Home work 5 ----\n");

Quadcopter miTu = new();
Console.WriteLine($"Robot type: {((IFlyingRobot)miTu).GetRobotType()}");
Console.WriteLine($"Model: {miTu.GetInfo()}");

Console.WriteLine("Components: ");
foreach (var component in miTu.GetComponents())
{
    Console.WriteLine(component);
}

Console.WriteLine(((IChargeable)miTu).GetInfo());
miTu.Charge();
Console.WriteLine();



