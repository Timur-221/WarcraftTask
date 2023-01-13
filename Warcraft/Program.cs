using Warcraft;

Mage mage = new Mage();
Peasant peasant = new Peasant();
Footman footman = new Footman(5);
Archer archer = new Archer();
BlackSmith blacksmith = new BlackSmith();

//archer.Attack(peasant);
//archer.Attack(peasant);
//archer.Attack(footman);
//mage.TargetHeal(peasant);
//footman.Attack(archer);
//footman.Attack(archer);
//footman.Attack(archer);
//footman.Attack(archer);
//footman.Attack(archer);
//footman.Attack(archer);
//mage.TargetHeal(archer);


Console.WriteLine("Битва Гладиаторов смотреть без смс и регестрации!!!");
Thread.Sleep(1000);
Console.WriteLine("");

footman.Name = "Андрей";
archer.Name = "Василий";

Task info = new Task(() =>
{
    Console.WriteLine("Информация о Лучнике.");
    archer.GetInfo();
    Thread.Sleep(1000);
    Console.WriteLine("");

    Console.WriteLine("Информация о Мечнике.");
    footman.GetInfo();
    Thread.Sleep(1000);
    Console.WriteLine("");

    Console.WriteLine("Начало битвы!");

});
info.Start();
info.Wait();

Task.Run(() => Fight(footman, archer));
Task.Run(() => Fight(footman, archer)).Wait();

static void Fight (Footman footman,Archer archer)
{
    footman.Attack(archer);
    Thread.Sleep(1000);
    archer.Attack(footman);
    Thread.Sleep(1000);
    footman.Attack(archer);
    Thread.Sleep(1000);
    archer.Attack(footman);
    Thread.Sleep(1000);
    footman.Attack(archer);
    Thread.Sleep(1000);
}
Console.WriteLine("");
Console.WriteLine("Андрей победил и повышает свой уровень!");
Thread.Sleep(1000);
blacksmith.UpgradeUnit(footman);
footman.GetInfo();

//Task fight = new Task(() =>
//{
//    Console.WriteLine("Начало битвы!");
//    Thread.Sleep(1000);

//    archer.Attack(footman);
//    Thread.Sleep(1000);

//    footman.Attack(archer);
//    Thread.Sleep(1000);

//    archer.Attack(footman);
//    Thread.Sleep(1000);

//    footman.Attack(archer);
//    Thread.Sleep(1000);

//    Console.WriteLine("Стрела полетела мимо.");
//    Thread.Sleep(1000);
//    archer.Attack(peasant);
//});
//fight.Start();
//fight.Wait();

//Console.WriteLine("");

