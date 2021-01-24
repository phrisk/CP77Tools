﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using System.CommandLine;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using CP77Tools.Extensions;
using Luna.ConsoleProgressBar;
using Microsoft.Win32;
using WolvenKit.Common.Services;
using RootCommand = CP77Tools.Commands.RootCommand;

namespace CP77Tools
{
    class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
            ServiceLocator.Default.RegisterType<IHashService, HashService>();

            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            logger.OnStringLogged += delegate (object? sender, LogStringEventArgs args)
            {
                switch (args.Logtype)
                {
                    
                    case Logtype.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Logtype.Important:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Logtype.Success:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Logtype.Normal:
                    case Logtype.Wcc:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                Console.WriteLine("[" + args.Logtype + "]" + args.Message);
                Console.ResetColor();
            };

            var rootCommand = new RootCommand();

            //await ConsoleFunctions.UpdateHashesAsync();
            hashService.ReloadLocally();

            // try get oodle dll from game
            if (!TryCopyOodleLib())
            {
                logger.LogString("Could not automatically find oo2ext_7_win64.dll. " +
                                 "Please manually copy and paste the dll found here Cyberpunk 2077\\bin\\x64\\oo2ext_7_win64.dll into this folder: " +
                                 $"{AppDomain.CurrentDomain.BaseDirectory}.");
            }

            // Run
            if (args == null || args.Length == 0)
            {
                // write welcome message
                rootCommand.InvokeAsync("-h").Wait();

                while (true)
                {
                    string line = System.Console.ReadLine();
                    

                    if (line == "q()")
                        return;

                    var pb = new ConsoleProgressBar()
                    {
                        DisplayBars = false,
                        DisplayPercentComplete = false,
                        DisplayAnimation = false
                    };
                    var parsed = CommandLineExtensions.ParseText(line, ' ', '"');

                    logger.PropertyChanged += OnLoggerOnPropertyChanged;
                    void OnLoggerOnPropertyChanged(object? sender, PropertyChangedEventArgs args)
                    {
                        switch (args.PropertyName)
                        {
                            case "Progress":
                            {
                                if (logger.Progress.Item1 == 0)
                                {
                                    pb = new ConsoleProgressBar() { DisplayBars = true, DisplayAnimation = false };
                                }

                                pb?.Report(logger.Progress.Item1);
                                if (logger.Progress.Item1 == 1)
                                {
                                    System.Threading.Thread.Sleep(1000);

                                    Console.WriteLine();
                                    pb?.Dispose();
                                    pb = null;
                                }

                                break;
                            }
                            default:
                                break;
                        }
                    }

                    rootCommand.InvokeAsync(parsed.ToArray()).Wait();

                    await WriteLog();
                    logger.PropertyChanged -= OnLoggerOnPropertyChanged;
                }

            }
            else
            {
                rootCommand.InvokeAsync(args).Wait();

                await WriteLog();
            }


            async Task WriteLog()
            {
                if (string.IsNullOrEmpty(logger.ErrorLogStr))
                    return;

                var t = DateTime.Now.ToString("yyyyMMddHHmmss");
                var fi = new FileInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    $"errorlogs/log_{t}.txt"));
                if (fi.Directory != null)
                {
                    Directory.CreateDirectory(fi.Directory.FullName);
                    var log = logger.ErrorLogStr;
                    await File.WriteAllTextAsync(fi.FullName, log);
                }
                else
                {
                    
                }
            }

        }

        private delegate void StrDelegate(string value);

        private static string GameBinDir = null;
        public static string TryGetGameInstallDir()
        {
            if (!string.IsNullOrEmpty(GameBinDir)) return GameBinDir;
            
            var cp77BinDir = "";
            var cp77exe = "";
            // check for CP77_DIR environment variable first
            var CP77_DIR = System.Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(CP77_DIR) && new DirectoryInfo(CP77_DIR).Exists)
                cp77BinDir = Path.Combine(CP77_DIR, "bin", "x64");
            if (File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
                return cp77BinDir;

            // else: look for install location
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string gameName = "Cyberpunk 2077";
            const string exeName = "Cyberpunk2077.exe";
            var exePath = "";
            StrDelegate strDelegate = msg => cp77exe = msg;

            try
            {
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains(gameName) ||
                            programName.ToString().Contains(gameName))
                        {
                            exePath = Directory.GetFiles(installLocation.ToString(), exeName,
                                SearchOption.AllDirectories).First();
                        }
                    }

                    strDelegate.Invoke(exePath);
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains(gameName) ||
                            programName.ToString().Contains(gameName))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                exePath = Directory.GetFiles(installLocation.ToString(), exeName,
                                    SearchOption.AllDirectories).First();
                        }
                    }

                    strDelegate.Invoke(exePath);
                });

                if (File.Exists(cp77exe))
                    cp77BinDir = new FileInfo(cp77exe).Directory.FullName;
            }
            catch (Exception e)
            {

            }

            if (string.IsNullOrEmpty(cp77BinDir))
                return null;
            if (!File.Exists(Path.Combine(cp77BinDir, "Cyberpunk2077.exe")))
                return null;

            GameBinDir = cp77BinDir;

            return cp77BinDir;
        }

        private static bool TryCopyOodleLib()
        {
            var ass = AppDomain.CurrentDomain.BaseDirectory;
            var destFileName = Path.Combine(ass, "oo2ext_7_win64.dll");
            if (File.Exists(destFileName))
                return true;

            var cp77BinDir = TryGetGameInstallDir();
            if (string.IsNullOrEmpty(cp77BinDir))
                return false;

            // copy oodle dll
            var oodleInfo = new FileInfo(Path.Combine(cp77BinDir, "oo2ext_7_win64.dll"));
            if (!oodleInfo.Exists)
                return false;

            if (!File.Exists(destFileName))
                oodleInfo.CopyTo(destFileName);

            return true;
        }
    }
}
