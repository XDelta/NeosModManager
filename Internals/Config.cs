namespace NeosModManager.Internals;
class ConfigData {
	public string NeosInstallDirectory {get; set; }
	public bool UseNeosLauncher { get; set; }
	public string NeosDataDirectory { get; set; }
	public string NeosCacheDirectory { get; set; }
	public string LaunchArguments { get; set; }
	public bool IgnoreNeosInstallMissing { get; set; }
}
public class Config {
	//Config file
	private static string ConfigFile;
	private static readonly JsonSerializerOptions JsonSerializerOptions = new() { WriteIndented = true };

	//Config values
	/**<summary>The path for NeosVR/</summary>*/
	public static string NeosInstallDirectory { get; set; } = @"";
	public static bool UseNeosLauncher { get; set; } = false;
	/**<summary>The custom DataPath for NeosVR if set</summary>*/
	public static string NeosDataDirectory { get; set; } = @"";
	/**<summary>The custom CachePath for NeosVR if set</summary>*/
	public static string NeosCacheDirectory { get; set; } = @"";
	public static string LaunchArguments { get; set; } = @"";
	/**<summary>Ignore message prompting to set Neos Install Path</summary>*/
	public static bool IgnoreNeosInstallMissing { get; set; } = false;


	//Derived directories
	/**<summary>The path for NeosModManager/</summary>*/
	public static string LocalDirectory { get; set; } = @"";
	/**<summary>The path for NeosModManager/Cache/</summary>*/
	public static string CacheDirectory { get; set; } = @"";
	/**<summary>The path for NeosVR/nml_mods/</summary>*/
	public static string NMLDirectory { get; set; } = @"";
	/**<summary>The path for NeosVR/nml_libs/</summary>*/
	public static string NMLLibsDirectory { get; set; } = @"";
	/**<summary>The path for NeosVR/Libraries/</summary>*/
	public static string NeosLibsDirectory { get; set; } = @"";


	/**<summary>Build Config file and initialize paths and folders</summary>*/
	public static void init() {
		LocalDirectory = Path.GetDirectoryName(Application.ExecutablePath);

		Log("Running directory: " + LocalDirectory, Level.DEBUG);

		CacheDirectory = Path.Combine(LocalDirectory, "Cache");
		Directory.CreateDirectory(CacheDirectory);
		Directory.CreateDirectory(Path.Combine(CacheDirectory,"files"));

		ConfigFile = Path.Combine(LocalDirectory, "config.json");

		if (!File.Exists(ConfigFile)) {
			Log("Config file not found, creating one");
			WriteNewConfig();
		}
		ReadConfig();
	}

	//If config.json doesn't exist, create a new one
	static void WriteNewConfig() {
		try {
			ConfigData _data = new ConfigData {
				NeosInstallDirectory = "",
				UseNeosLauncher = false,
				LaunchArguments = "",
				NeosDataDirectory = "",
				NeosCacheDirectory = "",
				IgnoreNeosInstallMissing = false
			};
			string json = JsonSerializer.Serialize(_data, JsonSerializerOptions);
			File.WriteAllText(ConfigFile, json);
		} catch (Exception ex) {
			Log(ex);
		}
	}

	//Save ConfigData to file
	public static void SaveConfig() {
		try {
			ConfigData _data = new ConfigData {
				NeosInstallDirectory = NeosInstallDirectory,
				LaunchArguments = LaunchArguments,
				UseNeosLauncher = UseNeosLauncher,
				NeosDataDirectory = NeosDataDirectory,
				NeosCacheDirectory = NeosCacheDirectory,
				IgnoreNeosInstallMissing = IgnoreNeosInstallMissing
			};
			string json = JsonSerializer.Serialize(_data, JsonSerializerOptions);
			File.WriteAllText(ConfigFile, json);
			ReadConfig(); //ensures derived values are updated
		} catch (Exception ex) {
			Log(ex);
		}
	}

	//Read config file into ConfigData
	public static void ReadConfig() {
		string _data = File.ReadAllText(ConfigFile);
		ConfigData openedConfig;

		try {
			openedConfig = JsonSerializer.Deserialize<ConfigData>(_data);
		} catch (Exception ex) {
			Log(ex, "Unable to Deserialize config file");
			WriteNewConfig(); //Write new config file on corrupt or invalid json
			return;
		}

		//TODO check that this directory includes Neos.exe, if it doesn't, reset to ""
		if (Directory.Exists(openedConfig.NeosInstallDirectory)) {
			NeosInstallDirectory = openedConfig.NeosInstallDirectory;
			NeosLibsDirectory = Path.Combine(NeosInstallDirectory, "Libraries");
		} else {
			NeosInstallDirectory = "";
		}
		UseNeosLauncher = openedConfig.UseNeosLauncher;
		LaunchArguments = !string.IsNullOrEmpty(openedConfig.LaunchArguments) ? openedConfig.LaunchArguments : "";

		NeosDataDirectory = Directory.Exists(openedConfig.NeosDataDirectory) ? openedConfig.NeosDataDirectory : "";

		NeosCacheDirectory = Directory.Exists(openedConfig.NeosCacheDirectory) ? openedConfig.NeosCacheDirectory : "";
		//TODO check what happens for missing or invalid keys
		IgnoreNeosInstallMissing = openedConfig.IgnoreNeosInstallMissing;

		//Creates nml_mods and nml_libs if they don't exist
		if (!Directory.Exists(NeosInstallDirectory)) {
			Log("Neos install directory does not exist", Level.ERROR);
			return;
		}
		NMLDirectory = Path.Combine(NeosInstallDirectory, "nml_mods");
		Directory.CreateDirectory(NMLDirectory);

		NMLLibsDirectory = Path.Combine(NeosInstallDirectory, "nml_libs");
		Directory.CreateDirectory(NMLLibsDirectory);
	}
}
