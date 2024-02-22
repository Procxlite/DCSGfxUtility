using System.Text.RegularExpressions;

namespace DCSGfxUtility
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetDCSPath(dialog.SelectedPath);
                installPath.Text = DCSPath;
                SetSelectedPreset("");
                SetCustomNameFile();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SavedGamesPath_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetSavedPath(dialog.SelectedPath);
                savedGamesPath.Text = GetSavedPath();
                SetSelectedPreset("");
            }
        }

        private void InstallPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetCustomNameFile()
        {
            try
            {
                customNameFile = GetDCSPath() + "\\MissionEditor\\modules\\Options\\TabViewGraphics.lua";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void SetSavedPath(string path)
        {
            SavedPath = path;
        }

        private void SetDCSPath(string path)
        {
            DCSPath = path;
        }

        private string GetCustomNameFile()
        {
            return customNameFile;
        }
        private string GetSavedPath()
        {
            return SavedPath;
        }

        private string GetDCSPath()
        {
            return DCSPath;
        }

        private string GetSelectedPreset()
        {
            return selectedCustomPreset;
        }

        private void SetSelectedPreset(string preset)
        {
            selectedCustomPreset = preset;
            switch (preset)
            {
                case "Custom1":
                    custom1Button.Enabled = false;
                    custom2Button.Enabled = true;
                    custom3Button.Enabled = true;
                    renameTB.Enabled = true;
                    renameButton.Enabled = true; break;
                case "Custom2":
                    custom1Button.Enabled = true;
                    custom2Button.Enabled = false;
                    custom3Button.Enabled = true;
                    renameTB.Enabled = true;
                    renameButton.Enabled = true; break;
                case "Custom3":
                    custom1Button.Enabled = true;
                    custom2Button.Enabled = true;
                    custom3Button.Enabled = false;
                    renameTB.Enabled = true;
                    renameButton.Enabled = true; break;
                case "invalidInstall":
                    custom1Button.Enabled = true;
                    custom2Button.Enabled = true;
                    custom3Button.Enabled = true;
                    renameTB.Enabled = false;
                    renameButton.Enabled = false; break;
                case "invalidSaved":
                    custom1Button.Enabled = true;
                    custom2Button.Enabled = true;
                    custom3Button.Enabled = true;
                    renameTB.Enabled = false;
                    renameButton.Enabled = false; break;
                default:
                    custom1Button.Enabled = true;
                    custom2Button.Enabled = true;
                    custom3Button.Enabled = true;
                    renameTB.Enabled = false;
                    renameButton.Enabled = false;
                    label3.Text = ""; break;
            }
        }

        private void renamePreset(string rename)
        {
            int i = 0;
            switch (GetSelectedPreset())
            {
                case "Custom1":
                    i = 74;
                    break;
                case "Custom2":
                    i = 75;
                    break;
                case "Custom3":
                    i = 76;
                    break;
                default:
                    break;
            }
            if (i != 0)
            {
                string[] customFileContents = File.ReadAllLines(GetCustomNameFile());
                customFileContents[i] = Regex.Replace(customFileContents[i], "\"[^\"]*\"", "\"" + rename + "\"");
                File.WriteAllLines(GetCustomNameFile(), customFileContents);
                SetSelectedPreset("");
                renameTB.Text = "";
            }
        }
        private void custom1Button_Click(object sender, EventArgs e)
        {
            SetSelectedPreset("Custom1");
            try
            {
                string custom1Path = GetSavedPath() + "\\Config\\OptionsPresets\\Custom1.lua";
                if (File.Exists(custom1Path))
                {
                    if (File.Exists(GetCustomNameFile()))
                    {
                        string[] customFileContents = File.ReadAllLines(GetCustomNameFile());
                        //System.Diagnostics.Debug.WriteLine(custom1FileContents[74]);
                        //Regex regExpr = new Regex("\"[^\"]*\"", RegexOptions.IgnoreCase);
                        string lineCheck = customFileContents[74];
                        foreach (Match match in Regex.Matches(lineCheck, "\"[^\"]*\""))
                        {
                            var debugRegex = match.ToString();
                            label3.Text = debugRegex.Substring(1, debugRegex.Length - 2);
                        }
                    }
                    else
                    {
                        label3.Text = "Invalid DCS Install directory.";
                        SetSelectedPreset("invalidInstall");
                    }
                }
                else
                {
                    label3.Text = "Custom1.lua does not exist in Saved Games path.";
                    SetSelectedPreset("invalidSaved");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }
        private void custom2Button_Click(object sender, EventArgs e)
        {
            SetSelectedPreset("Custom2");
            try
            {
                string custom2Path = GetSavedPath() + "\\Config\\OptionsPresets\\Custom2.lua";
                if (File.Exists(custom2Path))
                {
                    if (File.Exists(GetCustomNameFile()))
                    {
                        string[] customFileContents = File.ReadAllLines(GetCustomNameFile());
                        //System.Diagnostics.Debug.WriteLine(custom2FileContents[75]);
                        //Regex regExpr = new Regex("\"[^\"]*\"", RegexOptions.IgnoreCase);
                        string lineCheck = customFileContents[75];
                        foreach (Match match in Regex.Matches(lineCheck, "\"[^\"]*\""))
                        {
                            var debugRegex = match.ToString();
                            label3.Text = debugRegex.Substring(1, debugRegex.Length - 2);
                        }
                    }
                    else
                    {
                        label3.Text = "Invalid DCS Install directory.";
                        SetSelectedPreset("invalidInstall");
                    }
                }
                else
                {
                    label3.Text = "Custom2.lua does not exist in Saved Games path.";
                    SetSelectedPreset("invalidSaved");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void custom3Button_Click(object sender, EventArgs e)
        {
            SetSelectedPreset("Custom3");
            try
            {
                string custom3Path = GetSavedPath() + "\\Config\\OptionsPresets\\Custom3.lua";
                if (File.Exists(custom3Path))
                {
                    if (File.Exists(GetCustomNameFile()))
                    {
                        string[] customFileContents = File.ReadAllLines(GetCustomNameFile());
                        //System.Diagnostics.Debug.WriteLine(custom3FileContents[76]);
                        //Regex regExpr = new Regex("\"[^\"]*\"", RegexOptions.IgnoreCase);
                        string lineCheck = customFileContents[76];
                        foreach (Match match in Regex.Matches(lineCheck, "\"[^\"]*\""))
                        {
                            var debugRegex = match.ToString();
                            label3.Text = debugRegex.Substring(1, debugRegex.Length - 2);
                        }
                    }
                    else
                    {
                        label3.Text = "Invalid DCS Install directory.";
                        SetSelectedPreset("invalidInstall");
                    }
                }
                else
                {
                    label3.Text = "Custom3.lua does not exist in Saved Games path.";
                    SetSelectedPreset("invalidSaved");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private string SavedPath = "";
        private string DCSPath = "";
        private string selectedCustomPreset = "";
        private string customNameFile = "";

        private void renameButton_Click(object sender, EventArgs e)
        {
            string preset = GetSelectedPreset();
            string renameToText = renameTB.Text.ToString();
            if (!string.IsNullOrEmpty(renameToText))
            {
                renamePreset(renameToText);
                MessageBox.Show("Success!");
            }
        }

        private void renameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}