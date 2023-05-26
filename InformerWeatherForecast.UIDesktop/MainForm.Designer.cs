namespace InformerWeatherForecast.UIDesktop
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            combBSpeedWind = new ComboBox();
            labSpeedWind = new Label();
            cmbBTempIn = new ComboBox();
            labTempCur = new Label();
            label3 = new Label();
            labHumidity = new Label();
            label2 = new Label();
            labCloud = new Label();
            labelPressure = new Label();
            combBPressure = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            picBCurWeatherImg = new PictureBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            label1 = new Label();
            btnAllCurWeather = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            comboBApi = new ComboBox();
            label9 = new Label();
            combBCity = new ComboBox();
            label7 = new Label();
            combBIpAddress = new ComboBox();
            label6 = new Label();
            btnView = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            combMapOn = new ComboBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            lstVwWeather = new ListView();
            columnHeaderDate = new ColumnHeader();
            columnHeaderTemp = new ColumnHeader();
            columnHeaderWindSpeed = new ColumnHeader();
            columnHeaderWindDirection = new ColumnHeader();
            columnHeaderClouds = new ColumnHeader();
            columnHeaderHumidity = new ColumnHeader();
            columnHeaderPressure = new ColumnHeader();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBCurWeatherImg).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(lstVwWeather, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.1593628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.8406372F));
            tableLayoutPanel1.Size = new Size(1282, 753);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.1538467F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.8461533F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 481F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60.3773575F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.6226425F));
            tableLayoutPanel2.Size = new Size(1276, 445);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 5);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.14607F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 66.8539352F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.Size = new Size(319, 435);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.80899F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.19101F));
            tableLayoutPanel5.Controls.Add(combBSpeedWind, 1, 1);
            tableLayoutPanel5.Controls.Add(labSpeedWind, 0, 1);
            tableLayoutPanel5.Controls.Add(cmbBTempIn, 1, 0);
            tableLayoutPanel5.Controls.Add(labTempCur, 0, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 4);
            tableLayoutPanel5.Controls.Add(labHumidity, 1, 4);
            tableLayoutPanel5.Controls.Add(label2, 0, 3);
            tableLayoutPanel5.Controls.Add(labCloud, 1, 3);
            tableLayoutPanel5.Controls.Add(labelPressure, 0, 2);
            tableLayoutPanel5.Controls.Add(combBPressure, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 182);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 51.11111F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.88889F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel5.Size = new Size(313, 249);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // combBSpeedWind
            // 
            combBSpeedWind.BackColor = Color.LightGray;
            combBSpeedWind.Dock = DockStyle.Fill;
            combBSpeedWind.DropDownStyle = ComboBoxStyle.DropDownList;
            combBSpeedWind.FlatStyle = FlatStyle.Flat;
            combBSpeedWind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combBSpeedWind.ForeColor = SystemColors.InfoText;
            combBSpeedWind.FormattingEnabled = true;
            combBSpeedWind.Location = new Point(168, 48);
            combBSpeedWind.Margin = new Padding(3, 4, 3, 4);
            combBSpeedWind.Name = "combBSpeedWind";
            combBSpeedWind.Size = new Size(142, 36);
            combBSpeedWind.TabIndex = 7;
            combBSpeedWind.SelectedIndexChanged += combBSpeedWind_SelectedIndexChanged;
            // 
            // labSpeedWind
            // 
            labSpeedWind.AutoSize = true;
            labSpeedWind.BackColor = Color.Transparent;
            labSpeedWind.Dock = DockStyle.Fill;
            labSpeedWind.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labSpeedWind.ForeColor = Color.Black;
            labSpeedWind.Location = new Point(3, 44);
            labSpeedWind.Name = "labSpeedWind";
            labSpeedWind.Size = new Size(159, 43);
            labSpeedWind.TabIndex = 6;
            labSpeedWind.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBTempIn
            // 
            cmbBTempIn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBTempIn.BackColor = Color.LightGray;
            cmbBTempIn.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBTempIn.FlatStyle = FlatStyle.Flat;
            cmbBTempIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBTempIn.ForeColor = SystemColors.InfoText;
            cmbBTempIn.FormattingEnabled = true;
            cmbBTempIn.Items.AddRange(new object[] { "F", "C" });
            cmbBTempIn.Location = new Point(168, 4);
            cmbBTempIn.Margin = new Padding(3, 4, 3, 4);
            cmbBTempIn.Name = "cmbBTempIn";
            cmbBTempIn.Size = new Size(142, 36);
            cmbBTempIn.TabIndex = 4;
            cmbBTempIn.SelectedIndexChanged += cmbBTempIn_SelectedIndexChanged;
            // 
            // labTempCur
            // 
            labTempCur.AutoSize = true;
            labTempCur.BackColor = Color.Transparent;
            labTempCur.Dock = DockStyle.Fill;
            labTempCur.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labTempCur.ForeColor = Color.Black;
            labTempCur.Location = new Point(3, 0);
            labTempCur.Name = "labTempCur";
            labTempCur.Size = new Size(159, 44);
            labTempCur.TabIndex = 5;
            labTempCur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 203);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 1;
            label3.Text = "Humidity";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labHumidity
            // 
            labHumidity.AutoSize = true;
            labHumidity.BackColor = Color.Transparent;
            labHumidity.Dock = DockStyle.Fill;
            labHumidity.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labHumidity.ForeColor = Color.Black;
            labHumidity.Location = new Point(168, 203);
            labHumidity.Name = "labHumidity";
            labHumidity.Size = new Size(142, 46);
            labHumidity.TabIndex = 9;
            labHumidity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 139);
            label2.Name = "label2";
            label2.Size = new Size(159, 64);
            label2.TabIndex = 0;
            label2.Text = "Clouds";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labCloud
            // 
            labCloud.AutoSize = true;
            labCloud.BackColor = Color.Transparent;
            labCloud.Dock = DockStyle.Fill;
            labCloud.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labCloud.ForeColor = Color.Black;
            labCloud.Location = new Point(168, 139);
            labCloud.Name = "labCloud";
            labCloud.Size = new Size(142, 64);
            labCloud.TabIndex = 8;
            labCloud.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.BackColor = Color.Transparent;
            labelPressure.Dock = DockStyle.Fill;
            labelPressure.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPressure.ForeColor = Color.Black;
            labelPressure.Location = new Point(3, 87);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new Size(159, 52);
            labelPressure.TabIndex = 10;
            labelPressure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combBPressure
            // 
            combBPressure.BackColor = Color.LightGray;
            combBPressure.Dock = DockStyle.Fill;
            combBPressure.DropDownStyle = ComboBoxStyle.DropDownList;
            combBPressure.FlatStyle = FlatStyle.Popup;
            combBPressure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combBPressure.FormattingEnabled = true;
            combBPressure.Location = new Point(168, 91);
            combBPressure.Margin = new Padding(3, 4, 3, 4);
            combBPressure.Name = "combBPressure";
            combBPressure.Size = new Size(142, 36);
            combBPressure.TabIndex = 11;
            combBPressure.SelectedIndexChanged += combBPressure_SelectedIndexChanged;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(picBCurWeatherImg, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 63);
            tableLayoutPanel7.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(313, 111);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // picBCurWeatherImg
            // 
            picBCurWeatherImg.Dock = DockStyle.Fill;
            picBCurWeatherImg.Location = new Point(159, 4);
            picBCurWeatherImg.Margin = new Padding(3, 4, 3, 4);
            picBCurWeatherImg.Name = "picBCurWeatherImg";
            picBCurWeatherImg.Size = new Size(151, 103);
            picBCurWeatherImg.SizeMode = PictureBoxSizeMode.CenterImage;
            picBCurWeatherImg.TabIndex = 1;
            picBCurWeatherImg.TabStop = false;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel9.Controls.Add(label1, 1, 0);
            tableLayoutPanel9.Controls.Add(btnAllCurWeather, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 4);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(313, 51);
            tableLayoutPanel9.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(65, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 51);
            label1.TabIndex = 1;
            label1.Text = "Current weather";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAllCurWeather
            // 
            btnAllCurWeather.BackColor = Color.LightGray;
            btnAllCurWeather.Dock = DockStyle.Fill;
            btnAllCurWeather.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAllCurWeather.Location = new Point(3, 4);
            btnAllCurWeather.Margin = new Padding(3, 4, 3, 4);
            btnAllCurWeather.Name = "btnAllCurWeather";
            btnAllCurWeather.Size = new Size(56, 43);
            btnAllCurWeather.TabIndex = 2;
            btnAllCurWeather.Text = "'''";
            btnAllCurWeather.UseVisualStyleBackColor = false;
            btnAllCurWeather.Click += btnAllCurWeather_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel3.Controls.Add(btnView, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(330, 5);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0201387F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 73.84456F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1352949F));
            tableLayoutPanel3.Size = new Size(459, 435);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(453, 60);
            label5.TabIndex = 0;
            label5.Text = "Weather forecast";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(comboBApi, 0, 5);
            tableLayoutPanel8.Controls.Add(label9, 0, 4);
            tableLayoutPanel8.Controls.Add(combBCity, 0, 1);
            tableLayoutPanel8.Controls.Add(label7, 0, 0);
            tableLayoutPanel8.Controls.Add(combBIpAddress, 0, 3);
            tableLayoutPanel8.Controls.Add(label6, 0, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 64);
            tableLayoutPanel8.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 6;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.Size = new Size(453, 313);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // comboBApi
            // 
            comboBApi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBApi.BackColor = Color.LightGray;
            comboBApi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBApi.FlatStyle = FlatStyle.Flat;
            comboBApi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBApi.FormattingEnabled = true;
            comboBApi.Location = new Point(29, 268);
            comboBApi.Margin = new Padding(29, 4, 29, 4);
            comboBApi.Name = "comboBApi";
            comboBApi.Size = new Size(395, 36);
            comboBApi.TabIndex = 11;
            comboBApi.SelectedIndexChanged += comboBApi_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 208);
            label9.Name = "label9";
            label9.Size = new Size(447, 52);
            label9.TabIndex = 10;
            label9.Text = "API";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combBCity
            // 
            combBCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            combBCity.BackColor = Color.LightGray;
            tableLayoutPanel8.SetColumnSpan(combBCity, 2);
            combBCity.FlatStyle = FlatStyle.Flat;
            combBCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combBCity.FormattingEnabled = true;
            combBCity.Items.AddRange(new object[] { "Kiev" });
            combBCity.Location = new Point(29, 68);
            combBCity.Margin = new Padding(29, 16, 29, 4);
            combBCity.Name = "combBCity";
            combBCity.Size = new Size(395, 36);
            combBCity.TabIndex = 5;
            combBCity.SelectedIndexChanged += combBCity_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(447, 52);
            label7.TabIndex = 9;
            label7.Text = "City";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combBIpAddress
            // 
            combBIpAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            combBIpAddress.BackColor = Color.LightGray;
            combBIpAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            combBIpAddress.FlatStyle = FlatStyle.Flat;
            combBIpAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combBIpAddress.FormattingEnabled = true;
            combBIpAddress.Location = new Point(29, 164);
            combBIpAddress.Margin = new Padding(29, 4, 29, 4);
            combBIpAddress.Name = "combBIpAddress";
            combBIpAddress.Size = new Size(395, 36);
            combBIpAddress.TabIndex = 7;
            combBIpAddress.SelectedIndexChanged += combBIpAddress_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 104);
            label6.Name = "label6";
            label6.Size = new Size(447, 52);
            label6.TabIndex = 8;
            label6.Text = "Weather for";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            btnView.BackColor = Color.LightGray;
            btnView.Dock = DockStyle.Fill;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.Location = new Point(50, 386);
            btnView.Margin = new Padding(50, 5, 50, 5);
            btnView.Name = "btnView";
            btnView.Size = new Size(359, 44);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.TextAlign = ContentAlignment.TopCenter;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.060606F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.93939F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(combMapOn, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(796, 5);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0229883F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 85.97701F));
            tableLayoutPanel6.Size = new Size(476, 435);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 61);
            label4.TabIndex = 0;
            label4.Text = "Map on";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combMapOn
            // 
            combMapOn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            combMapOn.BackColor = Color.LightGray;
            combMapOn.DropDownStyle = ComboBoxStyle.DropDownList;
            combMapOn.FlatStyle = FlatStyle.Flat;
            combMapOn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            combMapOn.FormattingEnabled = true;
            combMapOn.Location = new Point(127, 15);
            combMapOn.Margin = new Padding(3, 4, 3, 4);
            combMapOn.Name = "combMapOn";
            combMapOn.Size = new Size(346, 31);
            combMapOn.TabIndex = 1;
            combMapOn.SelectedIndexChanged += combMapOn_SelectedIndexChanged;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel6.SetColumnSpan(tableLayoutPanel10, 2);
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 64);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(470, 368);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // lstVwWeather
            // 
            lstVwWeather.BackColor = Color.LightGray;
            lstVwWeather.Columns.AddRange(new ColumnHeader[] { columnHeaderDate, columnHeaderTemp, columnHeaderWindSpeed, columnHeaderWindDirection, columnHeaderClouds, columnHeaderHumidity, columnHeaderPressure });
            lstVwWeather.Dock = DockStyle.Fill;
            lstVwWeather.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstVwWeather.GridLines = true;
            lstVwWeather.Location = new Point(5, 458);
            lstVwWeather.Margin = new Padding(5);
            lstVwWeather.Name = "lstVwWeather";
            lstVwWeather.Size = new Size(1272, 290);
            lstVwWeather.TabIndex = 1;
            lstVwWeather.UseCompatibleStateImageBehavior = false;
            lstVwWeather.View = View.Details;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 120;
            // 
            // columnHeaderTemp
            // 
            columnHeaderTemp.Text = "Temperature";
            columnHeaderTemp.Width = 150;
            // 
            // columnHeaderWindSpeed
            // 
            columnHeaderWindSpeed.Text = "Wind speed";
            columnHeaderWindSpeed.Width = 150;
            // 
            // columnHeaderWindDirection
            // 
            columnHeaderWindDirection.Text = "Wind direction";
            columnHeaderWindDirection.Width = 160;
            // 
            // columnHeaderClouds
            // 
            columnHeaderClouds.Text = "Clouds";
            columnHeaderClouds.Width = 90;
            // 
            // columnHeaderHumidity
            // 
            columnHeaderHumidity.Text = "Humidity";
            columnHeaderHumidity.Width = 120;
            // 
            // columnHeaderPressure
            // 
            columnHeaderPressure.Text = "Pressure";
            columnHeaderPressure.Width = 130;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(43, 22);
            lightToolStripMenuItem.Text = "light";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(43, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 753);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Informer weather forecast";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBCurWeatherImg).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbBTempIn;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox picBCurWeatherImg;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox txtBCity;
        private TextBox txtBLatLon;
        private Button btnView;
        private Label labTempCur;
        private ComboBox combBSpeedWind;
        private Label labSpeedWind;
        private Label labCloud;
        private Label labHumidity;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private ComboBox combMapOn;
        private ListView lstVwWeather;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label1;
        private Button btnAllCurWeather;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private Label label6;
        private ComboBox combBIpAddress;
        private ComboBox combBCity;
        private Label label7;
        private Label labelPressure;
        private ComboBox combBPressure;
        private ComboBox comboBApi;
        private Label label9;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderTemp;
        private ColumnHeader columnHeaderWindSpeed;
        private ColumnHeader columnHeaderWindDirection;
        private ColumnHeader columnHeaderClouds;
        private ColumnHeader columnHeaderHumidity;
        private ColumnHeader columnHeaderPressure;
        private TableLayoutPanel tableLayoutPanel10;
    }
}