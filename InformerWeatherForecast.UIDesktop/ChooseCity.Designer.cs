namespace InformerWeatherForecast.UIDesktop
{
    partial class ChooseCity
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
            btnClose = new Button();
            listBChooseCity = new ListBox();
            btnChoose = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.Honeydew;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnClose, 0, 2);
            tableLayoutPanel1.Controls.Add(listBChooseCity, 0, 0);
            tableLayoutPanel1.Controls.Add(btnChoose, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(611, 291);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Dock = DockStyle.Fill;
            btnClose.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(57, 246);
            btnClose.Margin = new Padding(57, 0, 57, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(497, 41);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // listBChooseCity
            // 
            listBChooseCity.BackColor = Color.LightGray;
            listBChooseCity.Dock = DockStyle.Fill;
            listBChooseCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBChooseCity.FormattingEnabled = true;
            listBChooseCity.ItemHeight = 28;
            listBChooseCity.Location = new Point(3, 4);
            listBChooseCity.Margin = new Padding(3, 4, 3, 4);
            listBChooseCity.Name = "listBChooseCity";
            listBChooseCity.Size = new Size(605, 195);
            listBChooseCity.TabIndex = 0;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.LightGray;
            btnChoose.Dock = DockStyle.Fill;
            btnChoose.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoose.Location = new Point(57, 203);
            btnChoose.Margin = new Padding(57, 0, 57, 4);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(497, 39);
            btnChoose.TabIndex = 1;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // ChooseCity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(611, 291);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseCity";
            Text = "Choose city";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBChooseCity;
        private Button btnChoose;
        private Button btnClose;
    }
}