namespace Playfair_Cipher
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxParsedInput = new System.Windows.Forms.RichTextBox();
            this.dataGridPlaceholder = new System.Windows.Forms.DataGridView();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.richTextBoxDoubles = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelResizer = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.tabExperimental = new System.Windows.Forms.TabPage();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.toolTipInfoPicture = new System.Windows.Forms.ToolTip(this.components);
            this.experimentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaceholder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPassword.Location = new System.Drawing.Point(9, 10);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.MaxLength = 46;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(148, 26);
            this.textBoxPassword.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxPassword, "Enter your password key.");
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPassword.ForeColor = System.Drawing.Color.Salmon;
            this.checkBoxPassword.Location = new System.Drawing.Point(16, 51);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(132, 24);
            this.checkBoxPassword.TabIndex = 0;
            this.checkBoxPassword.TabStop = false;
            this.checkBoxPassword.Text = "Hide Password";
            this.toolTip.SetToolTip(this.checkBoxPassword, "Hides the password and the table.");
            this.checkBoxPassword.UseVisualStyleBackColor = false;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonEncrypt.Location = new System.Drawing.Point(9, 89);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(150, 54);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "&ENCRYPT";
            this.toolTip.SetToolTip(this.buttonEncrypt, "Encrypts the input.");
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(722, 237);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(339, 263);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.TabStop = false;
            this.richTextBoxOutput.Text = "OUTPUT";
            this.toolTip.SetToolTip(this.richTextBoxOutput, "Shows output.");
            // 
            // richTextBoxParsedInput
            // 
            this.richTextBoxParsedInput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxParsedInput.Location = new System.Drawing.Point(7, 237);
            this.richTextBoxParsedInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxParsedInput.Name = "richTextBoxParsedInput";
            this.richTextBoxParsedInput.ReadOnly = true;
            this.richTextBoxParsedInput.Size = new System.Drawing.Size(330, 263);
            this.richTextBoxParsedInput.TabIndex = 0;
            this.richTextBoxParsedInput.TabStop = false;
            this.richTextBoxParsedInput.Text = "PARSED INPUT";
            this.toolTip.SetToolTip(this.richTextBoxParsedInput, "Shows parsed input.");
            // 
            // dataGridPlaceholder
            // 
            this.dataGridPlaceholder.AllowUserToAddRows = false;
            this.dataGridPlaceholder.AllowUserToDeleteRows = false;
            this.dataGridPlaceholder.AllowUserToResizeColumns = false;
            this.dataGridPlaceholder.AllowUserToResizeRows = false;
            this.dataGridPlaceholder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPlaceholder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPlaceholder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlaceholder.ColumnHeadersVisible = false;
            this.dataGridPlaceholder.Location = new System.Drawing.Point(694, 7);
            this.dataGridPlaceholder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPlaceholder.MultiSelect = false;
            this.dataGridPlaceholder.Name = "dataGridPlaceholder";
            this.dataGridPlaceholder.ReadOnly = true;
            this.dataGridPlaceholder.RowHeadersVisible = false;
            this.dataGridPlaceholder.RowHeadersWidth = 62;
            this.dataGridPlaceholder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridPlaceholder.ShowEditingIcon = false;
            this.dataGridPlaceholder.Size = new System.Drawing.Size(370, 203);
            this.dataGridPlaceholder.TabIndex = 0;
            this.dataGridPlaceholder.TabStop = false;
            this.toolTip.SetToolTip(this.dataGridPlaceholder, "The table is hidden. Uncheck \"Hide Password\".");
            this.dataGridPlaceholder.Visible = false;
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.AllowUserToResizeColumns = false;
            this.dataGridTable.AllowUserToResizeRows = false;
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTable.Location = new System.Drawing.Point(694, 7);
            this.dataGridTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridTable.MultiSelect = false;
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            this.dataGridTable.RowHeadersVisible = false;
            this.dataGridTable.RowHeadersWidth = 62;
            this.dataGridTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridTable.ShowEditingIcon = false;
            this.dataGridTable.Size = new System.Drawing.Size(370, 203);
            this.dataGridTable.TabIndex = 0;
            this.dataGridTable.TabStop = false;
            this.toolTip.SetToolTip(this.dataGridTable, "Encryption table.");
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(168, 44);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(443, 165);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "INPUT";
            this.toolTip.SetToolTip(this.richTextBoxInput, "Please enter your input for encryption or decryption.");
            this.richTextBoxInput.Enter += new System.EventHandler(this.RichTextBoxInput_Enter);
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCreateTable.ForeColor = System.Drawing.Color.Salmon;
            this.buttonCreateTable.Location = new System.Drawing.Point(620, 6);
            this.buttonCreateTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(67, 204);
            this.buttonCreateTable.TabIndex = 1;
            this.buttonCreateTable.Text = "&CREATE TABLE";
            this.toolTip.SetToolTip(this.buttonCreateTable, "Creates the encryption table.");
            this.buttonCreateTable.UseVisualStyleBackColor = false;
            this.buttonCreateTable.Click += new System.EventHandler(this.ButtonCreateTable_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonDecrypt.Location = new System.Drawing.Point(9, 155);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(150, 54);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "&DECRYPT";
            this.toolTip.SetToolTip(this.buttonDecrypt, "Decrypts the input.");
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // richTextBoxDoubles
            // 
            this.richTextBoxDoubles.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDoubles.Location = new System.Drawing.Point(365, 237);
            this.richTextBoxDoubles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDoubles.Name = "richTextBoxDoubles";
            this.richTextBoxDoubles.ReadOnly = true;
            this.richTextBoxDoubles.Size = new System.Drawing.Size(330, 263);
            this.richTextBoxDoubles.TabIndex = 0;
            this.richTextBoxDoubles.TabStop = false;
            this.richTextBoxDoubles.Text = "BIGRAM";
            this.toolTip.SetToolTip(this.richTextBoxDoubles, "Shows bigrams and added \"X\" or \"Q\" characters for encryption.\r\n\r\nShows decrypted " +
        "text before character parsing for decryption.");
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Salmon;
            this.buttonExit.Location = new System.Drawing.Point(972, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "EXIT";
            this.toolTip.SetToolTip(this.buttonExit, "Exits the application.");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Salmon;
            this.buttonReset.Location = new System.Drawing.Point(835, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 40);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.TabStop = false;
            this.buttonReset.Text = "RESET";
            this.toolTip.SetToolTip(this.buttonReset, "Resets the application.");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelResizer
            // 
            this.labelResizer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResizer.AutoSize = true;
            this.labelResizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResizer.Location = new System.Drawing.Point(48, -111);
            this.labelResizer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResizer.MaximumSize = new System.Drawing.Size(1164, 40);
            this.labelResizer.MinimumSize = new System.Drawing.Size(150, 40);
            this.labelResizer.Name = "labelResizer";
            this.labelResizer.Size = new System.Drawing.Size(150, 40);
            this.labelResizer.TabIndex = 0;
            this.labelResizer.Text = "labelResizer";
            this.labelResizer.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDefault);
            this.tabControl.Controls.Add(this.tabExperimental);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(25, 37);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1079, 537);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabDefault
            // 
            this.tabDefault.BackgroundImage = global::Playfair_Cipher.Properties.Resources.playfaircipher_background;
            this.tabDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDefault.Controls.Add(this.labelEnterPassword);
            this.tabDefault.Controls.Add(this.buttonEncrypt);
            this.tabDefault.Controls.Add(this.dataGridPlaceholder);
            this.tabDefault.Controls.Add(this.labelResizer);
            this.tabDefault.Controls.Add(this.buttonDecrypt);
            this.tabDefault.Controls.Add(this.richTextBoxOutput);
            this.tabDefault.Controls.Add(this.textBoxPassword);
            this.tabDefault.Controls.Add(this.buttonCreateTable);
            this.tabDefault.Controls.Add(this.richTextBoxDoubles);
            this.tabDefault.Controls.Add(this.richTextBoxParsedInput);
            this.tabDefault.Controls.Add(this.richTextBoxInput);
            this.tabDefault.Controls.Add(this.checkBoxPassword);
            this.tabDefault.Controls.Add(this.dataGridTable);
            this.tabDefault.Location = new System.Drawing.Point(4, 25);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefault.Size = new System.Drawing.Size(1071, 508);
            this.tabDefault.TabIndex = 0;
            this.tabDefault.Text = "Default";
            this.tabDefault.ToolTipText = "Provides the default functionality.";
            this.tabDefault.UseVisualStyleBackColor = true;
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.AutoSize = true;
            this.labelEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelEnterPassword.ForeColor = System.Drawing.Color.Salmon;
            this.labelEnterPassword.Location = new System.Drawing.Point(185, 10);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(395, 24);
            this.labelEnterPassword.TabIndex = 0;
            this.labelEnterPassword.Text = "<--- PLEASE, ENTER YOUR PASSWORD";
            // 
            // tabExperimental
            // 
            this.tabExperimental.Location = new System.Drawing.Point(4, 25);
            this.tabExperimental.Name = "tabExperimental";
            this.tabExperimental.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperimental.Size = new System.Drawing.Size(1071, 508);
            this.tabExperimental.TabIndex = 1;
            this.tabExperimental.Text = "Experimental";
            this.tabExperimental.ToolTipText = resources.GetString("tabExperimental.ToolTipText");
            this.tabExperimental.UseVisualStyleBackColor = true;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.BackgroundImage = global::Playfair_Cipher.Properties.Resources.info;
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInfo.InitialImage = global::Playfair_Cipher.Properties.Resources.info;
            this.pictureBoxInfo.Location = new System.Drawing.Point(779, 5);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxInfo.TabIndex = 6;
            this.pictureBoxInfo.TabStop = false;
            this.toolTipInfoPicture.SetToolTip(this.pictureBoxInfo, resources.GetString("pictureBoxInfo.ToolTip"));
            // 
            // toolTipInfoPicture
            // 
            this.toolTipInfoPicture.AutoPopDelay = 600000;
            this.toolTipInfoPicture.InitialDelay = 500;
            this.toolTipInfoPicture.IsBalloon = true;
            this.toolTipInfoPicture.ReshowDelay = 100;
            this.toolTipInfoPicture.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfoPicture.ToolTipTitle = "Info";
            // 
            // experimentalBindingSource
            // 
            this.experimentalBindingSource.DataSource = typeof(Playfair_Cipher.Table);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Playfair Cipher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaceholder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabDefault.ResumeLayout(false);
            this.tabDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource experimentalBindingSource;
        private System.Windows.Forms.Label labelResizer;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.RichTextBox richTextBoxParsedInput;
        private System.Windows.Forms.DataGridView dataGridPlaceholder;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDefault;
        private System.Windows.Forms.TabPage tabExperimental;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RichTextBox richTextBoxDoubles;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.ToolTip toolTipInfoPicture;
        private System.Windows.Forms.Label labelEnterPassword;
    }
}

