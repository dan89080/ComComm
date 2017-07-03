namespace ComComm
{
    partial class ComComm_Page
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_RefreshPortList = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.button_GetPortLog1 = new System.Windows.Forms.Button();
            this.button_StopLog1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_StopLog2 = new System.Windows.Forms.Button();
            this.button_GetPortLog2 = new System.Windows.Forms.Button();
            this.comboBox_PortList1 = new System.Windows.Forms.ComboBox();
            this.comboBox_PortList2 = new System.Windows.Forms.ComboBox();
            this.button_ClrLog1 = new System.Windows.Forms.Button();
            this.button_ClrLog2 = new System.Windows.Forms.Button();
            this.button_stats1 = new System.Windows.Forms.Button();
            this.button_stats2 = new System.Windows.Forms.Button();
            this.pictureBox_Chart1 = new System.Windows.Forms.PictureBox();
            this.richTextBox_Stat1_1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Stat1_2 = new System.Windows.Forms.RichTextBox();
            this.textBox_test = new System.Windows.Forms.TextBox();
            this.richTextBox_Stat2_2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Stat2_1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Chart2 = new System.Windows.Forms.PictureBox();
            this.textBox_auto = new System.Windows.Forms.TextBox();
            this.button_auto = new System.Windows.Forms.Button();
            this.pictureBox_Chart3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Chart4 = new System.Windows.Forms.PictureBox();
            this.textBox_AmpCnt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // button_RefreshPortList
            // 
            this.button_RefreshPortList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_RefreshPortList.Location = new System.Drawing.Point(300, 317);
            this.button_RefreshPortList.Name = "button_RefreshPortList";
            this.button_RefreshPortList.Size = new System.Drawing.Size(87, 28);
            this.button_RefreshPortList.TabIndex = 1;
            this.button_RefreshPortList.Text = "Refresh";
            this.button_RefreshPortList.UseVisualStyleBackColor = true;
            this.button_RefreshPortList.Click += new System.EventHandler(this.button_RefreshPortList_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(433, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(363, 574);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_test
            // 
            this.button_test.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_test.Location = new System.Drawing.Point(75, 317);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(66, 28);
            this.button_test.TabIndex = 7;
            this.button_test.Text = "test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_GetPortLog1
            // 
            this.button_GetPortLog1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_GetPortLog1.Location = new System.Drawing.Point(546, 12);
            this.button_GetPortLog1.Name = "button_GetPortLog1";
            this.button_GetPortLog1.Size = new System.Drawing.Size(81, 28);
            this.button_GetPortLog1.TabIndex = 8;
            this.button_GetPortLog1.Text = "Get Log";
            this.button_GetPortLog1.UseVisualStyleBackColor = true;
            this.button_GetPortLog1.Click += new System.EventHandler(this.button_GetPortLog1_Click);
            // 
            // button_StopLog1
            // 
            this.button_StopLog1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_StopLog1.Location = new System.Drawing.Point(631, 12);
            this.button_StopLog1.Name = "button_StopLog1";
            this.button_StopLog1.Size = new System.Drawing.Size(81, 28);
            this.button_StopLog1.TabIndex = 9;
            this.button_StopLog1.Text = "Stop Log";
            this.button_StopLog1.UseVisualStyleBackColor = true;
            this.button_StopLog1.Click += new System.EventHandler(this.button_StopLog1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Location = new System.Drawing.Point(809, 75);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(363, 574);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // button_StopLog2
            // 
            this.button_StopLog2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_StopLog2.Location = new System.Drawing.Point(1006, 12);
            this.button_StopLog2.Name = "button_StopLog2";
            this.button_StopLog2.Size = new System.Drawing.Size(81, 28);
            this.button_StopLog2.TabIndex = 14;
            this.button_StopLog2.Text = "Stop Log";
            this.button_StopLog2.UseVisualStyleBackColor = true;
            this.button_StopLog2.Click += new System.EventHandler(this.button_StopLog2_Click);
            // 
            // button_GetPortLog2
            // 
            this.button_GetPortLog2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_GetPortLog2.Location = new System.Drawing.Point(921, 12);
            this.button_GetPortLog2.Name = "button_GetPortLog2";
            this.button_GetPortLog2.Size = new System.Drawing.Size(81, 28);
            this.button_GetPortLog2.TabIndex = 13;
            this.button_GetPortLog2.Text = "Get Log";
            this.button_GetPortLog2.UseVisualStyleBackColor = true;
            this.button_GetPortLog2.Click += new System.EventHandler(this.button_GetPortLog2_Click);
            // 
            // comboBox_PortList1
            // 
            this.comboBox_PortList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortList1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_PortList1.FormattingEnabled = true;
            this.comboBox_PortList1.Location = new System.Drawing.Point(433, 12);
            this.comboBox_PortList1.Name = "comboBox_PortList1";
            this.comboBox_PortList1.Size = new System.Drawing.Size(101, 28);
            this.comboBox_PortList1.TabIndex = 15;
            // 
            // comboBox_PortList2
            // 
            this.comboBox_PortList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortList2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_PortList2.FormattingEnabled = true;
            this.comboBox_PortList2.Location = new System.Drawing.Point(809, 12);
            this.comboBox_PortList2.Name = "comboBox_PortList2";
            this.comboBox_PortList2.Size = new System.Drawing.Size(101, 28);
            this.comboBox_PortList2.TabIndex = 16;
            // 
            // button_ClrLog1
            // 
            this.button_ClrLog1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ClrLog1.Location = new System.Drawing.Point(716, 12);
            this.button_ClrLog1.Name = "button_ClrLog1";
            this.button_ClrLog1.Size = new System.Drawing.Size(81, 28);
            this.button_ClrLog1.TabIndex = 17;
            this.button_ClrLog1.Text = "Clear";
            this.button_ClrLog1.UseVisualStyleBackColor = true;
            this.button_ClrLog1.Click += new System.EventHandler(this.button_ClrLog1_Click);
            // 
            // button_ClrLog2
            // 
            this.button_ClrLog2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ClrLog2.Location = new System.Drawing.Point(1091, 12);
            this.button_ClrLog2.Name = "button_ClrLog2";
            this.button_ClrLog2.Size = new System.Drawing.Size(81, 28);
            this.button_ClrLog2.TabIndex = 18;
            this.button_ClrLog2.Text = "Clear";
            this.button_ClrLog2.UseVisualStyleBackColor = true;
            this.button_ClrLog2.Click += new System.EventHandler(this.button_ClrLog2_Click);
            // 
            // button_stats1
            // 
            this.button_stats1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stats1.Location = new System.Drawing.Point(432, 41);
            this.button_stats1.Name = "button_stats1";
            this.button_stats1.Size = new System.Drawing.Size(365, 28);
            this.button_stats1.TabIndex = 19;
            this.button_stats1.Text = "Min:256 Max:256 Mean:256.--- Var:-.---";
            this.button_stats1.UseVisualStyleBackColor = true;
            this.button_stats1.Click += new System.EventHandler(this.button_stats1_Click);
            // 
            // button_stats2
            // 
            this.button_stats2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stats2.Location = new System.Drawing.Point(808, 41);
            this.button_stats2.Name = "button_stats2";
            this.button_stats2.Size = new System.Drawing.Size(365, 28);
            this.button_stats2.TabIndex = 20;
            this.button_stats2.Text = "Min:256 Max:256 Mean:256.--- Var:-.---";
            this.button_stats2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Chart1
            // 
            this.pictureBox_Chart1.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Chart1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox_Chart1.Name = "pictureBox_Chart1";
            this.pictureBox_Chart1.Size = new System.Drawing.Size(375, 224);
            this.pictureBox_Chart1.TabIndex = 21;
            this.pictureBox_Chart1.TabStop = false;
            // 
            // richTextBox_Stat1_1
            // 
            this.richTextBox_Stat1_1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_Stat1_1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Stat1_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_Stat1_1.Location = new System.Drawing.Point(13, 242);
            this.richTextBox_Stat1_1.Name = "richTextBox_Stat1_1";
            this.richTextBox_Stat1_1.Size = new System.Drawing.Size(184, 70);
            this.richTextBox_Stat1_1.TabIndex = 22;
            this.richTextBox_Stat1_1.Text = "Total  :\nRange  :\nMax Cnt:\nMin Cnt:";
            // 
            // richTextBox_Stat1_2
            // 
            this.richTextBox_Stat1_2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_Stat1_2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Stat1_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_Stat1_2.Location = new System.Drawing.Point(205, 242);
            this.richTextBox_Stat1_2.Name = "richTextBox_Stat1_2";
            this.richTextBox_Stat1_2.Size = new System.Drawing.Size(184, 70);
            this.richTextBox_Stat1_2.TabIndex = 23;
            this.richTextBox_Stat1_2.Text = "Min :\nMax :\nMean:\nVar :";
            // 
            // textBox_test
            // 
            this.textBox_test.Location = new System.Drawing.Point(12, 318);
            this.textBox_test.Name = "textBox_test";
            this.textBox_test.Size = new System.Drawing.Size(57, 25);
            this.textBox_test.TabIndex = 24;
            this.textBox_test.Text = "10";
            this.textBox_test.TextChanged += new System.EventHandler(this.textBox_test_TextChanged);
            this.textBox_test.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_test_KeyDown);
            this.textBox_test.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_test_KeyPress);
            // 
            // richTextBox_Stat2_2
            // 
            this.richTextBox_Stat2_2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_Stat2_2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Stat2_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_Stat2_2.Location = new System.Drawing.Point(204, 579);
            this.richTextBox_Stat2_2.Name = "richTextBox_Stat2_2";
            this.richTextBox_Stat2_2.Size = new System.Drawing.Size(184, 70);
            this.richTextBox_Stat2_2.TabIndex = 27;
            this.richTextBox_Stat2_2.Text = "Min :\nMax :\nMean:\nVar :";
            // 
            // richTextBox_Stat2_1
            // 
            this.richTextBox_Stat2_1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_Stat2_1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Stat2_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_Stat2_1.Location = new System.Drawing.Point(12, 579);
            this.richTextBox_Stat2_1.Name = "richTextBox_Stat2_1";
            this.richTextBox_Stat2_1.Size = new System.Drawing.Size(184, 70);
            this.richTextBox_Stat2_1.TabIndex = 26;
            this.richTextBox_Stat2_1.Text = "Total  :\nRange  :\nMax Cnt:\nMin Cnt:";
            // 
            // pictureBox_Chart2
            // 
            this.pictureBox_Chart2.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Chart2.Location = new System.Drawing.Point(12, 349);
            this.pictureBox_Chart2.Name = "pictureBox_Chart2";
            this.pictureBox_Chart2.Size = new System.Drawing.Size(375, 224);
            this.pictureBox_Chart2.TabIndex = 25;
            this.pictureBox_Chart2.TabStop = false;
            // 
            // textBox_auto
            // 
            this.textBox_auto.Location = new System.Drawing.Point(156, 318);
            this.textBox_auto.Name = "textBox_auto";
            this.textBox_auto.Size = new System.Drawing.Size(57, 25);
            this.textBox_auto.TabIndex = 29;
            this.textBox_auto.Text = "10000";
            // 
            // button_auto
            // 
            this.button_auto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_auto.Location = new System.Drawing.Point(219, 317);
            this.button_auto.Name = "button_auto";
            this.button_auto.Size = new System.Drawing.Size(66, 28);
            this.button_auto.TabIndex = 28;
            this.button_auto.Text = "auto";
            this.button_auto.UseVisualStyleBackColor = true;
            this.button_auto.Click += new System.EventHandler(this.button_auto_Click);
            // 
            // pictureBox_Chart3
            // 
            this.pictureBox_Chart3.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Chart3.Location = new System.Drawing.Point(393, 12);
            this.pictureBox_Chart3.Name = "pictureBox_Chart3";
            this.pictureBox_Chart3.Size = new System.Drawing.Size(33, 224);
            this.pictureBox_Chart3.TabIndex = 30;
            this.pictureBox_Chart3.TabStop = false;
            // 
            // pictureBox_Chart4
            // 
            this.pictureBox_Chart4.BackColor = System.Drawing.Color.Black;
            this.pictureBox_Chart4.Location = new System.Drawing.Point(393, 349);
            this.pictureBox_Chart4.Name = "pictureBox_Chart4";
            this.pictureBox_Chart4.Size = new System.Drawing.Size(33, 224);
            this.pictureBox_Chart4.TabIndex = 31;
            this.pictureBox_Chart4.TabStop = false;
            // 
            // textBox_AmpCnt
            // 
            this.textBox_AmpCnt.Location = new System.Drawing.Point(393, 318);
            this.textBox_AmpCnt.Name = "textBox_AmpCnt";
            this.textBox_AmpCnt.Size = new System.Drawing.Size(34, 25);
            this.textBox_AmpCnt.TabIndex = 32;
            this.textBox_AmpCnt.Text = "15";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 25);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "400";
            // 
            // ComComm_Page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_AmpCnt);
            this.Controls.Add(this.pictureBox_Chart4);
            this.Controls.Add(this.pictureBox_Chart3);
            this.Controls.Add(this.textBox_auto);
            this.Controls.Add(this.button_auto);
            this.Controls.Add(this.richTextBox_Stat2_2);
            this.Controls.Add(this.richTextBox_Stat2_1);
            this.Controls.Add(this.pictureBox_Chart2);
            this.Controls.Add(this.textBox_test);
            this.Controls.Add(this.richTextBox_Stat1_2);
            this.Controls.Add(this.richTextBox_Stat1_1);
            this.Controls.Add(this.pictureBox_Chart1);
            this.Controls.Add(this.button_stats2);
            this.Controls.Add(this.button_stats1);
            this.Controls.Add(this.button_ClrLog2);
            this.Controls.Add(this.button_ClrLog1);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.comboBox_PortList2);
            this.Controls.Add(this.comboBox_PortList1);
            this.Controls.Add(this.button_StopLog2);
            this.Controls.Add(this.button_GetPortLog2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button_StopLog1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_GetPortLog1);
            this.Controls.Add(this.button_RefreshPortList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ComComm_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comport Communication Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RefreshPortList;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_GetPortLog1;
        private System.Windows.Forms.Button button_StopLog1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_StopLog2;
        private System.Windows.Forms.Button button_GetPortLog2;
        private System.Windows.Forms.ComboBox comboBox_PortList1;
        private System.Windows.Forms.ComboBox comboBox_PortList2;
        private System.Windows.Forms.Button button_ClrLog1;
        private System.Windows.Forms.Button button_ClrLog2;
        private System.Windows.Forms.Button button_stats1;
        private System.Windows.Forms.Button button_stats2;
        private System.Windows.Forms.PictureBox pictureBox_Chart1;
        private System.Windows.Forms.RichTextBox richTextBox_Stat1_1;
        private System.Windows.Forms.RichTextBox richTextBox_Stat1_2;
        private System.Windows.Forms.TextBox textBox_test;
        private System.Windows.Forms.RichTextBox richTextBox_Stat2_2;
        private System.Windows.Forms.RichTextBox richTextBox_Stat2_1;
        private System.Windows.Forms.PictureBox pictureBox_Chart2;
        private System.Windows.Forms.TextBox textBox_auto;
        private System.Windows.Forms.Button button_auto;
        private System.Windows.Forms.PictureBox pictureBox_Chart3;
        private System.Windows.Forms.PictureBox pictureBox_Chart4;
        private System.Windows.Forms.TextBox textBox_AmpCnt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

