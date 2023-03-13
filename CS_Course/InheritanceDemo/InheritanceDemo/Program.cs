// See https://aka.ms/new-console-template for more information
using InheritanceDemo;

Radio myRadio = new Radio(false, "Philips");

myRadio.ListenRadio();
myRadio.SwitchOn();
myRadio.ListenRadio();

TV myTV = new TV(false, "Xiaomi");
myTV.WatchTV();
myTV.SwitchOn();
myTV.WatchTV();
Console.ReadKey();
