using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Reflection;
using Catel.Reflection;

namespace CP77Tools.Commands
{
    public class RootCommand : System.CommandLine.RootCommand
    {
        public RootCommand()
        {
            AddCommand(new UnbundleCommand());
            AddCommand(new UncookCommand());
            AddCommand(new RebuildCommand());
            AddCommand(new PackCommand());
            AddCommand(new ExportCommand());

            AddCommand(new DumpCommand());
            AddCommand(new CR2WCommand());

            AddCommand(new HashCommand());
            AddCommand(new OodleCommand());
            AddOption(new Option<bool>(new[]{"--version", "-v"}, "Show version information"));

            Handler = CommandHandler.Create<bool>(RootCommandHandler);
        }

        private void RootCommandHandler(bool version)
        {
            if (version) WriteVersionToConsole();
        }

        private void WriteVersionToConsole()
        {
            Console.WriteLine(@$"
{Assembly.GetExecutingAssembly().GetName().Name}
  Version: {Assembly.GetExecutingAssembly().Version()}

Runtime Environment:
  OS Platform: {Environment.OSVersion.Platform}
  OS Version: {Environment.OSVersion.VersionString}
  Tools Directory: {AppDomain.CurrentDomain.BaseDirectory} 
  Game Directory: {(string.IsNullOrEmpty(Program.TryGetGameInstallDir()) ? "Unable to find" : Program.TryGetGameInstallDir())}

Latest Release:
  https://github.com/WolvenKit/CP77Tools/releases/latest
");
        }
    }
}