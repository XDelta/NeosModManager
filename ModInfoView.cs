using System.Diagnostics;

using NeosModManager.Internals;

namespace NeosModManager {
    public partial class ModInfoView : Form {
        ModInfo mod;
        public ModInfoView(ModInfo mod) {
            InitializeComponent();
            this.mod = mod;
        }
        private void viewSourceLocation_Click(object sender, EventArgs e) {
            try {
                Log("Opening Source Location for " + mod.name + " by " + String.Join(", ", mod.authors.Keys), Level.VERBOSE);
                if (mod.sourceLocation.StartsWith("http://") || mod.sourceLocation.StartsWith("https://")) {
                    try {
                        Process.Start(new ProcessStartInfo {
                            FileName = mod.sourceLocation,
                            UseShellExecute = true
                        });
                    } catch (Exception ex) {
                        Log(ex, "Attempted to open " + mod.sourceLocation.ToString());
                    }
                }
            } catch (Exception ex) {
                Log(ex);
            }
        }

        private void ModInfoView_Load(object sender, EventArgs e) {
            labelMIV_Name.Text = mod.name;
            labelMIV_Author.Text = $"by: {String.Join(", ", mod.authors.Keys)}";
            labelMIV_Categories.Text = $"Category: {mod.category}";
            labelMIV_Desciption.Text = mod.description;

            labelMIV_InstalledHash.Text = mod.modInstalled ? $"{mod.installedVersionV} - {mod.installedHash}" : $"Not installed";
            //TODO ensure that artifact[0] is the mod dll itself, not some subfile
            var latest = InstallManager.getLatestModVersion(mod);
            try {
                labelMIV_LatestHash.Text = $"{latest.Key} - {latest.Value.artifacts[0].sha256.ToLower()}";
            } catch (IndexOutOfRangeException) {
                labelMIV_LatestHash.Text = "No valid artifacts";
            }
            if (string.IsNullOrWhiteSpace(mod.sourceLocation)) {
                buttonMIV_ViewSource.Enabled = false;
            }
        }
    }
}
