using System.Security.Cryptography;

namespace NeosModManager.Internals;

public class Hashing {

	public static string GenerateSHA256(string filepath) {
		if (!File.Exists(filepath)) {
			Log($"Unable to find file:'{filepath}'", Level.ERROR);
			return "";
		}
		try {
			using (var hasher = SHA256.Create()) {
				using (var stream = File.OpenRead(filepath)) {
					var hash = hasher.ComputeHash(stream);
					return BitConverter.ToString(hash).Replace("-", "").ToLower();
				}
			}
		} catch (Exception e) {
			Log(e);
			return "";
		}
	}
}