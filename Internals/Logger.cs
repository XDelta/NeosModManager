using Serilog;
using Serilog.Events;
using Serilog.Core;
using static NeosModManager.Extensions.SerilogThemeExtension;
using NeosModManager.Extensions;

namespace NeosModManager.Internals.Logger;
class Logger {
	public enum Level {
		VERBOSE = LogEventLevel.Verbose, //0
		DEBUG = LogEventLevel.Debug, //1
		INFO = LogEventLevel.Information, //2
		WARN = LogEventLevel.Warning, //3
		ERROR = LogEventLevel.Error, //4
		FATAL = LogEventLevel.Fatal //5
	}
	private static LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch();

	/**<summary>Setup Serilog and default configuration, must be done before calling Log()
	</summary>*/
	public static void LoggerSetup(string[] args) {

		if (args.Contains("-debug")) {
			levelSwitch.MinimumLevel = LogEventLevel.Debug;
		}
		if (args.Contains("-verbose")) {
			levelSwitch.MinimumLevel = LogEventLevel.Verbose;
		}

		Serilog.Log.Logger = new LoggerConfiguration()
			.MinimumLevel.ControlledBy(levelSwitch)
			.WriteTo.Console(outputTemplate: "{Timestamp:HH:mm:ss.fff} [{Level:u4}] {Message}{NewLine}{Exception}", theme: SerilogThemeExtension.ConsoleTheme) //-console Output
			.WriteTo.Debug(outputTemplate: "{Timestamp:HH:mm:ss.fff} [{Level:u4}] {Message}{NewLine}{Exception}") //Debug Output in VS
			.WriteTo.File(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Logs", "log.log"), rollingInterval: RollingInterval.Day, outputTemplate: "{Timestamp:HH:mm:ss.fff} [{Level:u4}] {Message}{NewLine}{Exception}")
			.CreateLogger();
	}

	public static void Log() {
		Serilog.Log.Verbose($"Empty Log Call");
	}

	public static void Log<T>(string template, T obj) {
		Serilog.Log.Information<T>(template, obj);
	}

	public static void Log<T>(ref T logobj) {
		Serilog.Log.Information<T>($"{logobj}", logobj);
	}

	public static void Log(Exception exception, string message="") {
		Serilog.Log.Error(exception, message);
	}

	//TODO show log line in UI
	public static void Log(string message, Level level = Level.INFO) {
		switch (level) {
			case Level.VERBOSE: //0
				Serilog.Log.Verbose(message);
				break;
			case Level.DEBUG: //1
				Serilog.Log.Debug(message);
				break;
			case Level.INFO: //2
				Serilog.Log.Information(message);
				break;
			case Level.WARN://3
				Serilog.Log.Warning(message);
				break;
			case Level.ERROR: //4
#if DEBUG
				Serilog.Log.Error(EscSeq.BGRed + message);
#else
				Serilog.Log.Error(message);
#endif
				break;
			case Level.FATAL: //5
#if DEBUG
				Serilog.Log.Fatal(EscSeq.BGRed + message);
#else
				Serilog.Log.Fatal(message);
#endif
				break;
		}
	}

	public static bool IsDebug() {
		if (levelSwitch.MinimumLevel == LogEventLevel.Debug || levelSwitch.MinimumLevel == LogEventLevel.Verbose) {
			return true;
		}
		return false;
	}
}