// See https://aka.ms/new-console-template for more information
//Interface is a contract
//Classes implements interfaces



public class BatteryPoweredGameController:GameController,IBatteryPowered
{
    public int BatteryLevel { get; set; }
}