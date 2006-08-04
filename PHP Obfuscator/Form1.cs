using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Obfuscation;

namespace PHP_Obfuscator
{
    /// <summary>
    /// User interface for the PHP Obfuscator
    /// </summary>
    public partial class MainForm : Form, IObfuscatorUI
    {
        Obfuscator _ob = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _ob = new Obfuscator(this);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = sourceDirectory.Text;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // setting this will force the list to be regenerated. 
                sourceDirectory.Text = dlg.SelectedPath;
                PopulateList();
            }
        }

        /// <summary>
        /// Populates the list of source code files from the current source directory and its sub directories. 
        /// </summary>
        private void PopulateList()
        {
            obfuscateList.Items.Clear();

            if (sourceDirectory.Text.Length > 0 && Directory.Exists(sourceDirectory.Text))
            {
                try
                {
                    string[] files = Directory.GetFiles(sourceDirectory.Text, "*.*", SearchOption.AllDirectories);

                    foreach (string file in files)
                    {
                        CheckState check;

                        FileInfo info = new FileInfo(file);
                        if (info.Extension.ToLower() == ".php")
                            check = CheckState.Checked;
                        else
                            check = CheckState.Unchecked;

                        obfuscateList.Items.Add(file, check);

                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void browseButtonTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = targetDirectory.Text;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                targetDirectory.Text = dlg.SelectedPath;
            }
        }

        /// <summary>
        /// Delegate for enabling the UI. Should be used when another thread indicates that we are starting or are finished
        /// obfuscating. 
        /// </summary>
        /// <param name="enable">Flag indicating whether to enable or disable the UI</param>
        private delegate void EnableDelegate(bool enable);
        private void Enable(bool enable)
        {
            if (enable)
            {
                obfuscateButton.Enabled = true;
                tabControl1.Enabled = true;
            }
            else
            {
                obfuscateButton.Enabled = false;
                tabControl1.Enabled = false;
            }
        }


        private void obfuscateButton_Click(object sender, EventArgs e)
        {
           
            Properties.Settings settings = Properties.Settings.Default;
            settings["lastTargetDir"] = targetDirectory.Text;
            settings["lastSourceDir"] = sourceDirectory.Text;
            settings.Save();

            ObfuscationConfig config = GenerateConfig();

            if (sourceDirectory.Text != "" && targetDirectory.Text != "")
            {
                if (Directory.Exists(targetDirectory.Text))
                {
                    if (DialogResult.Yes == MessageBox.Show("Target Directory exists. Are you sure you would like to over-write it?",
                                                            "Delete Target?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        Enable(false);
                        //_ob.Start(sourceDirectory.Text, targetDirectory.Text, filesToObfuscate);
                        _ob.Start(config, true);
                    }
                }
                else
                {
                    Enable(false);
                    //_ob.Start(sourceDirectory.Text, targetDirectory.Text, filesToObfuscate);
                    _ob.Start(config, true);
                }
            }
                
        }

        /// <summary>
        /// Loads the previous settings used in this application
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            targetDirectory.Text = settings["lastTargetDir"] as string;
            sourceDirectory.Text = settings["lastSourceDir"] as string;

            StringCollection collection = settings["excludedFunctions"] as StringCollection;
            if (null != collection)
            {
                foreach (string item in collection)
                {
                    string[] itemArr = item.Split(new char[] { ':' });
                    excludeFunctionsList.Items.Add(itemArr[0], (itemArr[1] == "checked"));
                }
            }

            collection = settings["excludedVariables"] as StringCollection;
            if (null != collection)
            {
                foreach (string item in collection)
                {
                    string[] itemArr = item.Split(new char[] { ':' });
                    excludeVariablesList.Items.Add(itemArr[0], (itemArr[1] == "checked"));
                }
            }

            PopulateList();
        }



        private void addVariableButton_Click(object sender, EventArgs e)
        {
            if (variableBox.Text.Length > 1)
            {
                excludeVariablesList.Items.Add(variableBox.Text, true);
                variableBox.Text = "$";

                StringCollection collection = new StringCollection();
                for(int idx = 0; idx < excludeVariablesList.Items.Count; idx++)
                {
                    string item = (string)excludeVariablesList.Items[idx];
                    if(excludeVariablesList.GetItemChecked(idx))
                        item += ":checked";
                    else
                        item += ":unchecked";

                    collection.Add(item);
                }
                
                Properties.Settings.Default["excludedVariables"] = collection;
                Properties.Settings.Default.Save();
            }
        }

        private void addFunctionButton_Click(object sender, EventArgs e)
        {
            if (functionBox.Text.Length > 0)
            {
                excludeFunctionsList.Items.Add(functionBox.Text, true);

                StringCollection collection = new StringCollection();
                for (int idx = 0; idx < excludeFunctionsList.Items.Count; idx++)
                {
                    string item = (string)excludeFunctionsList.Items[idx];
                    if (excludeFunctionsList.GetItemChecked(idx))
                        item += ":checked";
                    else
                        item += ":unchecked";

                    collection.Add(item);
                }

                Properties.Settings.Default["excludedFunctions"] = collection;
                Properties.Settings.Default.Save();
            }
        }

        private void removeFunction_Click(object sender, EventArgs e)
        {
            if(null != excludeFunctionsList.SelectedItem)
                excludeFunctionsList.Items.Remove(excludeFunctionsList.SelectedItem);
        }

        private void removeVariable_Click(object sender, EventArgs e)
        {
            if (null != excludeVariablesList.SelectedItem)
                excludeVariablesList.Items.Remove(excludeVariablesList.SelectedItem);
        }

        /// <summary>
        /// Generates a configuation file that can be reloaded in subsequent executions of this tool, or 
        /// can be used to run the command line version of this tool.
        /// </summary>
        /// <returns></returns>
        private Obfuscation.ObfuscationConfig GenerateConfig()
        {
            Obfuscation.ObfuscationConfig config = new ObfuscationConfig();

            config.SourceDir = sourceDirectory.Text;
            config.TargetDir = targetDirectory.Text;

            config.RemoveWhitespace = removeWhitespace.Checked;
            config.RenameVariables = obfuscateVariableNames.Checked;
            config.RenameFunctions = obfuscateFunctionNames.Checked;

            List<string> excludeFunctions = new List<string>(excludeFunctionsList.CheckedItems.Count);
            foreach (string item in excludeFunctionsList.CheckedItems)
                excludeFunctions.Add(item);

            config.ExcludeFunctions = excludeFunctions.ToArray();

            List<string> excludeVariables = new List<string>(excludeVariablesList.CheckedItems.Count);
            foreach (string item in excludeVariablesList.CheckedItems)
                excludeVariables.Add(item);

            config.ExcludeVariables = excludeVariables.ToArray();

            List<string> filesToObfuscate = new List<string>(obfuscateList.CheckedItems.Count);

            foreach (string file in obfuscateList.CheckedItems)
            {
                filesToObfuscate.Add(file);
            }
            config.FilesToObfuscate = filesToObfuscate.ToArray();

            return config;

        }

        /// <summary>
        /// Saves the current project settings to an XML file that can be reloaded later or used 
        /// to run the command line version of this tool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObfuscationConfig config = GenerateConfig();

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "obxml";
            dlg.Filter = "PHP Obfuscator XML (*.obxml)|*.obxml";
            //dlg.InitialDirectory = "c:\\";
            dlg.FileName = "New Project";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                string filename = dlg.FileName;
                config.Save(filename);
            }

        }

        /// <summary>
        /// Loads a previously saved project and restores its settings to the screen. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "xml";
            dlg.Filter = "PHP Obfuscator XML (*.obxml)|*.obxml";
            //dlg.InitialDirectory = "c:\\";


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filename = dlg.FileName;
                ObfuscationConfig config = ObfuscationConfig.Open(filename);

                if (null == config)
                {
                    MessageBox.Show("There was an error opening the selected project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sourceDirectory.Text = config.SourceDir;
                targetDirectory.Text = config.TargetDir;

                // clear the exclude functions
                excludeFunctionsList.Items.Clear();
                excludeFunctionsList.Items.AddRange(config.ExcludeFunctions);
                for (int idx = 0; idx < excludeFunctionsList.Items.Count; idx++)
                    excludeFunctionsList.SetItemChecked(idx, true);

                // clear the exclude variables
                excludeVariablesList.Items.Clear();
                excludeVariablesList.Items.AddRange(config.ExcludeVariables);
                for (int idx = 0; idx < excludeVariablesList.Items.Count; idx++)
                    excludeVariablesList.SetItemChecked(idx, true);

                List<string> itemsToCheck = new List<string>(config.FilesToObfuscate);
                for(int idx = 0; idx < obfuscateList.Items.Count; idx++)
                {
                    obfuscateList.SetItemChecked(idx, itemsToCheck.Contains((string)obfuscateList.Items[idx]));
                }

            }
            
        }

        private void sourceDirectory_Leave(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }


        #region IObfuscatorUI Members

        public void StatusUpdate(string status)
        {
            toolStripStatusLabel1.Text = status;
        }

        public void Done()
        {
            toolStripStatusLabel1.Text = "Done.";

            // invoke enable on our own thread in case Done was called from another
            this.Invoke(new EnableDelegate(Enable), new object[] { true });
        }

        public void Error(string errorText)
        {
            toolStripStatusLabel1.Text = "Error: " + errorText;

            // invoke enable on our own thread in case Error was called from another
            this.Invoke(new EnableDelegate(Enable), new object[] { true });
        }

        #endregion

        private void sourceDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PopulateList();
        }

    }
}