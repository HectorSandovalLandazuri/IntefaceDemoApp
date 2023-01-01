// See https://aka.ms/new-console-template for more information
//Interface is a contract
//Classes implements interfaces
List<IComputerController> controllers = new List<IComputerController>();
Keyboard keyboard = new Keyboard();
BatteryPoweredKeyBoard batteryKeyboard=new BatteryPoweredKeyBoard();
GameController gameController = new GameController();
BatteryPoweredGameController battery = new BatteryPoweredGameController();
controllers.Add(keyboard);
controllers.Add(gameController);
controllers.Add(battery);
List<IBatteryPowered> powereds = new List<IBatteryPowered>();
powereds.Add(battery);
powereds.Add(batteryKeyboard);

List <IRun> runners=new List<IRun>();
Person person=new Person();
Animal animal=new Animal();
runners.Add(person);
runners.Add(animal);

foreach(IComputerController controller in controllers)
{
    if (controller is GameController gc)
    {
        
    }   
    if (controller is IBatteryPowered powered)
    {

    }
}

using (GameController gc = new GameController())
{

}
