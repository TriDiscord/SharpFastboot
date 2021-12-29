using RecoveryBoot;

Main:
Console.WriteLine("Attempting to connect to device...");
try
{
    
    var fastboot = new Fastboot();
    fastboot.Connect();
    Console.WriteLine("Connected.");
    Console.WriteLine("Executing: fastboot reboot-fastboot");
    fastboot.Reboot(Fastboot.RebootOptions.Fastbootd);
    Console.WriteLine("Waiting for 15 seconds...\n\n If The Program Looks Like Its Frozen It Isnt Windows Just Detects It As Frozen.");
    Thread.Sleep(15000);
    FastD:
    Console.WriteLine("Reconnecting...");
    var fastbootd = new Fastboot();
    try
    {
        fastbootd.Connect();
        Console.WriteLine("Connected.");
        Console.WriteLine("Executing: fastboot reboot-recovery");
        fastbootd.Reboot(Fastboot.RebootOptions.Recovery);
        Console.WriteLine("Your Device Should Be In Recovery Now.");
    }
    catch(Exception ex)
    {
        if (ex.Message == "No devices available.")
        {
            Console.WriteLine("No Device Has Been Detected Connect Your Device And Press Any Key To Retry");
            Console.ReadKey();
            goto FastD;
        }
    }
}
catch(Exception ex)
{
    if(ex.Message == "No devices available.")
    {
        Console.WriteLine("No Device Has Been Detected Connect Your Device In **FASTBOOT MODE** And Press Any Key To Retry");
        Console.ReadKey();
        goto Main;
    }
}
Thread.Sleep(-1);