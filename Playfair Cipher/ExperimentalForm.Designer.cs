namespace Playfair_Cipher
{
    partial class ExperimentalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonRandomKey = new System.Windows.Forms.Button();
            this.textBoxPasswordExperimental = new System.Windows.Forms.TextBox();
            this.checkBoxPasswordExperimental = new System.Windows.Forms.CheckBox();
            this.dataGridExperimental = new System.Windows.Forms.DataGridView();
            this.row1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridPlaceholderExperimental = new System.Windows.Forms.DataGridView();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMiddleStep = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonSlowmoEncrypt = new System.Windows.Forms.Button();
            this.buttonSlowmoDecrypt = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.trackBarSlowmo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExperimental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaceholderExperimental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlowmo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRandomKey
            // 
            this.buttonRandomKey.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRandomKey.Enabled = false;
            this.buttonRandomKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandomKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomKey.ForeColor = System.Drawing.Color.Salmon;
            this.buttonRandomKey.Location = new System.Drawing.Point(6, 178);
            this.buttonRandomKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRandomKey.Name = "buttonRandomKey";
            this.buttonRandomKey.Size = new System.Drawing.Size(225, 83);
            this.buttonRandomKey.TabIndex = 1;
            this.buttonRandomKey.Text = "RANDOM PASSWORD";
            this.toolTip.SetToolTip(this.buttonRandomKey, "Generates random password.");
            this.buttonRandomKey.UseVisualStyleBackColor = false;
            this.buttonRandomKey.Click += new System.EventHandler(this.ButtonRandomKey_Click);
            // 
            // textBoxPasswordExperimental
            // 
            this.textBoxPasswordExperimental.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPasswordExperimental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordExperimental.Location = new System.Drawing.Point(8, 11);
            this.textBoxPasswordExperimental.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordExperimental.MaxLength = 60;
            this.textBoxPasswordExperimental.Name = "textBoxPasswordExperimental";
            this.textBoxPasswordExperimental.Size = new System.Drawing.Size(454, 26);
            this.textBoxPasswordExperimental.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxPasswordExperimental, "Enter your password key.");
            this.textBoxPasswordExperimental.TextChanged += new System.EventHandler(this.TextBoxPasswordExperimental_TextChanged);
            this.textBoxPasswordExperimental.Enter += new System.EventHandler(this.TextBoxPasswordExperimental_Enter);
            // 
            // checkBoxPasswordExperimental
            // 
            this.checkBoxPasswordExperimental.AutoSize = true;
            this.checkBoxPasswordExperimental.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPasswordExperimental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxPasswordExperimental.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPasswordExperimental.ForeColor = System.Drawing.Color.Salmon;
            this.checkBoxPasswordExperimental.Location = new System.Drawing.Point(21, 94);
            this.checkBoxPasswordExperimental.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPasswordExperimental.Name = "checkBoxPasswordExperimental";
            this.checkBoxPasswordExperimental.Size = new System.Drawing.Size(194, 33);
            this.checkBoxPasswordExperimental.TabIndex = 0;
            this.checkBoxPasswordExperimental.TabStop = false;
            this.checkBoxPasswordExperimental.Text = "Hide Password";
            this.toolTip.SetToolTip(this.checkBoxPasswordExperimental, "Hides the password and the table.");
            this.checkBoxPasswordExperimental.UseVisualStyleBackColor = false;
            this.checkBoxPasswordExperimental.CheckedChanged += new System.EventHandler(this.CheckBoxPasswordExperimental_CheckedChanged);
            // 
            // dataGridExperimental
            // 
            this.dataGridExperimental.AllowUserToAddRows = false;
            this.dataGridExperimental.AllowUserToDeleteRows = false;
            this.dataGridExperimental.AllowUserToResizeColumns = false;
            this.dataGridExperimental.AllowUserToResizeRows = false;
            this.dataGridExperimental.AutoGenerateColumns = false;
            this.dataGridExperimental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExperimental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridExperimental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridExperimental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExperimental.ColumnHeadersVisible = false;
            this.dataGridExperimental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row1DataGridViewTextBoxColumn,
            this.row2DataGridViewTextBoxColumn,
            this.row3DataGridViewTextBoxColumn,
            this.row4DataGridViewTextBoxColumn,
            this.row5DataGridViewTextBoxColumn});
            this.dataGridExperimental.DataSource = this.tableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridExperimental.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridExperimental.Location = new System.Drawing.Point(699, 8);
            this.dataGridExperimental.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridExperimental.MultiSelect = false;
            this.dataGridExperimental.Name = "dataGridExperimental";
            this.dataGridExperimental.RowHeadersVisible = false;
            this.dataGridExperimental.RowHeadersWidth = 62;
            this.dataGridExperimental.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridExperimental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridExperimental.ShowEditingIcon = false;
            this.dataGridExperimental.Size = new System.Drawing.Size(368, 254);
            this.dataGridExperimental.TabIndex = 4;
            this.dataGridExperimental.TabStop = false;
            this.dataGridExperimental.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridExperimental_CellBeginEdit);
            this.dataGridExperimental.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridExperimental_CellEndEdit);
            this.dataGridExperimental.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridExperimental_DataError);
            // 
            // row1DataGridViewTextBoxColumn
            // 
            this.row1DataGridViewTextBoxColumn.DataPropertyName = "row1";
            this.row1DataGridViewTextBoxColumn.HeaderText = "row1";
            this.row1DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.row1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.row1DataGridViewTextBoxColumn.Name = "row1DataGridViewTextBoxColumn";
            // 
            // row2DataGridViewTextBoxColumn
            // 
            this.row2DataGridViewTextBoxColumn.DataPropertyName = "row2";
            this.row2DataGridViewTextBoxColumn.HeaderText = "row2";
            this.row2DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.row2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.row2DataGridViewTextBoxColumn.Name = "row2DataGridViewTextBoxColumn";
            // 
            // row3DataGridViewTextBoxColumn
            // 
            this.row3DataGridViewTextBoxColumn.DataPropertyName = "row3";
            this.row3DataGridViewTextBoxColumn.HeaderText = "row3";
            this.row3DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.row3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.row3DataGridViewTextBoxColumn.Name = "row3DataGridViewTextBoxColumn";
            // 
            // row4DataGridViewTextBoxColumn
            // 
            this.row4DataGridViewTextBoxColumn.DataPropertyName = "row4";
            this.row4DataGridViewTextBoxColumn.HeaderText = "row4";
            this.row4DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.row4DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.row4DataGridViewTextBoxColumn.Name = "row4DataGridViewTextBoxColumn";
            // 
            // row5DataGridViewTextBoxColumn
            // 
            this.row5DataGridViewTextBoxColumn.DataPropertyName = "row5";
            this.row5DataGridViewTextBoxColumn.HeaderText = "row5";
            this.row5DataGridViewTextBoxColumn.MaxInputLength = 1;
            this.row5DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.row5DataGridViewTextBoxColumn.Name = "row5DataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(Playfair_Cipher.Table);
            // 
            // dataGridPlaceholderExperimental
            // 
            this.dataGridPlaceholderExperimental.AllowUserToAddRows = false;
            this.dataGridPlaceholderExperimental.AllowUserToDeleteRows = false;
            this.dataGridPlaceholderExperimental.AllowUserToResizeColumns = false;
            this.dataGridPlaceholderExperimental.AllowUserToResizeRows = false;
            this.dataGridPlaceholderExperimental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPlaceholderExperimental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPlaceholderExperimental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlaceholderExperimental.ColumnHeadersVisible = false;
            this.dataGridPlaceholderExperimental.Location = new System.Drawing.Point(699, 8);
            this.dataGridPlaceholderExperimental.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridPlaceholderExperimental.MultiSelect = false;
            this.dataGridPlaceholderExperimental.Name = "dataGridPlaceholderExperimental";
            this.dataGridPlaceholderExperimental.ReadOnly = true;
            this.dataGridPlaceholderExperimental.RowHeadersVisible = false;
            this.dataGridPlaceholderExperimental.RowHeadersWidth = 62;
            this.dataGridPlaceholderExperimental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridPlaceholderExperimental.ShowEditingIcon = false;
            this.dataGridPlaceholderExperimental.Size = new System.Drawing.Size(368, 254);
            this.dataGridPlaceholderExperimental.TabIndex = 0;
            this.dataGridPlaceholderExperimental.TabStop = false;
            this.dataGridPlaceholderExperimental.Visible = false;
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(9, 294);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(343, 330);
            this.richTextBoxInput.TabIndex = 6;
            this.richTextBoxInput.Text = "INPUT";
            this.toolTip.SetToolTip(this.richTextBoxInput, "Please enter your input for encryption or decryption.");
            this.richTextBoxInput.Enter += new System.EventHandler(this.RichTextBoxInput_Enter);
            // 
            // richTextBoxMiddleStep
            // 
            this.richTextBoxMiddleStep.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMiddleStep.Location = new System.Drawing.Point(363, 294);
            this.richTextBoxMiddleStep.Name = "richTextBoxMiddleStep";
            this.richTextBoxMiddleStep.ReadOnly = true;
            this.richTextBoxMiddleStep.Size = new System.Drawing.Size(343, 330);
            this.richTextBoxMiddleStep.TabIndex = 0;
            this.richTextBoxMiddleStep.TabStop = false;
            this.richTextBoxMiddleStep.Text = "MIDDLE STEP";
            this.toolTip.SetToolTip(this.richTextBoxMiddleStep, "Shows middle step.");
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(718, 294);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(343, 330);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.TabStop = false;
            this.richTextBoxOutput.Text = "OUTPUT";
            this.toolTip.SetToolTip(this.richTextBoxOutput, "Shows output.");
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonEncrypt.Location = new System.Drawing.Point(238, 85);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(225, 83);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "ENCRYPT";
            this.toolTip.SetToolTip(this.buttonEncrypt, "Encrypts the input.");
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonDecrypt.Location = new System.Drawing.Point(238, 178);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(225, 83);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "DECRYPT";
            this.toolTip.SetToolTip(this.buttonDecrypt, "Decrypts the input.");
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // buttonSlowmoEncrypt
            // 
            this.buttonSlowmoEncrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSlowmoEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlowmoEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlowmoEncrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonSlowmoEncrypt.Location = new System.Drawing.Point(471, 85);
            this.buttonSlowmoEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSlowmoEncrypt.Name = "buttonSlowmoEncrypt";
            this.buttonSlowmoEncrypt.Size = new System.Drawing.Size(225, 83);
            this.buttonSlowmoEncrypt.TabIndex = 4;
            this.buttonSlowmoEncrypt.Text = "SLOWMO ENCRYPT";
            this.toolTip.SetToolTip(this.buttonSlowmoEncrypt, "Encrypts the input in slow motion with colour demonstration.");
            this.buttonSlowmoEncrypt.UseVisualStyleBackColor = false;
            this.buttonSlowmoEncrypt.Click += new System.EventHandler(this.SlowmoEncrypt);
            // 
            // buttonSlowmoDecrypt
            // 
            this.buttonSlowmoDecrypt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSlowmoDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSlowmoDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSlowmoDecrypt.ForeColor = System.Drawing.Color.Salmon;
            this.buttonSlowmoDecrypt.Location = new System.Drawing.Point(471, 178);
            this.buttonSlowmoDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSlowmoDecrypt.Name = "buttonSlowmoDecrypt";
            this.buttonSlowmoDecrypt.Size = new System.Drawing.Size(225, 83);
            this.buttonSlowmoDecrypt.TabIndex = 5;
            this.buttonSlowmoDecrypt.Text = "SLOWMO DECRYPT";
            this.toolTip.SetToolTip(this.buttonSlowmoDecrypt, "Decrypts the input in slow motion with colour demonstration.");
            this.buttonSlowmoDecrypt.UseVisualStyleBackColor = false;
            this.buttonSlowmoDecrypt.Click += new System.EventHandler(this.SlowmoDecrypt);
            // 
            // trackBarSlowmo
            // 
            this.trackBarSlowmo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarSlowmo.LargeChange = 500;
            this.trackBarSlowmo.Location = new System.Drawing.Point(471, 9);
            this.trackBarSlowmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarSlowmo.Maximum = 3000;
            this.trackBarSlowmo.Minimum = 200;
            this.trackBarSlowmo.Name = "trackBarSlowmo";
            this.trackBarSlowmo.Size = new System.Drawing.Size(225, 45);
            this.trackBarSlowmo.SmallChange = 100;
            this.trackBarSlowmo.TabIndex = 0;
            this.trackBarSlowmo.TabStop = false;
            this.trackBarSlowmo.TickFrequency = 100;
            this.trackBarSlowmo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTip.SetToolTip(this.trackBarSlowmo, "Sets the slow motion speed.");
            this.trackBarSlowmo.Value = 1000;
            this.trackBarSlowmo.Scroll += new System.EventHandler(this.TrackBarSlowmo_Scroll);
            // 
            // ExperimentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Playfair_Cipher.Properties.Resources.playfaircipher_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 658);
            this.Controls.Add(this.trackBarSlowmo);
            this.Controls.Add(this.buttonSlowmoDecrypt);
            this.Controls.Add(this.buttonSlowmoEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxMiddleStep);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonRandomKey);
            this.Controls.Add(this.textBoxPasswordExperimental);
            this.Controls.Add(this.checkBoxPasswordExperimental);
            this.Controls.Add(this.dataGridExperimental);
            this.Controls.Add(this.dataGridPlaceholderExperimental);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExperimentalForm";
            this.Text = "ExperimentalForm";
            this.Load += new System.EventHandler(this.ExperimentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExperimental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaceholderExperimental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlowmo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRandomKey;
        private System.Windows.Forms.TextBox textBoxPasswordExperimental;
        private System.Windows.Forms.CheckBox checkBoxPasswordExperimental;
        private System.Windows.Forms.DataGridView dataGridExperimental;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridView dataGridPlaceholderExperimental;
        private System.Windows.Forms.DataGridViewTextBoxColumn row1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn row2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn row3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn row4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn row5DataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxMiddleStep;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonSlowmoEncrypt;
        private System.Windows.Forms.Button buttonSlowmoDecrypt;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TrackBar trackBarSlowmo;
    }
}