using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NeosModManager.Internals;

namespace NeosModManager {
	public partial class NoPathSetPrompt : UserControl {
		public NoPathSetPrompt() {
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		private void buttonSettingsPage_Click(object sender, EventArgs e) {
			MainWindow.CurrentTab.SelectedTab = MainWindow.CurrentTab.TabPages["Settings"];
		}

		private void buttonIgnoreNeosInstallMissing_Click(object sender, EventArgs e) {
			Config.IgnoreNeosInstallMissing = true;
			Config.SaveConfig();
			MainWindow.instance.tabControl_SelectedIndexChanged(MainWindow.CurrentTab, EventArgs.Empty);
		}
	}
}
