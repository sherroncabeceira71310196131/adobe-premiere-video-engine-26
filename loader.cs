using System;
using System.Runtime.InteropServices;

class AbletonLoader {
    [DllImport("kernel32.dll")]
    static extern IntPtr LoadLibrary(string lpFileName);

    static void Main(string[] args) {
        Console.WriteLine("[*] Ableton Windows Loader Init...");
        if (args.Length < 1) {
            Console.WriteLine("[!] Usage: loader.exe <session.dll>");
            return;
        }
        IntPtr hLib = LoadLibrary(args[0]);
        if (hLib != IntPtr.Zero) {
            Console.WriteLine("[+] Session DLL loaded: " + args[0]);
        }
    }
}

