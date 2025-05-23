namespace JbMalyser
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			_menuStrip = new MenuStrip();
			_toolStripMenuItemFile = new ToolStripMenuItem();
			_toolStripMenuItemOpen = new ToolStripMenuItem();
			_toolStripMenuItemSave = new ToolStripMenuItem();
			_toolStripMenuItemExit = new ToolStripMenuItem();
			_toolStripMenuItemSetting = new ToolStripMenuItem();
			_toolStripMenuItemFont = new ToolStripMenuItem();
			_toolStripMenuItemHelp = new ToolStripMenuItem();
			_toolStripMenuItemWebsite = new ToolStripMenuItem();
			_toolStripSeparatorHelp = new ToolStripSeparator();
			_toolStripMenuItemVersion = new ToolStripMenuItem();
			_panelForm = new Panel();
			_splitContainer = new SplitContainer();
			_panelInput = new Panel();
			_labelTitle = new Label();
			_textBoxTitle = new TextBox();
			_labelArtist = new Label();
			_textBoxArtist = new TextBox();
			_labelDifficalty = new Label();
			_comboBoxDifficalty = new ComboBox();
			_labelLevel = new Label();
			_numericUpDownLevel = new NumericUpDown();
			_checkBoxLevel = new CheckBox();
			_labelOffset = new Label();
			_numericUpDownOffset = new NumericUpDown();
			_labelPreview = new Label();
			_numericUpDownPreview = new NumericUpDown();
			_labelSound = new Label();
			_textBoxSound = new TextBox();
			_labelJacket = new Label();
			_textBoxJacket = new TextBox();
			_labelBeat = new Label();
			_numericUpDownBeat = new NumericUpDown();
			_tableLayoutPanelOutput = new TableLayoutPanel();
			_labelOutput = new Label();
			_textBoxOutput = new TextBox();
			_menuStrip.SuspendLayout();
			_panelForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)_splitContainer).BeginInit();
			_splitContainer.Panel1.SuspendLayout();
			_splitContainer.Panel2.SuspendLayout();
			_splitContainer.SuspendLayout();
			_panelInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)_numericUpDownLevel).BeginInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownOffset).BeginInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownPreview).BeginInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownBeat).BeginInit();
			_tableLayoutPanelOutput.SuspendLayout();
			SuspendLayout();
			// 
			// _menuStrip
			// 
			_menuStrip.Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			_menuStrip.Items.AddRange(new ToolStripItem[] { _toolStripMenuItemFile, _toolStripMenuItemSetting, _toolStripMenuItemHelp });
			_menuStrip.Location = new Point(0, 0);
			_menuStrip.Name = "_menuStrip";
			_menuStrip.Size = new Size(704, 24);
			_menuStrip.TabIndex = 0;
			_menuStrip.Text = "menuStrip";
			// 
			// _toolStripMenuItemFile
			// 
			_toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { _toolStripMenuItemOpen, _toolStripMenuItemSave, _toolStripMenuItemExit });
			_toolStripMenuItemFile.Name = "_toolStripMenuItemFile";
			_toolStripMenuItemFile.Size = new Size(70, 20);
			_toolStripMenuItemFile.Text = "ファイル(&F)";
			// 
			// _toolStripMenuItemOpen
			// 
			_toolStripMenuItemOpen.Name = "_toolStripMenuItemOpen";
			_toolStripMenuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
			_toolStripMenuItemOpen.Size = new Size(174, 22);
			_toolStripMenuItemOpen.Text = "開く(&O)...";
			_toolStripMenuItemOpen.Click += _toolStripMenuItemOpen_Click;
			// 
			// _toolStripMenuItemSave
			// 
			_toolStripMenuItemSave.Name = "_toolStripMenuItemSave";
			_toolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
			_toolStripMenuItemSave.Size = new Size(174, 22);
			_toolStripMenuItemSave.Text = "保存(&S)...";
			_toolStripMenuItemSave.Click += _toolStripMenuItemSave_Click;
			// 
			// _toolStripMenuItemExit
			// 
			_toolStripMenuItemExit.Name = "_toolStripMenuItemExit";
			_toolStripMenuItemExit.Size = new Size(174, 22);
			_toolStripMenuItemExit.Text = "終了(&X)";
			_toolStripMenuItemExit.Click += _toolStripMenuItemExit_Click;
			// 
			// _toolStripMenuItemSetting
			// 
			_toolStripMenuItemSetting.DropDownItems.AddRange(new ToolStripItem[] { _toolStripMenuItemFont });
			_toolStripMenuItemSetting.Name = "_toolStripMenuItemSetting";
			_toolStripMenuItemSetting.Size = new Size(61, 20);
			_toolStripMenuItemSetting.Text = "設定(&S)";
			// 
			// _toolStripMenuItemFont
			// 
			_toolStripMenuItemFont.Name = "_toolStripMenuItemFont";
			_toolStripMenuItemFont.Size = new Size(136, 22);
			_toolStripMenuItemFont.Text = "フォント(&F)...";
			_toolStripMenuItemFont.Click += _toolStripMenuItemFont_Click;
			// 
			// _toolStripMenuItemHelp
			// 
			_toolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { _toolStripMenuItemWebsite, _toolStripSeparatorHelp, _toolStripMenuItemVersion });
			_toolStripMenuItemHelp.Name = "_toolStripMenuItemHelp";
			_toolStripMenuItemHelp.Size = new Size(67, 20);
			_toolStripMenuItemHelp.Text = "ヘルプ(&H)";
			// 
			// _toolStripMenuItemWebsite
			// 
			_toolStripMenuItemWebsite.Name = "_toolStripMenuItemWebsite";
			_toolStripMenuItemWebsite.Size = new Size(160, 22);
			_toolStripMenuItemWebsite.Text = "ウェブサイト(&W)...";
			_toolStripMenuItemWebsite.Click += _toolStripMenuItemWebsite_Click;
			// 
			// _toolStripSeparatorHelp
			// 
			_toolStripSeparatorHelp.Name = "_toolStripSeparatorHelp";
			_toolStripSeparatorHelp.Size = new Size(157, 6);
			// 
			// _toolStripMenuItemVersion
			// 
			_toolStripMenuItemVersion.Name = "_toolStripMenuItemVersion";
			_toolStripMenuItemVersion.Size = new Size(160, 22);
			_toolStripMenuItemVersion.Text = "v0.0.0.0";
			// 
			// _panelForm
			// 
			_panelForm.Controls.Add(_splitContainer);
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.Location = new Point(0, 24);
			_panelForm.Name = "_panelForm";
			_panelForm.Padding = new Padding(5);
			_panelForm.Size = new Size(704, 417);
			_panelForm.TabIndex = 2;
			// 
			// _splitContainer
			// 
			_splitContainer.Dock = DockStyle.Fill;
			_splitContainer.Location = new Point(5, 5);
			_splitContainer.Name = "_splitContainer";
			// 
			// _splitContainer.Panel1
			// 
			_splitContainer.Panel1.Controls.Add(_panelInput);
			_splitContainer.Panel1.Padding = new Padding(7, 4, 7, 4);
			// 
			// _splitContainer.Panel2
			// 
			_splitContainer.Panel2.Controls.Add(_tableLayoutPanelOutput);
			_splitContainer.Size = new Size(694, 407);
			_splitContainer.SplitterDistance = 300;
			_splitContainer.TabIndex = 1;
			// 
			// _panelInput
			// 
			_panelInput.AutoScroll = true;
			_panelInput.Controls.Add(_labelTitle);
			_panelInput.Controls.Add(_textBoxTitle);
			_panelInput.Controls.Add(_labelArtist);
			_panelInput.Controls.Add(_textBoxArtist);
			_panelInput.Controls.Add(_labelDifficalty);
			_panelInput.Controls.Add(_comboBoxDifficalty);
			_panelInput.Controls.Add(_labelLevel);
			_panelInput.Controls.Add(_numericUpDownLevel);
			_panelInput.Controls.Add(_checkBoxLevel);
			_panelInput.Controls.Add(_labelOffset);
			_panelInput.Controls.Add(_numericUpDownOffset);
			_panelInput.Controls.Add(_labelPreview);
			_panelInput.Controls.Add(_numericUpDownPreview);
			_panelInput.Controls.Add(_labelSound);
			_panelInput.Controls.Add(_textBoxSound);
			_panelInput.Controls.Add(_labelJacket);
			_panelInput.Controls.Add(_textBoxJacket);
			_panelInput.Controls.Add(_labelBeat);
			_panelInput.Controls.Add(_numericUpDownBeat);
			_panelInput.Dock = DockStyle.Fill;
			_panelInput.Location = new Point(7, 4);
			_panelInput.Name = "_panelInput";
			_panelInput.Size = new Size(286, 399);
			_panelInput.TabIndex = 0;
			// 
			// _labelTitle
			// 
			_labelTitle.AutoSize = true;
			_labelTitle.Location = new Point(0, 0);
			_labelTitle.Name = "_labelTitle";
			_labelTitle.Size = new Size(42, 15);
			_labelTitle.TabIndex = 0;
			_labelTitle.Text = "タイトル";
			// 
			// _textBoxTitle
			// 
			_textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_textBoxTitle.Location = new Point(0, 18);
			_textBoxTitle.Name = "_textBoxTitle";
			_textBoxTitle.Size = new Size(286, 23);
			_textBoxTitle.TabIndex = 1;
			_textBoxTitle.TextChanged += _textBoxTitle_TextChanged;
			// 
			// _labelArtist
			// 
			_labelArtist.AutoSize = true;
			_labelArtist.Location = new Point(0, 44);
			_labelArtist.Name = "_labelArtist";
			_labelArtist.Size = new Size(59, 15);
			_labelArtist.TabIndex = 2;
			_labelArtist.Text = "アーティスト";
			// 
			// _textBoxArtist
			// 
			_textBoxArtist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_textBoxArtist.Location = new Point(0, 62);
			_textBoxArtist.Name = "_textBoxArtist";
			_textBoxArtist.Size = new Size(286, 23);
			_textBoxArtist.TabIndex = 3;
			_textBoxArtist.TextChanged += _textBoxArtist_TextChanged;
			// 
			// _labelDifficalty
			// 
			_labelDifficalty.AutoSize = true;
			_labelDifficalty.Location = new Point(0, 94);
			_labelDifficalty.Name = "_labelDifficalty";
			_labelDifficalty.Size = new Size(43, 15);
			_labelDifficalty.TabIndex = 4;
			_labelDifficalty.Text = "難易度";
			// 
			// _comboBoxDifficalty
			// 
			_comboBoxDifficalty.FormattingEnabled = true;
			_comboBoxDifficalty.Location = new Point(57, 91);
			_comboBoxDifficalty.Name = "_comboBoxDifficalty";
			_comboBoxDifficalty.Size = new Size(110, 23);
			_comboBoxDifficalty.TabIndex = 5;
			_comboBoxDifficalty.SelectedIndexChanged += _comboBoxDifficalty_SelectedIndexChanged;
			// 
			// _labelLevel
			// 
			_labelLevel.AutoSize = true;
			_labelLevel.Location = new Point(0, 123);
			_labelLevel.Name = "_labelLevel";
			_labelLevel.Size = new Size(36, 15);
			_labelLevel.TabIndex = 6;
			_labelLevel.Text = "レベル";
			// 
			// _numericUpDownLevel
			// 
			_numericUpDownLevel.DecimalPlaces = 1;
			_numericUpDownLevel.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			_numericUpDownLevel.Location = new Point(57, 120);
			_numericUpDownLevel.Name = "_numericUpDownLevel";
			_numericUpDownLevel.Size = new Size(54, 23);
			_numericUpDownLevel.TabIndex = 7;
			_numericUpDownLevel.TextAlign = HorizontalAlignment.Right;
			_numericUpDownLevel.ValueChanged += _numericUpDownLevel_ValueChanged;
			// 
			// _checkBoxLevel
			// 
			_checkBoxLevel.AutoSize = true;
			_checkBoxLevel.Checked = true;
			_checkBoxLevel.CheckState = CheckState.Checked;
			_checkBoxLevel.Location = new Point(117, 122);
			_checkBoxLevel.Name = "_checkBoxLevel";
			_checkBoxLevel.Size = new Size(50, 19);
			_checkBoxLevel.TabIndex = 8;
			_checkBoxLevel.Text = "小数";
			_checkBoxLevel.UseVisualStyleBackColor = true;
			_checkBoxLevel.CheckedChanged += _checkBoxLevel_CheckedChanged;
			// 
			// _labelOffset
			// 
			_labelOffset.AutoSize = true;
			_labelOffset.Location = new Point(0, 151);
			_labelOffset.Name = "_labelOffset";
			_labelOffset.Size = new Size(49, 15);
			_labelOffset.TabIndex = 9;
			_labelOffset.Text = "オフセット";
			// 
			// _numericUpDownOffset
			// 
			_numericUpDownOffset.Location = new Point(57, 149);
			_numericUpDownOffset.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
			_numericUpDownOffset.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
			_numericUpDownOffset.Name = "_numericUpDownOffset";
			_numericUpDownOffset.Size = new Size(80, 23);
			_numericUpDownOffset.TabIndex = 10;
			_numericUpDownOffset.TextAlign = HorizontalAlignment.Right;
			_numericUpDownOffset.ValueChanged += _numericUpDownOffset_ValueChanged;
			// 
			// _labelPreview
			// 
			_labelPreview.AutoSize = true;
			_labelPreview.Location = new Point(0, 180);
			_labelPreview.Name = "_labelPreview";
			_labelPreview.Size = new Size(51, 15);
			_labelPreview.TabIndex = 11;
			_labelPreview.Text = "プレビュー";
			// 
			// _numericUpDownPreview
			// 
			_numericUpDownPreview.Location = new Point(57, 178);
			_numericUpDownPreview.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
			_numericUpDownPreview.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
			_numericUpDownPreview.Name = "_numericUpDownPreview";
			_numericUpDownPreview.Size = new Size(80, 23);
			_numericUpDownPreview.TabIndex = 12;
			_numericUpDownPreview.TextAlign = HorizontalAlignment.Right;
			_numericUpDownPreview.ValueChanged += _numericUpDownPreview_ValueChanged;
			// 
			// _labelSound
			// 
			_labelSound.AutoSize = true;
			_labelSound.Location = new Point(0, 204);
			_labelSound.Name = "_labelSound";
			_labelSound.Size = new Size(65, 15);
			_labelSound.TabIndex = 13;
			_labelSound.Text = "楽曲ファイル";
			// 
			// _textBoxSound
			// 
			_textBoxSound.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_textBoxSound.Location = new Point(0, 223);
			_textBoxSound.Name = "_textBoxSound";
			_textBoxSound.Size = new Size(286, 23);
			_textBoxSound.TabIndex = 14;
			_textBoxSound.TextChanged += _textBoxSound_TextChanged;
			// 
			// _labelJacket
			// 
			_labelJacket.AutoSize = true;
			_labelJacket.Location = new Point(0, 249);
			_labelJacket.Name = "_labelJacket";
			_labelJacket.Size = new Size(107, 15);
			_labelJacket.TabIndex = 15;
			_labelJacket.Text = "ジャケット画像ファイル";
			// 
			// _textBoxJacket
			// 
			_textBoxJacket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_textBoxJacket.Location = new Point(0, 267);
			_textBoxJacket.Name = "_textBoxJacket";
			_textBoxJacket.Size = new Size(286, 23);
			_textBoxJacket.TabIndex = 16;
			_textBoxJacket.TextChanged += _textBoxJacket_TextChanged;
			// 
			// _labelBeat
			// 
			_labelBeat.AutoSize = true;
			_labelBeat.Location = new Point(0, 298);
			_labelBeat.Name = "_labelBeat";
			_labelBeat.Size = new Size(43, 15);
			_labelBeat.TabIndex = 17;
			_labelBeat.Text = "開始拍";
			// 
			// _numericUpDownBeat
			// 
			_numericUpDownBeat.Location = new Point(57, 296);
			_numericUpDownBeat.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			_numericUpDownBeat.Name = "_numericUpDownBeat";
			_numericUpDownBeat.Size = new Size(54, 23);
			_numericUpDownBeat.TabIndex = 18;
			_numericUpDownBeat.TextAlign = HorizontalAlignment.Right;
			_numericUpDownBeat.ValueChanged += _numericUpDownBeat_ValueChanged;
			// 
			// _tableLayoutPanelOutput
			// 
			_tableLayoutPanelOutput.ColumnCount = 1;
			_tableLayoutPanelOutput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			_tableLayoutPanelOutput.Controls.Add(_labelOutput, 0, 0);
			_tableLayoutPanelOutput.Controls.Add(_textBoxOutput, 0, 1);
			_tableLayoutPanelOutput.Dock = DockStyle.Fill;
			_tableLayoutPanelOutput.Location = new Point(0, 0);
			_tableLayoutPanelOutput.Name = "_tableLayoutPanelOutput";
			_tableLayoutPanelOutput.Padding = new Padding(3);
			_tableLayoutPanelOutput.RowCount = 2;
			_tableLayoutPanelOutput.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
			_tableLayoutPanelOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			_tableLayoutPanelOutput.Size = new Size(390, 407);
			_tableLayoutPanelOutput.TabIndex = 0;
			// 
			// _labelOutput
			// 
			_labelOutput.AutoSize = true;
			_labelOutput.Location = new Point(6, 3);
			_labelOutput.Name = "_labelOutput";
			_labelOutput.Size = new Size(111, 15);
			_labelOutput.TabIndex = 0;
			_labelOutput.Text = "出力テキストプレビュー";
			// 
			// _textBoxOutput
			// 
			_textBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_textBoxOutput.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
			_textBoxOutput.Location = new Point(3, 21);
			_textBoxOutput.Margin = new Padding(0);
			_textBoxOutput.Multiline = true;
			_textBoxOutput.Name = "_textBoxOutput";
			_textBoxOutput.ReadOnly = true;
			_textBoxOutput.ScrollBars = ScrollBars.Both;
			_textBoxOutput.Size = new Size(384, 383);
			_textBoxOutput.TabIndex = 1;
			_textBoxOutput.WordWrap = false;
			// 
			// MainForm
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(704, 441);
			Controls.Add(_panelForm);
			Controls.Add(_menuStrip);
			Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = _menuStrip;
			Name = "MainForm";
			Text = "JbMalyser";
			FormClosing += MainForm_FormClosing;
			DragDrop += MainForm_DragDrop;
			DragEnter += MainForm_DragEnter;
			_menuStrip.ResumeLayout(false);
			_menuStrip.PerformLayout();
			_panelForm.ResumeLayout(false);
			_splitContainer.Panel1.ResumeLayout(false);
			_splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)_splitContainer).EndInit();
			_splitContainer.ResumeLayout(false);
			_panelInput.ResumeLayout(false);
			_panelInput.PerformLayout();
			((System.ComponentModel.ISupportInitialize)_numericUpDownLevel).EndInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownOffset).EndInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownPreview).EndInit();
			((System.ComponentModel.ISupportInitialize)_numericUpDownBeat).EndInit();
			_tableLayoutPanelOutput.ResumeLayout(false);
			_tableLayoutPanelOutput.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip _menuStrip;
		private ToolStripMenuItem _toolStripMenuItemFile;
		private ToolStripMenuItem _toolStripMenuItemOpen;
		private ToolStripMenuItem _toolStripMenuItemSave;
		private ToolStripMenuItem _toolStripMenuItemExit;
		private ToolStripMenuItem _toolStripMenuItemSetting;
		private ToolStripMenuItem _toolStripMenuItemFont;
		private ToolStripMenuItem _toolStripMenuItemHelp;
		private ToolStripMenuItem _toolStripMenuItemWebsite;
		private ToolStripSeparator _toolStripSeparatorHelp;
		private ToolStripMenuItem _toolStripMenuItemVersion;
		private Panel _panelForm;
		private SplitContainer _splitContainer;
		private Panel _panelInput;
		private Label _labelTitle;
		private TextBox _textBoxTitle;
		private Label _labelArtist;
		private TextBox _textBoxArtist;
		private Label _labelDifficalty;
		private ComboBox _comboBoxDifficalty;
		private Label _labelLevel;
		private NumericUpDown _numericUpDownLevel;
		private CheckBox _checkBoxLevel;
		private Label _labelOffset;
		private NumericUpDown _numericUpDownOffset;
		private Label _labelPreview;
		private NumericUpDown _numericUpDownPreview;
		private Label _labelSound;
		private TextBox _textBoxSound;
		private Label _labelJacket;
		private TextBox _textBoxJacket;
		private Label _labelBeat;
		private NumericUpDown _numericUpDownBeat;
		private TableLayoutPanel _tableLayoutPanelOutput;
		private Label _labelOutput;
		private TextBox _textBoxOutput;
	}
}
