namespace InformerWeatherForecast.UIDesktop
{
    partial class MoreInfoWeatherForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            listBWeatherInfo = new ListBox();
            btnOk = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Honeydew;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listBWeatherInfo, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listBWeatherInfo
            // 
            listBWeatherInfo.BackColor = Color.LightGray;
            listBWeatherInfo.Dock = DockStyle.Fill;
            listBWeatherInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBWeatherInfo.FormattingEnabled = true;
            listBWeatherInfo.ItemHeight = 28;
            listBWeatherInfo.Location = new Point(3, 4);
            listBWeatherInfo.Margin = new Padding(3, 4, 3, 4);
            listBWeatherInfo.Name = "listBWeatherInfo";
            listBWeatherInfo.Size = new Size(794, 394);
            listBWeatherInfo.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.LightGray;
            btnOk.Dock = DockStyle.Fill;
            btnOk.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(57, 402);
            btnOk.Margin = new Padding(57, 0, 57, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(686, 44);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // MoreInfoWeatherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MoreInfoWeatherForm";
            Text = "More info about current weather";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBWeatherInfo;
        private Button btnOk;
    }
}