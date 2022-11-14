using System.Runtime.InteropServices;

namespace NeosModManager;
static class Program {
	[STAThread]
	static void Main(string[] args) {
		if (args.Contains("-console")) {
			AllocConsole();
			[DllImport("kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			static extern bool AllocConsole();

			[DllImport("kernel32.dll", SetLastError = true)]
			static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);
			[DllImport("kernel32.dll", SetLastError = true)]
			static extern bool GetConsoleMode(IntPtr handle, out int mode);

			[DllImport("kernel32.dll", SetLastError = true)]
			static extern IntPtr GetStdHandle(int handle);

			var handle = GetStdHandle(-11);
			GetConsoleMode(handle, out int mode);
			SetConsoleMode(handle, mode | 0x4);
		}

		Application.SetHighDpiMode(HighDpiMode.SystemAware);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		Application.Run(new MainWindow(args));
		Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

		static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
			//Attempt to catch any crash missed and log it before closing
			Log(e.Exception.Message, Level.FATAL);
			Log(e.Exception.StackTrace, Level.FATAL);
		}
	}
}
