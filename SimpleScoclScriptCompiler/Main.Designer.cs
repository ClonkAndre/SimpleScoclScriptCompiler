namespace SimpleScoclScriptCompiler
{
    partial class Main
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
            this.compileButton = new System.Windows.Forms.Button();
            this.browseSourceFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSourceFileTextBox = new System.Windows.Forms.TextBox();
            this.outputDirTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectOutputDirButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.DebugOutputFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.KeepTempFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.GlobalSegFlagCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compileButton.Location = new System.Drawing.Point(386, 296);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 25);
            this.compileButton.TabIndex = 0;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // browseSourceFileButton
            // 
            this.browseSourceFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseSourceFileButton.Location = new System.Drawing.Point(431, 25);
            this.browseSourceFileButton.Name = "browseSourceFileButton";
            this.browseSourceFileButton.Size = new System.Drawing.Size(32, 25);
            this.browseSourceFileButton.TabIndex = 1;
            this.browseSourceFileButton.Text = "...";
            this.browseSourceFileButton.UseVisualStyleBackColor = true;
            this.browseSourceFileButton.Click += new System.EventHandler(this.browseSourceFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input C Source File";
            // 
            // inputSourceFileTextBox
            // 
            this.inputSourceFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSourceFileTextBox.Location = new System.Drawing.Point(15, 27);
            this.inputSourceFileTextBox.Name = "inputSourceFileTextBox";
            this.inputSourceFileTextBox.Size = new System.Drawing.Size(410, 20);
            this.inputSourceFileTextBox.TabIndex = 3;
            // 
            // outputDirTextBox
            // 
            this.outputDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirTextBox.Location = new System.Drawing.Point(15, 72);
            this.outputDirTextBox.Name = "outputDirTextBox";
            this.outputDirTextBox.Size = new System.Drawing.Size(410, 20);
            this.outputDirTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Sco Directory";
            // 
            // selectOutputDirButton
            // 
            this.selectOutputDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOutputDirButton.Location = new System.Drawing.Point(431, 70);
            this.selectOutputDirButton.Name = "selectOutputDirButton";
            this.selectOutputDirButton.Size = new System.Drawing.Size(32, 25);
            this.selectOutputDirButton.TabIndex = 4;
            this.selectOutputDirButton.Text = "...";
            this.selectOutputDirButton.UseVisualStyleBackColor = true;
            this.selectOutputDirButton.Click += new System.EventHandler(this.selectOutputDirButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 203);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(446, 87);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scocl Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.versionComboBox);
            this.groupBox1.Controls.Add(this.DebugOutputFlagCheckBox);
            this.groupBox1.Controls.Add(this.KeepTempFlagCheckBox);
            this.groupBox1.Controls.Add(this.GlobalSegFlagCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version:";
            // 
            // versionComboBox
            // 
            this.versionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionComboBox.FormattingEnabled = true;
            this.versionComboBox.Items.AddRange(new object[] {
            "GTAIV",
            "TLAD",
            "TBOGT"});
            this.versionComboBox.Location = new System.Drawing.Point(59, 19);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(227, 22);
            this.versionComboBox.TabIndex = 3;
            this.versionComboBox.Text = "GTAIV";
            // 
            // DebugOutputFlagCheckBox
            // 
            this.DebugOutputFlagCheckBox.AutoSize = true;
            this.DebugOutputFlagCheckBox.Location = new System.Drawing.Point(185, 48);
            this.DebugOutputFlagCheckBox.Name = "DebugOutputFlagCheckBox";
            this.DebugOutputFlagCheckBox.Size = new System.Drawing.Size(101, 18);
            this.DebugOutputFlagCheckBox.TabIndex = 2;
            this.DebugOutputFlagCheckBox.Text = "DEBUGOUTPUT";
            this.DebugOutputFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // KeepTempFlagCheckBox
            // 
            this.KeepTempFlagCheckBox.AutoSize = true;
            this.KeepTempFlagCheckBox.Location = new System.Drawing.Point(102, 48);
            this.KeepTempFlagCheckBox.Name = "KeepTempFlagCheckBox";
            this.KeepTempFlagCheckBox.Size = new System.Drawing.Size(77, 18);
            this.KeepTempFlagCheckBox.TabIndex = 1;
            this.KeepTempFlagCheckBox.Text = "KEEPTEMP";
            this.KeepTempFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // GlobalSegFlagCheckBox
            // 
            this.GlobalSegFlagCheckBox.AutoSize = true;
            this.GlobalSegFlagCheckBox.Location = new System.Drawing.Point(6, 48);
            this.GlobalSegFlagCheckBox.Name = "GlobalSegFlagCheckBox";
            this.GlobalSegFlagCheckBox.Size = new System.Drawing.Size(90, 18);
            this.GlobalSegFlagCheckBox.TabIndex = 0;
            this.GlobalSegFlagCheckBox.Text = "GLOBALSEG";
            this.GlobalSegFlagCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Version 1.0 by ItsClonkAndre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.outputDirTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectOutputDirButton);
            this.Controls.Add(this.inputSourceFileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseSourceFileButton);
            this.Controls.Add(this.compileButton);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Scocl Script Compiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.Button browseSourceFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSourceFileTextBox;
        private System.Windows.Forms.TextBox outputDirTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectOutputDirButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox versionComboBox;
        private System.Windows.Forms.CheckBox DebugOutputFlagCheckBox;
        private System.Windows.Forms.CheckBox KeepTempFlagCheckBox;
        private System.Windows.Forms.CheckBox GlobalSegFlagCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

