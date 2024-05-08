namespace WeatherApplication
{
    partial class WeatherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherMain));
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.DimGray;
            this.labelTemp.Location = new System.Drawing.Point(188, 74);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(41, 26);
            this.labelTemp.TabIndex = 0;
            this.labelTemp.Text = "0°C";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLike.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeelsLike.ForeColor = System.Drawing.Color.DimGray;
            this.labelFeelsLike.Location = new System.Drawing.Point(188, 108);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(41, 26);
            this.labelFeelsLike.TabIndex = 1;
            this.labelFeelsLike.Text = "0°C";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(327, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(254, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Berlin";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(587, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperatur :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fühlt sich an wie :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMinTemp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTemp.ForeColor = System.Drawing.Color.DimGray;
            this.labelMinTemp.Location = new System.Drawing.Point(188, 142);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(41, 26);
            this.labelMinTemp.TabIndex = 6;
            this.labelMinTemp.Text = "0°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min. Temp :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxTemp
            // 
            this.maxTemp.AutoSize = true;
            this.maxTemp.BackColor = System.Drawing.Color.Transparent;
            this.maxTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTemp.Location = new System.Drawing.Point(71, 178);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.Size = new System.Drawing.Size(102, 23);
            this.maxTemp.TabIndex = 8;
            this.maxTemp.Text = "Max. Temp :";
            this.maxTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxTemp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTemp.ForeColor = System.Drawing.Color.DimGray;
            this.labelMaxTemp.Location = new System.Drawing.Point(188, 177);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(41, 26);
            this.labelMaxTemp.TabIndex = 9;
            this.labelMaxTemp.Text = "0°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Luftfeuchtigkeit :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.ForeColor = System.Drawing.Color.DimGray;
            this.labelHumidity.Location = new System.Drawing.Point(188, 212);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(38, 26);
            this.labelHumidity.TabIndex = 11;
            this.labelHumidity.Text = "0%";
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.BackColor = System.Drawing.Color.Transparent;
            this.labelList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.ForeColor = System.Drawing.Color.DimGray;
            this.labelList.Location = new System.Drawing.Point(287, 178);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(41, 26);
            this.labelList.TabIndex = 12;
            this.labelList.Text = "0°C";
            // 
            // WeatherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMaxTemp);
            this.Controls.Add(this.maxTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMinTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.labelTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherMain";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTemp;
        public System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label maxTemp;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelMinTemp;
        public System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelList;
    }
}