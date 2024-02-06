namespace sf_divider
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_sourceFolder = new System.Windows.Forms.TextBox();
            this.button_tbsf = new System.Windows.Forms.Button();
            this.dataGridView_files = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_outputFolder = new System.Windows.Forms.TextBox();
            this.button_tbof = new System.Windows.Forms.Button();
            this.comboBox_kindSelector = new System.Windows.Forms.ComboBox();
            this.textBox_fileNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dFileNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ndFileNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_output = new System.Windows.Forms.Button();
            this.button_addK = new System.Windows.Forms.Button();
            this.textBox_AddKName = new System.Windows.Forms.TextBox();
            this.comboBox_removeKSelector = new System.Windows.Forms.ComboBox();
            this.button_removeK = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.checkBox_move = new System.Windows.Forms.CheckBox();
            this.checkBox_copy = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_sourceFolder
            // 
            this.textBox_sourceFolder.Location = new System.Drawing.Point(105, 8);
            this.textBox_sourceFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sourceFolder.Name = "textBox_sourceFolder";
            this.textBox_sourceFolder.ReadOnly = true;
            this.textBox_sourceFolder.Size = new System.Drawing.Size(303, 22);
            this.textBox_sourceFolder.TabIndex = 1;
            // 
            // button_tbsf
            // 
            this.button_tbsf.Location = new System.Drawing.Point(415, 2);
            this.button_tbsf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tbsf.Name = "button_tbsf";
            this.button_tbsf.Size = new System.Drawing.Size(76, 32);
            this.button_tbsf.TabIndex = 2;
            this.button_tbsf.Text = "参照";
            this.button_tbsf.UseVisualStyleBackColor = true;
            this.button_tbsf.Click += new System.EventHandler(this.button_tbsf_Click);
            // 
            // dataGridView_files
            // 
            this.dataGridView_files.AllowUserToAddRows = false;
            this.dataGridView_files.AllowUserToDeleteRows = false;
            this.dataGridView_files.AllowUserToResizeRows = false;
            this.dataGridView_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_files.Location = new System.Drawing.Point(496, 142);
            this.dataGridView_files.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_files.MultiSelect = false;
            this.dataGridView_files.Name = "dataGridView_files";
            this.dataGridView_files.ReadOnly = true;
            this.dataGridView_files.RowHeadersWidth = 51;
            this.dataGridView_files.RowTemplate.Height = 24;
            this.dataGridView_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_files.Size = new System.Drawing.Size(397, 246);
            this.dataGridView_files.TabIndex = 3;
            this.dataGridView_files.SelectionChanged += new System.EventHandler(this.dataGridView_files_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "参照フォルダ";
            // 
            // button_next
            // 
            this.button_next.Enabled = false;
            this.button_next.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_next.Location = new System.Drawing.Point(416, 141);
            this.button_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 248);
            this.button_next.TabIndex = 5;
            this.button_next.Text = "▶";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_previous
            // 
            this.button_previous.Enabled = false;
            this.button_previous.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_previous.Location = new System.Drawing.Point(17, 142);
            this.button_previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 246);
            this.button_previous.TabIndex = 6;
            this.button_previous.Text = "◀";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ファイル数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "出力フォルダ";
            // 
            // textBox_outputFolder
            // 
            this.textBox_outputFolder.Location = new System.Drawing.Point(105, 44);
            this.textBox_outputFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_outputFolder.Name = "textBox_outputFolder";
            this.textBox_outputFolder.ReadOnly = true;
            this.textBox_outputFolder.Size = new System.Drawing.Size(303, 22);
            this.textBox_outputFolder.TabIndex = 11;
            // 
            // button_tbof
            // 
            this.button_tbof.Location = new System.Drawing.Point(415, 40);
            this.button_tbof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tbof.Name = "button_tbof";
            this.button_tbof.Size = new System.Drawing.Size(76, 31);
            this.button_tbof.TabIndex = 12;
            this.button_tbof.Text = "参照";
            this.button_tbof.UseVisualStyleBackColor = true;
            this.button_tbof.Click += new System.EventHandler(this.button_tbof_Click);
            // 
            // comboBox_kindSelector
            // 
            this.comboBox_kindSelector.Enabled = false;
            this.comboBox_kindSelector.FormattingEnabled = true;
            this.comboBox_kindSelector.Location = new System.Drawing.Point(17, 109);
            this.comboBox_kindSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_kindSelector.Name = "comboBox_kindSelector";
            this.comboBox_kindSelector.Size = new System.Drawing.Size(473, 23);
            this.comboBox_kindSelector.TabIndex = 13;
            this.comboBox_kindSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox_kindSelector_SelectedIndexChanged);
            // 
            // textBox_fileNumber
            // 
            this.textBox_fileNumber.Location = new System.Drawing.Point(105, 75);
            this.textBox_fileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_fileNumber.Name = "textBox_fileNumber";
            this.textBox_fileNumber.ReadOnly = true;
            this.textBox_fileNumber.Size = new System.Drawing.Size(87, 22);
            this.textBox_fileNumber.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "振分済：";
            // 
            // textBox_dFileNumber
            // 
            this.textBox_dFileNumber.Location = new System.Drawing.Point(267, 75);
            this.textBox_dFileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_dFileNumber.Name = "textBox_dFileNumber";
            this.textBox_dFileNumber.ReadOnly = true;
            this.textBox_dFileNumber.Size = new System.Drawing.Size(73, 22);
            this.textBox_dFileNumber.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "未振分：";
            // 
            // textBox_ndFileNumber
            // 
            this.textBox_ndFileNumber.Location = new System.Drawing.Point(415, 75);
            this.textBox_ndFileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ndFileNumber.Name = "textBox_ndFileNumber";
            this.textBox_ndFileNumber.ReadOnly = true;
            this.textBox_ndFileNumber.Size = new System.Drawing.Size(75, 22);
            this.textBox_ndFileNumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "種別";
            // 
            // button_output
            // 
            this.button_output.Enabled = false;
            this.button_output.Location = new System.Drawing.Point(496, 2);
            this.button_output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(313, 69);
            this.button_output.TabIndex = 23;
            this.button_output.Text = "振分実行";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_addK
            // 
            this.button_addK.Location = new System.Drawing.Point(819, 70);
            this.button_addK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addK.Name = "button_addK";
            this.button_addK.Size = new System.Drawing.Size(75, 32);
            this.button_addK.TabIndex = 24;
            this.button_addK.Text = "追加";
            this.button_addK.UseVisualStyleBackColor = true;
            this.button_addK.Click += new System.EventHandler(this.button_addK_Click);
            // 
            // textBox_AddKName
            // 
            this.textBox_AddKName.Location = new System.Drawing.Point(580, 75);
            this.textBox_AddKName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AddKName.Name = "textBox_AddKName";
            this.textBox_AddKName.Size = new System.Drawing.Size(232, 22);
            this.textBox_AddKName.TabIndex = 25;
            // 
            // comboBox_removeKSelector
            // 
            this.comboBox_removeKSelector.FormattingEnabled = true;
            this.comboBox_removeKSelector.Location = new System.Drawing.Point(580, 109);
            this.comboBox_removeKSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_removeKSelector.Name = "comboBox_removeKSelector";
            this.comboBox_removeKSelector.Size = new System.Drawing.Size(232, 23);
            this.comboBox_removeKSelector.TabIndex = 27;
            // 
            // button_removeK
            // 
            this.button_removeK.Location = new System.Drawing.Point(819, 104);
            this.button_removeK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_removeK.Name = "button_removeK";
            this.button_removeK.Size = new System.Drawing.Size(75, 32);
            this.button_removeK.TabIndex = 28;
            this.button_removeK.Text = "削除";
            this.button_removeK.UseVisualStyleBackColor = true;
            this.button_removeK.Click += new System.EventHandler(this.button_removeK_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(73, 114);
            this.axWindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(234, 197);
            this.axWindowsMediaPlayer.TabIndex = 15;
            // 
            // checkBox_move
            // 
            this.checkBox_move.AutoSize = true;
            this.checkBox_move.Checked = true;
            this.checkBox_move.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_move.Location = new System.Drawing.Point(819, 10);
            this.checkBox_move.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_move.Name = "checkBox_move";
            this.checkBox_move.Size = new System.Drawing.Size(59, 19);
            this.checkBox_move.TabIndex = 29;
            this.checkBox_move.Text = "移動";
            this.checkBox_move.UseVisualStyleBackColor = true;
            this.checkBox_move.CheckedChanged += new System.EventHandler(this.checkBox_move_CheckedChanged);
            // 
            // checkBox_copy
            // 
            this.checkBox_copy.AutoSize = true;
            this.checkBox_copy.Location = new System.Drawing.Point(819, 46);
            this.checkBox_copy.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_copy.Name = "checkBox_copy";
            this.checkBox_copy.Size = new System.Drawing.Size(62, 19);
            this.checkBox_copy.TabIndex = 30;
            this.checkBox_copy.Text = "コピー";
            this.checkBox_copy.UseVisualStyleBackColor = true;
            this.checkBox_copy.CheckedChanged += new System.EventHandler(this.checkBox_copy_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 405);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(909, 26);
            this.statusStrip.TabIndex = 31;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(133, 18);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(188, 20);
            this.toolStripStatusLabel.Text = "参照フォルダを設定してください";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 431);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkBox_copy);
            this.Controls.Add(this.checkBox_move);
            this.Controls.Add(this.button_removeK);
            this.Controls.Add(this.comboBox_removeKSelector);
            this.Controls.Add(this.textBox_AddKName);
            this.Controls.Add(this.button_addK);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ndFileNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_dFileNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_fileNumber);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.comboBox_kindSelector);
            this.Controls.Add(this.button_tbof);
            this.Controls.Add(this.textBox_outputFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_files);
            this.Controls.Add(this.button_tbsf);
            this.Controls.Add(this.textBox_sourceFolder);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(927, 478);
            this.MinimumSize = new System.Drawing.Size(927, 478);
            this.Name = "Form1";
            this.Text = "SF Divider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_sourceFolder;
        private System.Windows.Forms.Button button_tbsf;
        private System.Windows.Forms.DataGridView dataGridView_files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_outputFolder;
        private System.Windows.Forms.Button button_tbof;
        private System.Windows.Forms.ComboBox comboBox_kindSelector;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.TextBox textBox_fileNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dFileNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ndFileNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_addK;
        private System.Windows.Forms.TextBox textBox_AddKName;
        private System.Windows.Forms.ComboBox comboBox_removeKSelector;
        private System.Windows.Forms.Button button_removeK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox_move;
        private System.Windows.Forms.CheckBox checkBox_copy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

