
using BackUp;

IStorage flashDrive = new Flash("Frash Drive", "USB 3.0", 3.0, 128.0);
IStorage dvdDisc = new DVD("DVD", "DVD-R", 9.0, 6.9,true);
IStorage externalHDD = new HDD("HDD", "USB 2.0", 2.0, 1000.0);


flashDrive.MediaType();
flashDrive.CopyMethod();
flashDrive.PrintDeviceInfo();

dvdDisc.MediaType();
dvdDisc.CopyMethod();
dvdDisc.PrintDeviceInfo();  


externalHDD.MediaType();
externalHDD.CopyMethod();    
externalHDD.PrintDeviceInfo();
