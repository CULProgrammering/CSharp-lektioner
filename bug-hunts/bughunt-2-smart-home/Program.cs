SmartDevice hub = new SmartDevice("Hub");

List<SmartDevice> devices = new List<SmartDevice>();
devices.Add(new SmartLamp("Kitchen Lamp"));
devices.Add(new SmartSpeaker("Living Room Speaker"));

foreach (SmartDevice d in devices)
{
    d.TurnOn();
    d.Report();
}
