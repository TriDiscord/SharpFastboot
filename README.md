# SharpFastboot

## Fastboot utility based on `libusb`

This project is a fork of [`Potato.Fastboot`](https://github.com/mashed-potatoes/Potato.Fastboot), credits to go them!

## Examples

```csharp
var fastboot = new Fastboot();
fastboot.Connect();
Console.WriteLine("Connected.");
Console.WriteLine("Executing: fastboot reboot-fastboot"); 
fastboot.Reboot(Fastboot.RebootOptions.Fastbootd); // this reboots your phone into the userspace fastboot
```

```csharp
var fastboot = new Fastboot();
fastboot.Connect();
Console.WriteLine("Connected.");
Console.WriteLine("Executing: fastboot reboot-recovery"); // reboots your phone into recovery mode
fastboot.Reboot(Fastboot.RebootOptions.Recovery);
Console.WriteLine("Your device should be in Recovery Mode.");
```
  
```csharp
var fastboot = new Fastboot();
fastboot.Connect();
Console.WriteLine("Connected.");
fastboot.SendOemCommand("unlock"); // this sends the oem command unlock to the phone to then prompt if the bootloader should be unlocked
```
        
```csharp
var fastboot = new Fastboot();
fastboot.Connect();
Console.WriteLine("Connected.");
fastboot.Boot("//temp/boot.img"); // this sends the boot.img and boots it
```
        
```csharp
var fastboot = new Fastboot();
fastboot.Connect();
Console.WriteLine("Connected.");
fastboot.ResumeBoot(); // this is the equivalent of fastboot continue
```
