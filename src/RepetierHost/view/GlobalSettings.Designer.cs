namespace RepetierHost.view
{
    partial class GlobalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettings));
            this.groupFilesAndDirectories = new System.Windows.Forms.GroupBox();
            this.labelOKMasg = new System.Windows.Forms.Label();
            this.labelInfoWorkdir = new System.Windows.Forms.Label();
            this.checkLogfile = new System.Windows.Forms.CheckBox();
            this.buttonSearchWorkdir = new System.Windows.Forms.Button();
            this.textWorkdir = new System.Windows.Forms.TextBox();
            this.labelWorkdir = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBehaviour = new System.Windows.Forms.GroupBox();
            this.checkDisableQualityReduction = new System.Windows.Forms.CheckBox();
            this.groupGUI = new System.Windows.Forms.GroupBox();
            this.checkRedGreenSwitch = new System.Windows.Forms.CheckBox();
            this.checkReduceToolbarSize = new System.Windows.Forms.CheckBox();
            this.groupFileAssociations = new System.Windows.Forms.GroupBox();
            this.buttonAssociate = new System.Windows.Forms.Button();
            this.checkNC = new System.Windows.Forms.CheckBox();
            this.checkGCO = new System.Windows.Forms.CheckBox();
            this.checkG = new System.Windows.Forms.CheckBox();
            this.checkGCode = new System.Windows.Forms.CheckBox();
            this.checkOBJ = new System.Windows.Forms.CheckBox();
            this.checkSTL = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.watchTempRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.watchSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupFilesAndDirectories.SuspendLayout();
            this.groupBehaviour.SuspendLayout();
            this.groupGUI.SuspendLayout();
            this.groupFileAssociations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTempRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchSecondNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFilesAndDirectories
            // 
            this.groupFilesAndDirectories.Controls.Add(this.labelOKMasg);
            this.groupFilesAndDirectories.Controls.Add(this.labelInfoWorkdir);
            this.groupFilesAndDirectories.Controls.Add(this.checkLogfile);
            this.groupFilesAndDirectories.Controls.Add(this.buttonSearchWorkdir);
            this.groupFilesAndDirectories.Controls.Add(this.textWorkdir);
            this.groupFilesAndDirectories.Controls.Add(this.labelWorkdir);
            this.groupFilesAndDirectories.Location = new System.Drawing.Point(13, 12);
            this.groupFilesAndDirectories.Name = "groupFilesAndDirectories";
            this.groupFilesAndDirectories.Size = new System.Drawing.Size(518, 158);
            this.groupFilesAndDirectories.TabIndex = 0;
            this.groupFilesAndDirectories.TabStop = false;
            this.groupFilesAndDirectories.Text = "Files and directories";
            // 
            // labelOKMasg
            // 
            this.labelOKMasg.AutoSize = true;
            this.labelOKMasg.ForeColor = System.Drawing.Color.Red;
            this.labelOKMasg.Location = new System.Drawing.Point(125, 42);
            this.labelOKMasg.Name = "labelOKMasg";
            this.labelOKMasg.Size = new System.Drawing.Size(74, 12);
            this.labelOKMasg.TabIndex = 5;
            this.labelOKMasg.Text = "workdirstatus";
            // 
            // labelInfoWorkdir
            // 
            this.labelInfoWorkdir.Location = new System.Drawing.Point(10, 75);
            this.labelInfoWorkdir.Name = "labelInfoWorkdir";
            this.labelInfoWorkdir.Size = new System.Drawing.Size(491, 52);
            this.labelInfoWorkdir.TabIndex = 4;
            this.labelInfoWorkdir.Text = resources.GetString("labelInfoWorkdir.Text");
            // 
            // checkLogfile
            // 
            this.checkLogfile.AutoSize = true;
            this.checkLogfile.Location = new System.Drawing.Point(10, 51);
            this.checkLogfile.Name = "checkLogfile";
            this.checkLogfile.Size = new System.Drawing.Size(85, 16);
            this.checkLogfile.TabIndex = 2;
            this.checkLogfile.Text = "Log session";
            this.checkLogfile.UseVisualStyleBackColor = true;
            // 
            // buttonSearchWorkdir
            // 
            this.buttonSearchWorkdir.Location = new System.Drawing.Point(400, 20);
            this.buttonSearchWorkdir.Name = "buttonSearchWorkdir";
            this.buttonSearchWorkdir.Size = new System.Drawing.Size(101, 22);
            this.buttonSearchWorkdir.TabIndex = 1;
            this.buttonSearchWorkdir.Text = "Browse ...";
            this.buttonSearchWorkdir.UseVisualStyleBackColor = true;
            this.buttonSearchWorkdir.Click += new System.EventHandler(this.buttonSearchWorkdir_Click);
            // 
            // textWorkdir
            // 
            this.textWorkdir.Location = new System.Drawing.Point(119, 20);
            this.textWorkdir.Name = "textWorkdir";
            this.textWorkdir.Size = new System.Drawing.Size(275, 19);
            this.textWorkdir.TabIndex = 0;
            this.textWorkdir.TextChanged += new System.EventHandler(this.textWorkdir_TextChanged);
            // 
            // labelWorkdir
            // 
            this.labelWorkdir.AutoSize = true;
            this.labelWorkdir.Location = new System.Drawing.Point(7, 23);
            this.labelWorkdir.Name = "labelWorkdir";
            this.labelWorkdir.Size = new System.Drawing.Size(81, 12);
            this.labelWorkdir.TabIndex = 0;
            this.labelWorkdir.Text = "Work directory:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(365, 418);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 22);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(451, 418);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(80, 22);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Select working directory";
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // groupBehaviour
            // 
            this.groupBehaviour.Controls.Add(this.checkDisableQualityReduction);
            this.groupBehaviour.Location = new System.Drawing.Point(13, 176);
            this.groupBehaviour.Name = "groupBehaviour";
            this.groupBehaviour.Size = new System.Drawing.Size(518, 51);
            this.groupBehaviour.TabIndex = 2;
            this.groupBehaviour.TabStop = false;
            this.groupBehaviour.Text = "Behaviour";
            // 
            // checkDisableQualityReduction
            // 
            this.checkDisableQualityReduction.AutoSize = true;
            this.checkDisableQualityReduction.Location = new System.Drawing.Point(13, 20);
            this.checkDisableQualityReduction.Name = "checkDisableQualityReduction";
            this.checkDisableQualityReduction.Size = new System.Drawing.Size(213, 16);
            this.checkDisableQualityReduction.TabIndex = 0;
            this.checkDisableQualityReduction.Text = "Disable quality reduction during print";
            this.checkDisableQualityReduction.UseVisualStyleBackColor = true;
            // 
            // groupGUI
            // 
            this.groupGUI.Controls.Add(this.checkRedGreenSwitch);
            this.groupGUI.Controls.Add(this.checkReduceToolbarSize);
            this.groupGUI.Location = new System.Drawing.Point(13, 233);
            this.groupGUI.Name = "groupGUI";
            this.groupGUI.Size = new System.Drawing.Size(519, 77);
            this.groupGUI.TabIndex = 3;
            this.groupGUI.TabStop = false;
            this.groupGUI.Text = "GUI";
            // 
            // checkRedGreenSwitch
            // 
            this.checkRedGreenSwitch.AutoSize = true;
            this.checkRedGreenSwitch.Location = new System.Drawing.Point(13, 44);
            this.checkRedGreenSwitch.Name = "checkRedGreenSwitch";
            this.checkRedGreenSwitch.Size = new System.Drawing.Size(268, 16);
            this.checkRedGreenSwitch.TabIndex = 1;
            this.checkRedGreenSwitch.Text = "Use red/green switch buttons (requires restart)";
            this.checkRedGreenSwitch.UseVisualStyleBackColor = true;
            // 
            // checkReduceToolbarSize
            // 
            this.checkReduceToolbarSize.AutoSize = true;
            this.checkReduceToolbarSize.Location = new System.Drawing.Point(13, 20);
            this.checkReduceToolbarSize.Name = "checkReduceToolbarSize";
            this.checkReduceToolbarSize.Size = new System.Drawing.Size(129, 16);
            this.checkReduceToolbarSize.TabIndex = 0;
            this.checkReduceToolbarSize.Text = "Reduce Toolbar Size";
            this.checkReduceToolbarSize.UseVisualStyleBackColor = true;
            this.checkReduceToolbarSize.CheckedChanged += new System.EventHandler(this.checkReduceToolbarSize_CheckedChanged);
            // 
            // groupFileAssociations
            // 
            this.groupFileAssociations.Controls.Add(this.buttonAssociate);
            this.groupFileAssociations.Controls.Add(this.checkNC);
            this.groupFileAssociations.Controls.Add(this.checkGCO);
            this.groupFileAssociations.Controls.Add(this.checkG);
            this.groupFileAssociations.Controls.Add(this.checkGCode);
            this.groupFileAssociations.Controls.Add(this.checkOBJ);
            this.groupFileAssociations.Controls.Add(this.checkSTL);
            this.groupFileAssociations.Location = new System.Drawing.Point(13, 316);
            this.groupFileAssociations.Name = "groupFileAssociations";
            this.groupFileAssociations.Size = new System.Drawing.Size(518, 69);
            this.groupFileAssociations.TabIndex = 4;
            this.groupFileAssociations.TabStop = false;
            this.groupFileAssociations.Text = "File Associations";
            // 
            // buttonAssociate
            // 
            this.buttonAssociate.Location = new System.Drawing.Point(372, 20);
            this.buttonAssociate.Name = "buttonAssociate";
            this.buttonAssociate.Size = new System.Drawing.Size(140, 23);
            this.buttonAssociate.TabIndex = 1;
            this.buttonAssociate.Text = "Associate Extensions";
            this.buttonAssociate.UseVisualStyleBackColor = true;
            this.buttonAssociate.Click += new System.EventHandler(this.buttonAssociate_Click);
            // 
            // checkNC
            // 
            this.checkNC.AutoSize = true;
            this.checkNC.Location = new System.Drawing.Point(159, 43);
            this.checkNC.Name = "checkNC";
            this.checkNC.Size = new System.Drawing.Size(38, 16);
            this.checkNC.TabIndex = 0;
            this.checkNC.Text = ".nc";
            this.checkNC.UseVisualStyleBackColor = true;
            // 
            // checkGCO
            // 
            this.checkGCO.AutoSize = true;
            this.checkGCO.Checked = true;
            this.checkGCO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGCO.Location = new System.Drawing.Point(80, 43);
            this.checkGCO.Name = "checkGCO";
            this.checkGCO.Size = new System.Drawing.Size(44, 16);
            this.checkGCO.TabIndex = 0;
            this.checkGCO.Text = ".gco";
            this.checkGCO.UseVisualStyleBackColor = true;
            // 
            // checkG
            // 
            this.checkG.AutoSize = true;
            this.checkG.Checked = true;
            this.checkG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkG.Location = new System.Drawing.Point(159, 20);
            this.checkG.Name = "checkG";
            this.checkG.Size = new System.Drawing.Size(32, 16);
            this.checkG.TabIndex = 0;
            this.checkG.Text = ".g";
            this.checkG.UseVisualStyleBackColor = true;
            // 
            // checkGCode
            // 
            this.checkGCode.AutoSize = true;
            this.checkGCode.Checked = true;
            this.checkGCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGCode.Location = new System.Drawing.Point(80, 20);
            this.checkGCode.Name = "checkGCode";
            this.checkGCode.Size = new System.Drawing.Size(56, 16);
            this.checkGCode.TabIndex = 0;
            this.checkGCode.Text = ".gcode";
            this.checkGCode.UseVisualStyleBackColor = true;
            // 
            // checkOBJ
            // 
            this.checkOBJ.AutoSize = true;
            this.checkOBJ.Checked = true;
            this.checkOBJ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOBJ.Location = new System.Drawing.Point(13, 43);
            this.checkOBJ.Name = "checkOBJ";
            this.checkOBJ.Size = new System.Drawing.Size(41, 16);
            this.checkOBJ.TabIndex = 0;
            this.checkOBJ.Text = ".obj";
            this.checkOBJ.UseVisualStyleBackColor = true;
            // 
            // checkSTL
            // 
            this.checkSTL.AutoSize = true;
            this.checkSTL.Checked = true;
            this.checkSTL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSTL.Location = new System.Drawing.Point(13, 20);
            this.checkSTL.Name = "checkSTL";
            this.checkSTL.Size = new System.Drawing.Size(39, 16);
            this.checkSTL.TabIndex = 0;
            this.checkSTL.Text = ".stl";
            this.checkSTL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.watchTempRangeNumericUpDown);
            this.groupBox1.Controls.Add(this.watchSecondNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(13, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thermistor Failure Safe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "WatchTemperature Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Watch Second";
            // 
            // watchTempRangeNumericUpDown
            // 
            this.watchTempRangeNumericUpDown.DecimalPlaces = 2;
            this.watchTempRangeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.watchTempRangeNumericUpDown.Location = new System.Drawing.Point(209, 43);
            this.watchTempRangeNumericUpDown.Name = "watchTempRangeNumericUpDown";
            this.watchTempRangeNumericUpDown.Size = new System.Drawing.Size(60, 19);
            this.watchTempRangeNumericUpDown.TabIndex = 10;
            // 
            // watchSecondNumericUpDown
            // 
            this.watchSecondNumericUpDown.Location = new System.Drawing.Point(209, 18);
            this.watchSecondNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.watchSecondNumericUpDown.Name = "watchSecondNumericUpDown";
            this.watchSecondNumericUpDown.Size = new System.Drawing.Size(60, 19);
            this.watchSecondNumericUpDown.TabIndex = 9;
            // 
            // GlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(544, 494);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupFileAssociations);
            this.Controls.Add(this.groupGUI);
            this.Controls.Add(this.groupBehaviour);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupFilesAndDirectories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalSettings";
            this.ShowInTaskbar = false;
            this.Text = "Repetier settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalSettings_FormClosing);
            this.groupFilesAndDirectories.ResumeLayout(false);
            this.groupFilesAndDirectories.PerformLayout();
            this.groupBehaviour.ResumeLayout(false);
            this.groupBehaviour.PerformLayout();
            this.groupGUI.ResumeLayout(false);
            this.groupGUI.PerformLayout();
            this.groupFileAssociations.ResumeLayout(false);
            this.groupFileAssociations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTempRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchSecondNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFilesAndDirectories;
        private System.Windows.Forms.Label labelInfoWorkdir;
        private System.Windows.Forms.CheckBox checkLogfile;
        private System.Windows.Forms.Button buttonSearchWorkdir;
        private System.Windows.Forms.TextBox textWorkdir;
        private System.Windows.Forms.Label labelWorkdir;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label labelOKMasg;
        private System.Windows.Forms.GroupBox groupBehaviour;
        private System.Windows.Forms.CheckBox checkDisableQualityReduction;
        private System.Windows.Forms.GroupBox groupGUI;
        private System.Windows.Forms.CheckBox checkReduceToolbarSize;
        private System.Windows.Forms.CheckBox checkRedGreenSwitch;
        private System.Windows.Forms.GroupBox groupFileAssociations;
        private System.Windows.Forms.Button buttonAssociate;
        private System.Windows.Forms.CheckBox checkNC;
        private System.Windows.Forms.CheckBox checkGCO;
        private System.Windows.Forms.CheckBox checkG;
        private System.Windows.Forms.CheckBox checkGCode;
        private System.Windows.Forms.CheckBox checkOBJ;
        private System.Windows.Forms.CheckBox checkSTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown watchTempRangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown watchSecondNumericUpDown;

    }
}