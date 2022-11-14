using System.Text.Json.Serialization;

namespace NeosModManager.Internals;
public class ManifestInfo {

	[JsonPropertyName("schemaVersion")]
	public string schemaVersion { get; set; }
	[JsonPropertyName("mods")]
	public Dictionary<string, ModInfo> mods { get; set; }

	public int Count() {
		if (mods is null) {
			return 0;
		}
		return mods.Count;
	}
}
public class ModInfo {
	[JsonPropertyName("name")]
	public string name { get; set; }

	//Schema 1.1.0, Color - Used for embed coloring
	[JsonPropertyName("color")]
	public string color { get; set; }

	[JsonPropertyName("description")]
	public string description { get; set; }

	[JsonPropertyName("authors")]
	public Dictionary<string, Author> authors { get; set; }

	[JsonPropertyName("sourceLocation")]
	public string sourceLocation { get; set; }

	[JsonPropertyName("website")]
	public string website { get; set; }

	[JsonPropertyName("tags")]
	public string[] tags { get; set; }

	[JsonPropertyName("category")]
	public string category { get; set; }

	[JsonPropertyName("flags")]
	public string[] flags { get; set; }

	[JsonPropertyName("versions")]
	public Dictionary<string, ModVersion> versions { get; set; }

	//Data from installed version if one exists
	public bool modInstalled { get; set; }
	
	public string installedVersion {
		get {
			return installedVersionV.ToString();
		}
	}

	public Version installedVersionV { get; set; }

	public string installedHash { get; set; }

	public FileInfo installedFile { get; set; } // FileInfo on dll that has a hash on the manifest
    //public string installedFilePath { get; set; };

    public bool modHasUpdate { get; set; }

	public bool modEnabled { get; set; }
}

public class Author {
	//public string author { get; set; }
	[JsonPropertyName("url")]
	public string url { get; set; }

	//Schema 1.1.0, iconUrl - Author icon
	[JsonPropertyName("iconUrl")]
	public string iconUrl { get; set; }
}
public class ModVersion {

	[JsonPropertyName("changelog")]
	public string changelog { get; set; }

	[JsonPropertyName("releaseUrl")]
	public string releaseUrl { get; set; }

	[JsonPropertyName("neosVersionCompatibility")]
	public string neosVersionCompatibility { get; set; }

	[JsonPropertyName("modloaderVersionCompatibility")]
	public string modloaderVersionCompatibility { get; set; }

	[JsonPropertyName("flagList")]
	public string[] flagList { get; set; }

	[JsonPropertyName("conflicts")]
	public string[] conflicts { get; set; }

	[JsonPropertyName("dependencies")]
	public Dictionary<string, Dependency> dependencies { get; set; }

	[JsonPropertyName("artifacts")]
	public Artifact[] artifacts { get; set; }
}
public class Dependency {
	[JsonPropertyName("version")]
	public string version { get; set; } //semver version specifier
}
public class Artifact {
	[JsonPropertyName("url")]
	public string url { get; set; }
	[JsonPropertyName("filename")]
	public string filename { get; set; }
	[JsonPropertyName("sha256")]
	public string sha256 { get; set; }

	//should be fine to keep or add new formats as needed, should fill any that exist
	[JsonPropertyName("blake3")]
	public string blake3 { get; set; }
    
	[JsonPropertyName("installLocation")]
	public string installLocation { get; set; }
}