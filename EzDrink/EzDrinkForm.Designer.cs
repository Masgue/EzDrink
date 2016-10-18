namespace EzDrink
{
    partial class EzDrinkForm
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
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkDataGridView = new System.Windows.Forms.DataGridView();
            this._drinkButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderGroupBox = new System.Windows.Forms.GroupBox();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._drinkAdditionGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkAdditionDataGridView = new System.Windows.Forms.DataGridView();
            this._sugarGroupBox = new System.Windows.Forms.GroupBox();
            this._sugarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._normalSugarButton = new System.Windows.Forms.Button();
            this._halfSugarButton = new System.Windows.Forms.Button();
            this._lessSugarButton = new System.Windows.Forms.Button();
            this._noSugarButton = new System.Windows.Forms.Button();
            this._temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this._temperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._normalIceButton = new System.Windows.Forms.Button();
            this._hotButton = new System.Windows.Forms.Button();
            this._lessIceButton = new System.Windows.Forms.Button();
            this._noIceButton = new System.Windows.Forms.Button();
            this._payButton = new System.Windows.Forms.Button();
            this._label = new System.Windows.Forms.Label();
            this._dataSet = new System.Data.DataSet();
            this._dataTable = new System.Data.DataTable();
            this._dataColumnOne = new System.Data.DataColumn();
            this._dataColumnTwo = new System.Data.DataColumn();
            this._drinkAdditionButtonColumn = new DataGridViewDisableButtonColumn();
            this._drinkAdditionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkAdditionPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSugarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAddColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._menuStrip.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._tabPage.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            this._drinkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataGridView)).BeginInit();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._drinkAdditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionDataGridView)).BeginInit();
            this._sugarGroupBox.SuspendLayout();
            this._sugarTableLayoutPanel.SuspendLayout();
            this._temperatureGroupBox.SuspendLayout();
            this._temperatureTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1099, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 24);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1099, 572);
            this._tabControl.TabIndex = 1;
            // 
            // _tabPage1
            // 
            this._tabPage.Controls.Add(this._tableLayoutPanel);
            this._tabPage.Location = new System.Drawing.Point(4, 22);
            this._tabPage.Name = "_tabPage1";
            this._tabPage.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage.Size = new System.Drawing.Size(1091, 546);
            this._tabPage.TabIndex = 0;
            this._tabPage.Text = "點餐系統";
            this._tabPage.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 6;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this._tableLayoutPanel.Controls.Add(this._drinkGroupBox, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._orderGroupBox, 4, 0);
            this._tableLayoutPanel.Controls.Add(this._drinkAdditionGroupBox, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._sugarGroupBox, 2, 1);
            this._tableLayoutPanel.Controls.Add(this._temperatureGroupBox, 2, 3);
            this._tableLayoutPanel.Controls.Add(this._payButton, 5, 4);
            this._tableLayoutPanel.Controls.Add(this._label, 4, 4);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 5;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(1085, 540);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _drinkGroupBox
            // 
            this._drinkGroupBox.Controls.Add(this._drinkDataGridView);
            this._drinkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkGroupBox.Name = "_drinkGroupBox";
            this._tableLayoutPanel.SetRowSpan(this._drinkGroupBox, 5);
            this._drinkGroupBox.Size = new System.Drawing.Size(304, 534);
            this._drinkGroupBox.TabIndex = 0;
            this._drinkGroupBox.TabStop = false;
            this._drinkGroupBox.Text = "飲料";
            // 
            // _drinkDataGridView
            // 
            this._drinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkButtonColumn,
            this._drinkNameColumn,
            this._drinkPriceColumn});
            this._drinkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkDataGridView.Location = new System.Drawing.Point(3, 18);
            this._drinkDataGridView.Name = "_drinkDataGridView";
            this._drinkDataGridView.RowHeadersVisible = false;
            this._drinkDataGridView.RowTemplate.Height = 24;
            this._drinkDataGridView.Size = new System.Drawing.Size(298, 513);
            this._drinkDataGridView.TabIndex = 0;
            this._drinkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkDataGridViewCellContent);
            // 
            // _drinkButtonColumn
            // 
            this._drinkButtonColumn.HeaderText = " ";
            this._drinkButtonColumn.Name = "_drinkButtonColumn";
            // 
            // _drinkNameColumn
            // 
            this._drinkNameColumn.HeaderText = "名稱";
            this._drinkNameColumn.Name = "_drinkNameColumn";
            this._drinkNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkPriceColumn
            // 
            this._drinkPriceColumn.HeaderText = "價格";
            this._drinkPriceColumn.Name = "_drinkPriceColumn";
            this._drinkPriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderGroupBox
            // 
            this._tableLayoutPanel.SetColumnSpan(this._orderGroupBox, 2);
            this._orderGroupBox.Controls.Add(this._orderDataGridView);
            this._orderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderGroupBox.Location = new System.Drawing.Point(663, 3);
            this._orderGroupBox.Name = "_orderGroupBox";
            this._tableLayoutPanel.SetRowSpan(this._orderGroupBox, 4);
            this._orderGroupBox.Size = new System.Drawing.Size(419, 465);
            this._orderGroupBox.TabIndex = 1;
            this._orderGroupBox.TabStop = false;
            this._orderGroupBox.Text = "點單";
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderNameColumn,
            this._orderPriceColumn,
            this._orderSugarColumn,
            this._orderTemperatureColumn,
            this._orderAddColumn,
            this._orderButtonColumn});
            this._orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderDataGridView.Location = new System.Drawing.Point(3, 18);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.RowHeadersVisible = false;
            this._orderDataGridView.RowTemplate.Height = 24;
            this._orderDataGridView.Size = new System.Drawing.Size(413, 444);
            this._orderDataGridView.TabIndex = 0;
            this._orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickOrderDataGridViewCellContent);
            this._orderDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.OrderDataGridViewRowChanged);
            // 
            // _drinkAdditionGroupBox
            // 
            this._drinkAdditionGroupBox.Controls.Add(this._drinkAdditionDataGridView);
            this._drinkAdditionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionGroupBox.Location = new System.Drawing.Point(333, 3);
            this._drinkAdditionGroupBox.Name = "_drinkAdditionGroupBox";
            this._drinkAdditionGroupBox.Size = new System.Drawing.Size(304, 264);
            this._drinkAdditionGroupBox.TabIndex = 2;
            this._drinkAdditionGroupBox.TabStop = false;
            this._drinkAdditionGroupBox.Text = "加料";
            // 
            // _drinkAdditionDataGridView
            // 
            this._drinkAdditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkAdditionButtonColumn,
            this._drinkAdditionNameColumn,
            this._drinkAdditionPriceColumn});
            this._drinkAdditionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionDataGridView.Location = new System.Drawing.Point(3, 18);
            this._drinkAdditionDataGridView.Name = "_drinkAdditionDataGridView";
            this._drinkAdditionDataGridView.RowHeadersVisible = false;
            this._drinkAdditionDataGridView.RowTemplate.Height = 24;
            this._drinkAdditionDataGridView.Size = new System.Drawing.Size(298, 243);
            this._drinkAdditionDataGridView.TabIndex = 0;
            this._drinkAdditionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkAdditionDataGridViewCellContent);
            // 
            // _sugarGroupBox
            // 
            this._sugarGroupBox.Controls.Add(this._sugarTableLayoutPanel);
            this._sugarGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarGroupBox.Location = new System.Drawing.Point(333, 273);
            this._sugarGroupBox.Name = "_sugarGroupBox";
            this._tableLayoutPanel.SetRowSpan(this._sugarGroupBox, 2);
            this._sugarGroupBox.Size = new System.Drawing.Size(304, 128);
            this._sugarGroupBox.TabIndex = 3;
            this._sugarGroupBox.TabStop = false;
            this._sugarGroupBox.Text = "甜度";
            // 
            // _sugarTableLayoutPanel
            // 
            this._sugarTableLayoutPanel.ColumnCount = 3;
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.Controls.Add(this._normalSugarButton, 0, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._halfSugarButton, 2, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._lessSugarButton, 0, 2);
            this._sugarTableLayoutPanel.Controls.Add(this._noSugarButton, 2, 2);
            this._sugarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._sugarTableLayoutPanel.Name = "_sugarTableLayoutPanel";
            this._sugarTableLayoutPanel.RowCount = 3;
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.Size = new System.Drawing.Size(298, 107);
            this._sugarTableLayoutPanel.TabIndex = 0;
            // 
            // _normalSugarButton
            // 
            this._normalSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._normalSugarButton.Location = new System.Drawing.Point(3, 3);
            this._normalSugarButton.Name = "_normalSugarButton";
            this._normalSugarButton.Size = new System.Drawing.Size(133, 37);
            this._normalSugarButton.TabIndex = 0;
            this._normalSugarButton.Text = "正常";
            this._normalSugarButton.UseVisualStyleBackColor = true;
            this._normalSugarButton.Click += new System.EventHandler(this.ClickNormalSugarButton);
            // 
            // _halfSugarButton
            // 
            this._halfSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._halfSugarButton.Location = new System.Drawing.Point(162, 3);
            this._halfSugarButton.Name = "_halfSugarButton";
            this._halfSugarButton.Size = new System.Drawing.Size(133, 37);
            this._halfSugarButton.TabIndex = 1;
            this._halfSugarButton.Text = "半糖";
            this._halfSugarButton.UseVisualStyleBackColor = true;
            this._halfSugarButton.Click += new System.EventHandler(this.ClickHalfSugarButton);
            // 
            // _lessSugarButton
            // 
            this._lessSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lessSugarButton.Location = new System.Drawing.Point(3, 66);
            this._lessSugarButton.Name = "_lessSugarButton";
            this._lessSugarButton.Size = new System.Drawing.Size(133, 38);
            this._lessSugarButton.TabIndex = 2;
            this._lessSugarButton.Text = "微糖";
            this._lessSugarButton.UseVisualStyleBackColor = true;
            this._lessSugarButton.Click += new System.EventHandler(this.ClickLessSugarButton);
            // 
            // _noSugarButton
            // 
            this._noSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noSugarButton.Location = new System.Drawing.Point(162, 66);
            this._noSugarButton.Name = "_noSugarButton";
            this._noSugarButton.Size = new System.Drawing.Size(133, 38);
            this._noSugarButton.TabIndex = 3;
            this._noSugarButton.Text = "無糖";
            this._noSugarButton.UseVisualStyleBackColor = true;
            this._noSugarButton.Click += new System.EventHandler(this.ClickNoSugarButton);
            // 
            // _temperatureGroupBox
            // 
            this._temperatureGroupBox.Controls.Add(this._temperatureTableLayoutPanel);
            this._temperatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureGroupBox.Location = new System.Drawing.Point(333, 407);
            this._temperatureGroupBox.Name = "_temperatureGroupBox";
            this._tableLayoutPanel.SetRowSpan(this._temperatureGroupBox, 2);
            this._temperatureGroupBox.Size = new System.Drawing.Size(304, 130);
            this._temperatureGroupBox.TabIndex = 4;
            this._temperatureGroupBox.TabStop = false;
            this._temperatureGroupBox.Text = "溫度";
            // 
            // _temperatureTableLayoutPanel
            // 
            this._temperatureTableLayoutPanel.ColumnCount = 3;
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.Controls.Add(this._normalIceButton, 0, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._hotButton, 2, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._lessIceButton, 0, 2);
            this._temperatureTableLayoutPanel.Controls.Add(this._noIceButton, 2, 2);
            this._temperatureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._temperatureTableLayoutPanel.Name = "_temperatureTableLayoutPanel";
            this._temperatureTableLayoutPanel.RowCount = 3;
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.Size = new System.Drawing.Size(298, 109);
            this._temperatureTableLayoutPanel.TabIndex = 0;
            // 
            // _normalIceButton
            // 
            this._normalIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._normalIceButton.Location = new System.Drawing.Point(3, 3);
            this._normalIceButton.Name = "_normalIceButton";
            this._normalIceButton.Size = new System.Drawing.Size(133, 38);
            this._normalIceButton.TabIndex = 0;
            this._normalIceButton.Text = "正常";
            this._normalIceButton.UseVisualStyleBackColor = true;
            this._normalIceButton.Click += new System.EventHandler(this.ClickNormalIceButton);
            // 
            // _hotButton
            // 
            this._hotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hotButton.Location = new System.Drawing.Point(162, 3);
            this._hotButton.Name = "_hotButton";
            this._hotButton.Size = new System.Drawing.Size(133, 38);
            this._hotButton.TabIndex = 1;
            this._hotButton.Text = "溫熱";
            this._hotButton.UseVisualStyleBackColor = true;
            this._hotButton.Click += new System.EventHandler(this.ClickHotButton);
            // 
            // _lessIceButton
            // 
            this._lessIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lessIceButton.Location = new System.Drawing.Point(3, 67);
            this._lessIceButton.Name = "_lessIceButton";
            this._lessIceButton.Size = new System.Drawing.Size(133, 39);
            this._lessIceButton.TabIndex = 2;
            this._lessIceButton.Text = "少冰";
            this._lessIceButton.UseVisualStyleBackColor = true;
            this._lessIceButton.Click += new System.EventHandler(this.ClickLessIceButton);
            // 
            // _noIceButton
            // 
            this._noIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noIceButton.Location = new System.Drawing.Point(162, 67);
            this._noIceButton.Name = "_noIceButton";
            this._noIceButton.Size = new System.Drawing.Size(133, 39);
            this._noIceButton.TabIndex = 3;
            this._noIceButton.Text = "去冰";
            this._noIceButton.UseVisualStyleBackColor = true;
            this._noIceButton.Click += new System.EventHandler(this.ClickNoIceButton);
            // 
            // _payButton
            // 
            this._payButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._payButton.Location = new System.Drawing.Point(973, 474);
            this._payButton.Name = "_payButton";
            this._payButton.Size = new System.Drawing.Size(109, 63);
            this._payButton.TabIndex = 5;
            this._payButton.Text = "結帳";
            this._payButton.UseVisualStyleBackColor = true;
            this._payButton.Click += new System.EventHandler(this.ClickPayButton);
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._label.Location = new System.Drawing.Point(663, 471);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(304, 69);
            this._label.TabIndex = 6;
            this._label.Text = "總價：0元";
            this._label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _dataSet1
            // 
            this._dataSet.DataSetName = "NewDataSet";
            this._dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this._dataTable});
            // 
            // _dataTable1
            // 
            this._dataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this._dataColumnOne,
            this._dataColumnTwo});
            this._dataTable.TableName = "Table1";
            // 
            // _dataColumn1
            // 
            this._dataColumnOne.ColumnName = "Column1";
            this._dataColumnOne.Expression = "123";
            this._dataColumnOne.ReadOnly = true;
            // 
            // _dataColumn2
            // 
            this._dataColumnTwo.ColumnName = "Column2";
            // 
            // _drinkAdditionButtonColumn
            // 
            this._drinkAdditionButtonColumn.HeaderText = "  ";
            this._drinkAdditionButtonColumn.Name = "_drinkAdditionButtonColumn";
            // 
            // _drinkAdditionNameColumn
            // 
            this._drinkAdditionNameColumn.HeaderText = "名稱";
            this._drinkAdditionNameColumn.Name = "_drinkAdditionNameColumn";
            // 
            // _drinkAdditionPriceColumn
            // 
            this._drinkAdditionPriceColumn.HeaderText = "價格";
            this._drinkAdditionPriceColumn.Name = "_drinkAdditionPriceColumn";
            // 
            // _orderNameColumn
            // 
            this._orderNameColumn.HeaderText = "飲料名稱";
            this._orderNameColumn.Name = "_orderNameColumn";
            // 
            // _orderPriceColumn
            // 
            this._orderPriceColumn.HeaderText = "價格";
            this._orderPriceColumn.Name = "_orderPriceColumn";
            // 
            // _orderSugarColumn
            // 
            this._orderSugarColumn.HeaderText = "甜度";
            this._orderSugarColumn.Name = "_orderSugarColumn";
            // 
            // _orderTemperatureColumn
            // 
            this._orderTemperatureColumn.HeaderText = "溫度";
            this._orderTemperatureColumn.Name = "_orderTemperatureColumn";
            // 
            // _orderAddColumn
            // 
            this._orderAddColumn.HeaderText = "加料";
            this._orderAddColumn.Name = "_orderAddColumn";
            // 
            // _orderButtonColumn
            // 
            this._orderButtonColumn.HeaderText = " ";
            this._orderButtonColumn.Name = "_orderButtonColumn";
            // 
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 596);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._tabPage.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this._drinkGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataGridView)).EndInit();
            this._orderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this._drinkAdditionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionDataGridView)).EndInit();
            this._sugarGroupBox.ResumeLayout(false);
            this._sugarTableLayoutPanel.ResumeLayout(false);
            this._temperatureGroupBox.ResumeLayout(false);
            this._temperatureTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage;
        private System.Data.DataSet _dataSet;
        private System.Data.DataTable _dataTable;
        private System.Data.DataColumn _dataColumnOne;
        private System.Data.DataColumn _dataColumnTwo;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.GroupBox _drinkGroupBox;
        private System.Windows.Forms.GroupBox _orderGroupBox;
        private System.Windows.Forms.DataGridView _drinkDataGridView;
        private System.Windows.Forms.DataGridView _orderDataGridView;
        private System.Windows.Forms.GroupBox _drinkAdditionGroupBox;
        private System.Windows.Forms.DataGridView _drinkAdditionDataGridView;
        private System.Windows.Forms.GroupBox _sugarGroupBox;
        private System.Windows.Forms.TableLayoutPanel _sugarTableLayoutPanel;
        private System.Windows.Forms.GroupBox _temperatureGroupBox;
        private System.Windows.Forms.TableLayoutPanel _temperatureTableLayoutPanel;
        private System.Windows.Forms.Button _normalSugarButton;
        private System.Windows.Forms.Button _halfSugarButton;
        private System.Windows.Forms.Button _lessSugarButton;
        private System.Windows.Forms.Button _noSugarButton;
        private System.Windows.Forms.Button _normalIceButton;
        private System.Windows.Forms.Button _hotButton;
        private System.Windows.Forms.Button _lessIceButton;
        private System.Windows.Forms.Button _noIceButton;
        private System.Windows.Forms.Button _payButton;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.DataGridViewButtonColumn _drinkButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderSugarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderTemperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderAddColumn;
        private System.Windows.Forms.DataGridViewButtonColumn _orderButtonColumn;
        private DataGridViewDisableButtonColumn _drinkAdditionButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkAdditionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkAdditionPriceColumn;
    }
}