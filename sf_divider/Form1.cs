using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sf_divider
{
    public partial class Form1 : Form
    {
        private bool isSystem = true;
        private bool isSFSelected = false;
        private bool isOFSelected = false;
        private List<string> fileList = new List<string>();
        private BindingList<string> kindList = new BindingList<string>() { "未選択" };
        private DataTable dividedList = new DataTable("dividedList");

        private int fileNumber = 0;
        private int dividedNumber = 0;
        private int nonDividedNumber = 0;
        private int selectedIndex = 0;

        private class NaturalSortComparer : IComparer<string>
        {
            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
            public static extern int StrCmpLogicalW(string str1, string str2);

            public int Compare(string object1, string object2)
            {
                return StrCmpLogicalW((string)object1, (string)object2);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox_move.Checked = true;
            checkBox_copy.Checked = false;

            dividedList.Columns.Add("name");
            dividedList.Columns.Add("kind");

            comboBox_kindSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_removeKSelector.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_kindSelector.DataSource = kindList;
            comboBox_removeKSelector.DataSource = kindList;

            comboBox_removeKSelector.BindingContext = new BindingContext();
        }

        private void reeset_All()
        {
            fileList = new List<string>();
            dividedList = new DataTable("dividedList");
            fileNumber = 0;
            dividedNumber = 0;
            nonDividedNumber = 0;
            selectedIndex = 0;
            dividedList.Columns.Add("name");
            dividedList.Columns.Add("kind");
        }

        private void button_tbsf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "参照フォルダを選択してください";
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel.Text = "ファイル群の解析開始";
                reeset_All();
                toolStripProgressBar.Value = 0;
                textBox_sourceFolder.Text = folderBrowserDialog.SelectedPath.ToString();
                fileList = new List<string>(System.IO.Directory.GetFiles(textBox_sourceFolder.Text, "*.wav"));
                fileList.Sort(new NaturalSortComparer());
                fileNumber = fileList.Count;

                toolStripProgressBar.Maximum = fileNumber + 1;

                textBox_fileNumber.Text = fileNumber.ToString();
                nonDividedNumber = fileList.Count;
                textBox_ndFileNumber.Text = nonDividedNumber.ToString();
                textBox_dFileNumber.Text = dividedNumber.ToString();
                foreach (string file_path in fileList)
                {
                    dividedList.Rows.Add(file_path.Substring(file_path.LastIndexOf("\\") + 1), kindList[0]);
                    toolStripProgressBar.Value = toolStripProgressBar.Value + 1;
                }

                isSystem = true;
                dataGridView_files.DataSource = dividedList;
                isSystem = false;

                toolStripProgressBar.Value = toolStripProgressBar.Value + 1;
                toolStripStatusLabel.Text = "完了";

                isSFSelected = true;
                if (isOFSelected)
                {
                    button_output.Enabled = true;
                }

                if (fileList.Count > 0)
                {
                    comboBox_kindSelector.Enabled = true;
                    if (fileList.Count > 1)
                    {
                        button_next.Enabled = true;
                    }
                    axWindowsMediaPlayer.URL = fileList[0];
                    axWindowsMediaPlayer.Ctlcontrols.play();
                }
            }
        }

        private void button_tbof_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "出力フォルダを選択してください";
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_outputFolder.Text = folderBrowserDialog.SelectedPath.ToString();
                isOFSelected = true;
                if (isSFSelected)
                {
                    button_output.Enabled = true;
                }
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            selectedIndex--;
            if (selectedIndex - 1 < 0) button_previous.Enabled = false;
            if (selectedIndex + 1 < fileList.Count) button_next.Enabled = true;
            isSystem = true;
            dataGridView_files.Rows[selectedIndex + 1].Selected = false;
            dataGridView_files.Rows[selectedIndex].Selected = true;
            dataGridView_files.FirstDisplayedScrollingRowIndex = selectedIndex;
            comboBox_kindSelector.SelectedIndex = kindList.IndexOf((string)dividedList.Rows[selectedIndex]["kind"]);
            isSystem = false;
            axWindowsMediaPlayer.URL = fileList[selectedIndex];
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            selectedIndex++;
            if (selectedIndex + 1 >= fileList.Count) button_next.Enabled = false;
            if (selectedIndex - 1 >= 0) button_previous.Enabled = true;
            isSystem = true;
            dataGridView_files.Rows[selectedIndex - 1].Selected = false;
            dataGridView_files.Rows[selectedIndex].Selected = true;
            dataGridView_files.FirstDisplayedScrollingRowIndex = selectedIndex;
            comboBox_kindSelector.SelectedIndex = kindList.IndexOf((string)dividedList.Rows[selectedIndex]["kind"]);
            isSystem = false;
            axWindowsMediaPlayer.URL = fileList[selectedIndex];
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void dataGridView_files_SelectionChanged(object sender, EventArgs e)
        {
            if (!isSystem)
            {
                dataGridView_files.Rows[selectedIndex].Selected = false;
                selectedIndex = dataGridView_files.CurrentCell.RowIndex;
                if (selectedIndex + 1 >= fileList.Count) button_next.Enabled = false;
                else button_next.Enabled = true;
                if (selectedIndex - 1 < 0) button_previous.Enabled = false;
                else button_previous.Enabled = true;
                comboBox_kindSelector.SelectedIndex = kindList.IndexOf((string)dividedList.Rows[selectedIndex]["kind"]);
                axWindowsMediaPlayer.URL = fileList[selectedIndex];
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void button_addK_Click(object sender, EventArgs e)
        {
            if (textBox_AddKName.Text != "" && kindList.IndexOf(textBox_AddKName.Text) == -1) kindList.Add(textBox_AddKName.Text);
            textBox_AddKName.Text = "";
        }

        private void button_removeK_Click(object sender, EventArgs e)
        {
            if (comboBox_removeKSelector.SelectedIndex != 0 && dividedList.Select("kind = '" + comboBox_removeKSelector.SelectedItem.ToString() + "'").Length == 0) kindList.RemoveAt(comboBox_removeKSelector.SelectedIndex);
            else MessageBox.Show("「未選択」もしくは、削除しようとした種類に振分けられた音声ファイルが存在するため削除できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox_kindSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileList.Count != 0 && selectedIndex < fileList.Count)
            {
                dividedList.Rows[selectedIndex][1] = kindList[comboBox_kindSelector.SelectedIndex];
                nonDividedNumber = dividedList.Select("kind = '未選択'").Length;
                dividedNumber = fileNumber - nonDividedNumber;
                textBox_ndFileNumber.Text = nonDividedNumber.ToString();
                textBox_dFileNumber.Text = dividedNumber.ToString();
            }
        }

        private void checkBox_move_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_copy.Checked = !checkBox_move.Checked;
        }

        private void checkBox_copy_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_move.Checked = !checkBox_copy.Checked;
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;
            if (nonDividedNumber != 0)
            {
                dialogResult = MessageBox.Show("まだ振分けられていない音声ファイルがありますが、振分を実行しますか？", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (dialogResult == DialogResult.OK)
            {
                toolStripStatusLabel.Text = "振分け開始";
                toolStripProgressBar.Value = 0;
                toolStripProgressBar.Maximum = fileNumber + kindList.Count;
                foreach (string kind in kindList)
                {
                    if (!Directory.CreateDirectory(textBox_outputFolder.Text + "\\" + kind).Exists)
                    {
                        MessageBox.Show(kind + "の作成に失敗しました。");
                    }
                    toolStripProgressBar.Value = toolStripProgressBar.Value + 1;
                }
                axWindowsMediaPlayer.Ctlcontrols.stop();
                axWindowsMediaPlayer.URL = "";
                if (checkBox_copy.Checked)
                {
                    for (int index = 0; index < fileNumber; index++)
                    {
                        System.IO.File.Copy(fileList[index], textBox_outputFolder.Text + "\\" + dividedList.Rows[index]["kind"] + "\\" + dividedList.Rows[index]["name"], true);
                        toolStripProgressBar.Value = toolStripProgressBar.Value + 1;
                    }
                }
                else if (checkBox_move.Checked)
                {
                    for (int index = 0; index < fileNumber; index++)
                    {
                        System.IO.File.Move(fileList[index], textBox_outputFolder.Text + "\\" + dividedList.Rows[index]["kind"] + "\\" + dividedList.Rows[index]["name"]);
                        toolStripProgressBar.Value = toolStripProgressBar.Value + 1;
                    }
                }
                MessageBox.Show("振分が完了しました。");
                reeset_All();
            }
            else
            {
                MessageBox.Show("キャンセルしました。");
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(((int)e.KeyCode)>=48 && ((int)e.KeyCode) <= 57)
            {
                if (comboBox_kindSelector.Enabled && kindList.Count > ((int)e.KeyCode) - 48)
                {
                    comboBox_kindSelector.SelectedIndex = ((int)e.KeyCode) - 48;
                }
            }
            else if(((int)e.KeyCode) >= 96 && ((int)e.KeyCode) <= 105)
            {
                if (comboBox_kindSelector.Enabled && kindList.Count > ((int)e.KeyCode) - 96)
                {
                    comboBox_kindSelector.SelectedIndex = ((int)e.KeyCode) - 96;
                }
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Right)
            {
                button_next.PerformClick();
            }
            else if(e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Left)
            {
                button_previous.PerformClick();
            }
            else if(e.KeyCode == Keys.Divide || e.KeyCode == Keys.Up)
            {
                if(comboBox_kindSelector.Enabled && 0 <= comboBox_kindSelector.SelectedIndex - 1)
                {
                    comboBox_kindSelector.SelectedIndex -= 1;
                }
            }
            else if(e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Down)
            {
                if (comboBox_kindSelector.Enabled && comboBox_kindSelector.SelectedIndex + 1 < kindList.Count)
                {
                    comboBox_kindSelector.SelectedIndex += 1;
                }
            }
        }
    }
}
