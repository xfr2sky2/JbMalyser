using JbMalyser.ScoreFormat;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Reflection;

namespace JbMalyser
{
	public partial class MainForm : Form
	{
		private Chart chart;

		private Chart Chart
		{
			get => chart;
			set
			{
				chart = value;
				ReflectInputs();
			}
		}

		public MainForm(string path)
		{
			InitializeComponent();
			_textBoxOutput.Font = Properties.Settings.Default.OutputFont;
			_toolStripMenuItemVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			Dictionary<int, string> difficalty = new()
			{
				{ 0, "0: Tutorial" },
				{ 1, "1: Basic" },
				{ 2, "2: Advanced" },
				{ 3, "3: Extreme" },
				{ 4, "4: Edit" }
			};
			_comboBoxDifficalty.DisplayMember = "Value";
			_comboBoxDifficalty.ValueMember = "Key";
			_comboBoxDifficalty.DataSource = difficalty.ToList();
			_comboBoxDifficalty.SelectedIndex = 0;
			if (path != null)
			{
				ReadFromFile(path);
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop)) { return; }

			string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
			if ((drags.Length != 1) || (!File.Exists(drags[0]))) { return; }

			e.Effect = DragDropEffects.Copy;
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
			ReadFromFile(drags[0]);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}

		private void _toolStripMenuItemOpen_Click(object sender, EventArgs e)
		{
			using OpenFileDialog dialog = new();
			dialog.Filter = "mc files (*.mc)|*.mc|All files (*.*)|*.*";
			dialog.FilterIndex = 1;
			dialog.RestoreDirectory = true;
			dialog.Multiselect = false;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ReadFromFile(dialog.FileName);
			}
		}

		private void _toolStripMenuItemSave_Click(object sender, EventArgs e)
		{
			using SaveFileDialog dialog = new();
			dialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
			dialog.FilterIndex = 1;
			dialog.RestoreDirectory = true;
			dialog.OverwritePrompt = true;
			dialog.FileName = Path.GetInvalidFileNameChars().Aggregate(Chart.Title, (s, c) => s.Replace(c.ToString(), "")) + ".txt";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Chart.WriteTo(dialog.OpenFile());
			}
		}

		private void _toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void _toolStripMenuItemFont_Click(object sender, EventArgs e)
		{
			using FontDialog dialog = new();
			dialog.Font = _textBoxOutput.Font;
			dialog.ShowColor = false;
			dialog.ShowEffects = false;
			dialog.AllowScriptChange = false;
			dialog.AllowSimulations = false;
			dialog.FixedPitchOnly = true;
			dialog.AllowVerticalFonts = false;
			dialog.ScriptsOnly = true;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.OutputFont = _textBoxOutput.Font = dialog.Font;
			}
		}

		private void _toolStripMenuItemWebsite_Click(object sender, EventArgs e)
		{
			string url = "https://github.com/xfr2sky2/JbMalyser";
			OpenUrl(url);
		}

		private static Process OpenUrl(string url)
		{
			ProcessStartInfo pi = new()
			{
				FileName = url,
				UseShellExecute = true,
			};
			return Process.Start(pi);
		}

		private void _textBoxTitle_TextChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.Title = _textBoxTitle.Text;
			ReflectOutput();
		}

		private void _textBoxArtist_TextChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.Artist = _textBoxArtist.Text;
			ReflectOutput();
		}

		private void _comboBoxDifficalty_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.Difficulty = (int)_comboBoxDifficalty.SelectedValue;
			ReflectOutput();
		}

		private void _numericUpDownLevel_ValueChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.Level = (float)_numericUpDownLevel.Value;
			ReflectOutput();
		}

		private void _checkBoxLevel_CheckedChanged(object sender, EventArgs e)
		{
			_numericUpDownLevel.DecimalPlaces = _checkBoxLevel.Checked ? 1 : 0;
			_numericUpDownLevel.Increment = _checkBoxLevel.Checked ? 0.1m : 1;
			if (!_checkBoxLevel.Checked)
			{
				_numericUpDownLevel.Value = decimal.Round(_numericUpDownLevel.Value, _numericUpDownLevel.DecimalPlaces);
			}
			if (Chart == null) { return; }
			Chart.NeedLevelDecimalPoint = _checkBoxLevel.Checked;
			ReflectOutput();
		}

		private void _numericUpDownOffset_ValueChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.OffsetTime = (int)_numericUpDownOffset.Value;
			ReflectOutput();
		}

		private void _numericUpDownPreview_ValueChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.PreviewPositionTime = (int)_numericUpDownPreview.Value;
			ReflectOutput();
		}

		private void _textBoxSound_TextChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.SoundPath = _textBoxSound.Text;
			ReflectOutput();
		}

		private void _textBoxJacket_TextChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.JacketPath = _textBoxJacket.Text;
			ReflectOutput();
		}

		private void _numericUpDownBeat_ValueChanged(object sender, EventArgs e)
		{
			if (Chart == null) { return; }
			Chart.OffsetBeat = (int)_numericUpDownBeat.Value;
			_numericUpDownOffset.Value = Chart.OffsetTime;
			ReflectOutput();
		}

		private void ReadFromFile(string path)
		{
			try
			{
				Chart = Chart.FromPath(path);
			}
			catch (Exception)
			{
				_textBoxOutput.Text = "ファイルの変換に失敗しました。\r\nファイル形式が正しいかご確認ください。";
				return;
			}
			ReflectOutput();
		}

		private void ReflectInputs()
		{
			if (Chart == null) { return; }
			_textBoxTitle.Text = Chart.Title;
			_textBoxArtist.Text = Chart.Artist;
			_comboBoxDifficalty.SelectedValue = Chart.Difficulty;
			_numericUpDownLevel.Value = decimal.Round((decimal)Chart.Level, _numericUpDownLevel.DecimalPlaces, MidpointRounding.ToZero);
			Chart.NeedLevelDecimalPoint = _checkBoxLevel.Checked;
			_numericUpDownOffset.Value = Chart.OffsetTime;
			_numericUpDownPreview.Value = Chart.PreviewPositionTime;
			_textBoxSound.Text = Chart.SoundPath;
			_textBoxJacket.Text = Chart.JacketPath;
			_numericUpDownBeat.Value = Chart.OffsetBeat;
		}

		private void ReflectOutput()
		{
			if (Chart == null) { return; }
			_textBoxOutput.Text = Chart.GetStringAsMemoFormat();
		}
	}
}
