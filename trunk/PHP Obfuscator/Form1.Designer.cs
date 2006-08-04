namespace PHP_Obfuscator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.sourceDirectory = new System.Windows.Forms.TextBox();
            this.browseButtonSource = new System.Windows.Forms.Button();
            this.browseButtonTarget = new System.Windows.Forms.Button();
            this.targetDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.obfuscateButton = new System.Windows.Forms.Button();
            this.obfuscateList = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeFunction = new System.Windows.Forms.Button();
            this.removeVariable = new System.Windows.Forms.Button();
            this.addFunctionButton = new System.Windows.Forms.Button();
            this.functionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.excludeFunctionsList = new System.Windows.Forms.CheckedListBox();
            this.addVariableButton = new System.Windows.Forms.Button();
            this.variableBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.excludeVariablesList = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.obfuscateFunctionNames = new System.Windows.Forms.CheckBox();
            this.obfuscateVariableNames = new System.Windows.Forms.CheckBox();
            this.removeWhitespace = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Source Directory";
            // 
            // sourceDirectory
            // 
            this.sourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sourceDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.sourceDirectory.Location = new System.Drawing.Point(6, 20);
            this.sourceDirectory.Name = "sourceDirectory";
            this.sourceDirectory.Size = new System.Drawing.Size(767, 20);
            this.sourceDirectory.TabIndex = 1;
            this.sourceDirectory.Leave += new System.EventHandler(this.sourceDirectory_Leave);
            this.sourceDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sourceDirectory_KeyDown);
            // 
            // browseButtonSource
            // 
            this.browseButtonSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonSource.Location = new System.Drawing.Point(779, 20);
            this.browseButtonSource.Name = "browseButtonSource";
            this.browseButtonSource.Size = new System.Drawing.Size(55, 23);
            this.browseButtonSource.TabIndex = 2;
            this.browseButtonSource.Text = "Browse";
            this.browseButtonSource.UseVisualStyleBackColor = true;
            this.browseButtonSource.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseButtonTarget
            // 
            this.browseButtonTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonTarget.Location = new System.Drawing.Point(779, 59);
            this.browseButtonTarget.Name = "browseButtonTarget";
            this.browseButtonTarget.Size = new System.Drawing.Size(55, 23);
            this.browseButtonTarget.TabIndex = 5;
            this.browseButtonTarget.Text = "Browse";
            this.browseButtonTarget.UseVisualStyleBackColor = true;
            this.browseButtonTarget.Click += new System.EventHandler(this.browseButtonTarget_Click);
            // 
            // targetDirectory
            // 
            this.targetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.targetDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.targetDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.targetDirectory.Location = new System.Drawing.Point(6, 59);
            this.targetDirectory.Name = "targetDirectory";
            this.targetDirectory.Size = new System.Drawing.Size(767, 20);
            this.targetDirectory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Target Directory";
            // 
            // obfuscateButton
            // 
            this.obfuscateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.obfuscateButton.Location = new System.Drawing.Point(762, 423);
            this.obfuscateButton.Name = "obfuscateButton";
            this.obfuscateButton.Size = new System.Drawing.Size(75, 23);
            this.obfuscateButton.TabIndex = 6;
            this.obfuscateButton.Text = "Obfuscate >";
            this.obfuscateButton.UseVisualStyleBackColor = true;
            this.obfuscateButton.Click += new System.EventHandler(this.obfuscateButton_Click);
            // 
            // obfuscateList
            // 
            this.obfuscateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.obfuscateList.FormattingEnabled = true;
            this.obfuscateList.Location = new System.Drawing.Point(6, 101);
            this.obfuscateList.Name = "obfuscateList";
            this.obfuscateList.Size = new System.Drawing.Size(828, 229);
            this.obfuscateList.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 22);
            this.statusStrip1.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 392);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.obfuscateList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sourceDirectory);
            this.tabPage1.Controls.Add(this.browseButtonSource);
            this.tabPage1.Controls.Add(this.browseButtonTarget);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.targetDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeFunction);
            this.tabPage2.Controls.Add(this.removeVariable);
            this.tabPage2.Controls.Add(this.addFunctionButton);
            this.tabPage2.Controls.Add(this.functionBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.excludeFunctionsList);
            this.tabPage2.Controls.Add(this.addVariableButton);
            this.tabPage2.Controls.Add(this.variableBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.excludeVariablesList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exclusions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeFunction
            // 
            this.removeFunction.Location = new System.Drawing.Point(397, 343);
            this.removeFunction.Name = "removeFunction";
            this.removeFunction.Size = new System.Drawing.Size(116, 23);
            this.removeFunction.TabIndex = 9;
            this.removeFunction.Text = "Remove Selected";
            this.removeFunction.UseVisualStyleBackColor = true;
            this.removeFunction.Click += new System.EventHandler(this.removeFunction_Click);
            // 
            // removeVariable
            // 
            this.removeVariable.Location = new System.Drawing.Point(94, 343);
            this.removeVariable.Name = "removeVariable";
            this.removeVariable.Size = new System.Drawing.Size(116, 23);
            this.removeVariable.TabIndex = 8;
            this.removeVariable.Text = "Remove Selected";
            this.removeVariable.UseVisualStyleBackColor = true;
            this.removeVariable.Click += new System.EventHandler(this.removeVariable_Click);
            // 
            // addFunctionButton
            // 
            this.addFunctionButton.Location = new System.Drawing.Point(418, 35);
            this.addFunctionButton.Name = "addFunctionButton";
            this.addFunctionButton.Size = new System.Drawing.Size(75, 23);
            this.addFunctionButton.TabIndex = 7;
            this.addFunctionButton.Text = "Add";
            this.addFunctionButton.UseVisualStyleBackColor = true;
            this.addFunctionButton.Click += new System.EventHandler(this.addFunctionButton_Click);
            // 
            // functionBox
            // 
            this.functionBox.Location = new System.Drawing.Point(312, 37);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(100, 20);
            this.functionBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exclude these functions from obfuscation:";
            // 
            // excludeFunctionsList
            // 
            this.excludeFunctionsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.excludeFunctionsList.FormattingEnabled = true;
            this.excludeFunctionsList.Location = new System.Drawing.Point(312, 63);
            this.excludeFunctionsList.Name = "excludeFunctionsList";
            this.excludeFunctionsList.Size = new System.Drawing.Size(201, 274);
            this.excludeFunctionsList.TabIndex = 4;
            // 
            // addVariableButton
            // 
            this.addVariableButton.Location = new System.Drawing.Point(115, 35);
            this.addVariableButton.Name = "addVariableButton";
            this.addVariableButton.Size = new System.Drawing.Size(75, 23);
            this.addVariableButton.TabIndex = 3;
            this.addVariableButton.Text = "Add";
            this.addVariableButton.UseVisualStyleBackColor = true;
            this.addVariableButton.Click += new System.EventHandler(this.addVariableButton_Click);
            // 
            // variableBox
            // 
            this.variableBox.Location = new System.Drawing.Point(9, 37);
            this.variableBox.Name = "variableBox";
            this.variableBox.Size = new System.Drawing.Size(100, 20);
            this.variableBox.TabIndex = 2;
            this.variableBox.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exclude these variables from obfuscation:";
            // 
            // excludeVariablesList
            // 
            this.excludeVariablesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.excludeVariablesList.FormattingEnabled = true;
            this.excludeVariablesList.Location = new System.Drawing.Point(9, 63);
            this.excludeVariablesList.Name = "excludeVariablesList";
            this.excludeVariablesList.Size = new System.Drawing.Size(201, 274);
            this.excludeVariablesList.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.obfuscateFunctionNames);
            this.tabPage3.Controls.Add(this.obfuscateVariableNames);
            this.tabPage3.Controls.Add(this.removeWhitespace);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // obfuscateFunctionNames
            // 
            this.obfuscateFunctionNames.AutoSize = true;
            this.obfuscateFunctionNames.Checked = true;
            this.obfuscateFunctionNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.obfuscateFunctionNames.Location = new System.Drawing.Point(8, 52);
            this.obfuscateFunctionNames.Name = "obfuscateFunctionNames";
            this.obfuscateFunctionNames.Size = new System.Drawing.Size(155, 17);
            this.obfuscateFunctionNames.TabIndex = 2;
            this.obfuscateFunctionNames.Text = "Obfuscate Function Names";
            this.obfuscateFunctionNames.UseVisualStyleBackColor = true;
            // 
            // obfuscateVariableNames
            // 
            this.obfuscateVariableNames.AutoSize = true;
            this.obfuscateVariableNames.Checked = true;
            this.obfuscateVariableNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.obfuscateVariableNames.Location = new System.Drawing.Point(8, 29);
            this.obfuscateVariableNames.Name = "obfuscateVariableNames";
            this.obfuscateVariableNames.Size = new System.Drawing.Size(152, 17);
            this.obfuscateVariableNames.TabIndex = 1;
            this.obfuscateVariableNames.Text = "Obfuscate Variable Names";
            this.obfuscateVariableNames.UseVisualStyleBackColor = true;
            // 
            // removeWhitespace
            // 
            this.removeWhitespace.AutoSize = true;
            this.removeWhitespace.Checked = true;
            this.removeWhitespace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeWhitespace.Location = new System.Drawing.Point(8, 6);
            this.removeWhitespace.Name = "removeWhitespace";
            this.removeWhitespace.Size = new System.Drawing.Size(126, 17);
            this.removeWhitespace.TabIndex = 0;
            this.removeWhitespace.Text = "Remove Whitespace";
            this.removeWhitespace.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileMenuItem.Text = "File";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutToolStripMenuItem.Text = "About PHP Obfuscator";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.obfuscateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PHP Obfuscator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceDirectory;
        private System.Windows.Forms.Button browseButtonSource;
        private System.Windows.Forms.Button browseButtonTarget;
        private System.Windows.Forms.TextBox targetDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button obfuscateButton;
        private System.Windows.Forms.CheckedListBox obfuscateList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button removeVariable;
        private System.Windows.Forms.Button addFunctionButton;
        private System.Windows.Forms.TextBox functionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox excludeFunctionsList;
        private System.Windows.Forms.Button addVariableButton;
        private System.Windows.Forms.TextBox variableBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox excludeVariablesList;
        private System.Windows.Forms.Button removeFunction;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox removeWhitespace;
        private System.Windows.Forms.CheckBox obfuscateVariableNames;
        private System.Windows.Forms.CheckBox obfuscateFunctionNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

