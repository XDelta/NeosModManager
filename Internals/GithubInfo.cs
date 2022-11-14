using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using NeosModManager.Internals;

namespace NeosModManager.Internals;

//Deserialized from github urls like https://api.github.com/repos/XDelta/NeosModManager/releases/latest

public class GithubInfo {
    [JsonPropertyName("url")]
    public string url { get; set; }

    [JsonPropertyName("tag_name")]
    public string tag_name { get; set; }

    [JsonPropertyName("prerelease")]
    public bool prerelease { get; set; }

    //[JsonPropertyName("assets")]

    [JsonPropertyName("body")]
    public string body { get; set; }
}