# SharpFastboot
LibUsb Fastboot (Based On Potato.Fastboot)

Credits: mashed-potatos - for the original lib

you can find it here: https://github.com/mashed-potatoes/Potato.Fastboot

this project is an example you can integrate the fastboot.cs into your own project


examples:

```
var fastboot = new Fastboot();
    fastboot.Connect();
    Console.WriteLine("Connected.");
    Console.WriteLine("Executing: fastboot reboot-fastboot"); 
    fastboot.Reboot(Fastboot.RebootOptions.Fastbootd); // this reboots your phone into the userspace fastboot```
    ``` var fastboot = new Fastboot();
        fastboot.Connect();
        Console.WriteLine("Connected.");
        Console.WriteLine("Executing: fastboot reboot-recovery"); // reboots your phone into recovery mode
        fastboot.Reboot(Fastboot.RebootOptions.Recovery);
        Console.WriteLine("Your Device Should Be In Recovery Now.");```
  
  var fastboot = new Fastboot();
        fastboot.Connect();
        Console.WriteLine("Connected.");
        fastboot.SendOemCommand("unlock"); // this sends the oem command unlock to the phone to then prompt if the bootloader should be unlocked```
        
   ```  var fastboot = new Fastboot();
        fastboot.Connect();
        Console.WriteLine("Connected.");
        fastboot.Boot("//temp/boot.img"); // this sends the boot.img and boots it```
        
        
