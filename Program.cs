DriveInfo? drive = DriveInfo.GetDrives()
    .Where(x => x.Name == "/" || x.Name == "C:\\").FirstOrDefault(); // defaults for now

if (drive is null) { Console.WriteLine("Could not find Root Drive"); return 1; }

float usedPct = (float)(drive.TotalSize - drive.AvailableFreeSpace) / (float)drive.TotalSize;
int numChars = (int)Math.Ceiling((float)20 * usedPct);
string usedChars = new String('#', numChars).PadRight(20, '-');
string usedPctText = (usedPct * 100).ToString("n1");

Console.WriteLine($"Drive: {drive.Name}");
Console.WriteLine($"\u2514 [{usedChars}] {usedPctText}% used");

return 0;