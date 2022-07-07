namespace LotterySelection
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_random_group = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.smallNum2 = new System.Windows.Forms.TextBox();
            this.smallNum7 = new System.Windows.Forms.TextBox();
            this.smallNum6 = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.smallNum5 = new System.Windows.Forms.TextBox();
            this.smallNum4 = new System.Windows.Forms.TextBox();
            this.smallNum3 = new System.Windows.Forms.TextBox();
            this.smallNum1 = new System.Windows.Forms.TextBox();
            this.numberList = new System.Windows.Forms.ListBox();
            this.bigNum7 = new System.Windows.Forms.Label();
            this.bigNum6 = new System.Windows.Forms.Label();
            this.bigNum5 = new System.Windows.Forms.Label();
            this.bigNum4 = new System.Windows.Forms.Label();
            this.bigNum3 = new System.Windows.Forms.Label();
            this.bigNum2 = new System.Windows.Forms.Label();
            this.bigNum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.randomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.btn_write);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_random);
            this.panel1.Controls.Add(this.btn_random_group);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.smallNum2);
            this.panel1.Controls.Add(this.smallNum7);
            this.panel1.Controls.Add(this.smallNum6);
            this.panel1.Controls.Add(this.textNumber);
            this.panel1.Controls.Add(this.smallNum5);
            this.panel1.Controls.Add(this.smallNum4);
            this.panel1.Controls.Add(this.smallNum3);
            this.panel1.Controls.Add(this.smallNum1);
            this.panel1.Controls.Add(this.numberList);
            this.panel1.Controls.Add(this.bigNum7);
            this.panel1.Controls.Add(this.bigNum6);
            this.panel1.Controls.Add(this.bigNum5);
            this.panel1.Controls.Add(this.bigNum4);
            this.panel1.Controls.Add(this.bigNum3);
            this.panel1.Controls.Add(this.bigNum2);
            this.panel1.Controls.Add(this.bigNum1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(24, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 481);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(555, 395);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 58);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Number";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(684, 319);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(137, 141);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print Number";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(555, 319);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(112, 58);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm Number";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(709, 241);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(112, 58);
            this.btn_write.TabIndex = 4;
            this.btn_write.Text = "Write Number";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(418, 395);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 58);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete Number";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(418, 319);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(112, 58);
            this.btn_random.TabIndex = 4;
            this.btn_random.Text = "Random Choose";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_random_group
            // 
            this.btn_random_group.Location = new System.Drawing.Point(584, 241);
            this.btn_random_group.Name = "btn_random_group";
            this.btn_random_group.Size = new System.Drawing.Size(112, 58);
            this.btn_random_group.TabIndex = 4;
            this.btn_random_group.Text = "Group Random";
            this.btn_random_group.UseVisualStyleBackColor = true;
            this.btn_random_group.Click += new System.EventHandler(this.btn_random_group_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Number of Group:";
            // 
            // smallNum2
            // 
            this.smallNum2.Location = new System.Drawing.Point(467, 168);
            this.smallNum2.Name = "smallNum2";
            this.smallNum2.Size = new System.Drawing.Size(33, 30);
            this.smallNum2.TabIndex = 2;
            this.smallNum2.Text = "0";
            this.smallNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum7
            // 
            this.smallNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.smallNum7.Location = new System.Drawing.Point(740, 168);
            this.smallNum7.Name = "smallNum7";
            this.smallNum7.Size = new System.Drawing.Size(33, 30);
            this.smallNum7.TabIndex = 2;
            this.smallNum7.Text = "0";
            this.smallNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum6
            // 
            this.smallNum6.Location = new System.Drawing.Point(663, 168);
            this.smallNum6.Name = "smallNum6";
            this.smallNum6.Size = new System.Drawing.Size(33, 30);
            this.smallNum6.TabIndex = 2;
            this.smallNum6.Text = "0";
            this.smallNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(466, 269);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(33, 30);
            this.textNumber.TabIndex = 2;
            this.textNumber.Text = "5";
            this.textNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum5
            // 
            this.smallNum5.Location = new System.Drawing.Point(614, 168);
            this.smallNum5.Name = "smallNum5";
            this.smallNum5.Size = new System.Drawing.Size(33, 30);
            this.smallNum5.TabIndex = 2;
            this.smallNum5.Text = "0";
            this.smallNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum4
            // 
            this.smallNum4.Location = new System.Drawing.Point(565, 168);
            this.smallNum4.Name = "smallNum4";
            this.smallNum4.Size = new System.Drawing.Size(33, 30);
            this.smallNum4.TabIndex = 2;
            this.smallNum4.Text = "0";
            this.smallNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum3
            // 
            this.smallNum3.Location = new System.Drawing.Point(516, 168);
            this.smallNum3.Name = "smallNum3";
            this.smallNum3.Size = new System.Drawing.Size(33, 30);
            this.smallNum3.TabIndex = 2;
            this.smallNum3.Text = "0";
            this.smallNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallNum1
            // 
            this.smallNum1.Location = new System.Drawing.Point(418, 168);
            this.smallNum1.Name = "smallNum1";
            this.smallNum1.Size = new System.Drawing.Size(33, 30);
            this.smallNum1.TabIndex = 2;
            this.smallNum1.Text = "0";
            this.smallNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberList
            // 
            this.numberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numberList.FormattingEnabled = true;
            this.numberList.ItemHeight = 24;
            this.numberList.Location = new System.Drawing.Point(36, 168);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(345, 292);
            this.numberList.TabIndex = 1;
            // 
            // bigNum7
            // 
            this.bigNum7.AutoEllipsis = true;
            this.bigNum7.AutoSize = true;
            this.bigNum7.BackColor = System.Drawing.SystemColors.MenuText;
            this.bigNum7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bigNum7.Location = new System.Drawing.Point(680, 92);
            this.bigNum7.Name = "bigNum7";
            this.bigNum7.Size = new System.Drawing.Size(41, 46);
            this.bigNum7.TabIndex = 0;
            this.bigNum7.Text = "0";
            this.bigNum7.UseWaitCursor = true;
            // 
            // bigNum6
            // 
            this.bigNum6.AutoEllipsis = true;
            this.bigNum6.AutoSize = true;
            this.bigNum6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum6.Location = new System.Drawing.Point(573, 92);
            this.bigNum6.Name = "bigNum6";
            this.bigNum6.Size = new System.Drawing.Size(41, 46);
            this.bigNum6.TabIndex = 0;
            this.bigNum6.Text = "0";
            this.bigNum6.UseWaitCursor = true;
            // 
            // bigNum5
            // 
            this.bigNum5.AutoEllipsis = true;
            this.bigNum5.AutoSize = true;
            this.bigNum5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum5.Location = new System.Drawing.Point(466, 92);
            this.bigNum5.Name = "bigNum5";
            this.bigNum5.Size = new System.Drawing.Size(41, 46);
            this.bigNum5.TabIndex = 0;
            this.bigNum5.Text = "0";
            this.bigNum5.UseWaitCursor = true;
            // 
            // bigNum4
            // 
            this.bigNum4.AutoEllipsis = true;
            this.bigNum4.AutoSize = true;
            this.bigNum4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum4.Location = new System.Drawing.Point(359, 92);
            this.bigNum4.Name = "bigNum4";
            this.bigNum4.Size = new System.Drawing.Size(41, 46);
            this.bigNum4.TabIndex = 0;
            this.bigNum4.Text = "0";
            this.bigNum4.UseWaitCursor = true;
            // 
            // bigNum3
            // 
            this.bigNum3.AutoEllipsis = true;
            this.bigNum3.AutoSize = true;
            this.bigNum3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum3.Location = new System.Drawing.Point(252, 92);
            this.bigNum3.Name = "bigNum3";
            this.bigNum3.Size = new System.Drawing.Size(41, 46);
            this.bigNum3.TabIndex = 0;
            this.bigNum3.Text = "0";
            this.bigNum3.UseWaitCursor = true;
            // 
            // bigNum2
            // 
            this.bigNum2.AutoEllipsis = true;
            this.bigNum2.AutoSize = true;
            this.bigNum2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum2.Location = new System.Drawing.Point(145, 92);
            this.bigNum2.Name = "bigNum2";
            this.bigNum2.Size = new System.Drawing.Size(41, 46);
            this.bigNum2.TabIndex = 0;
            this.bigNum2.Text = "0";
            this.bigNum2.UseWaitCursor = true;
            // 
            // bigNum1
            // 
            this.bigNum1.AutoEllipsis = true;
            this.bigNum1.AutoSize = true;
            this.bigNum1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bigNum1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigNum1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bigNum1.Location = new System.Drawing.Point(38, 92);
            this.bigNum1.Name = "bigNum1";
            this.bigNum1.Size = new System.Drawing.Size(41, 46);
            this.bigNum1.TabIndex = 0;
            this.bigNum1.Text = "0";
            this.bigNum1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(217, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "6+1 Lottery Selection";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_min);
            this.panel2.Controls.Add(this.btn_max);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 61);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "6+1 Lottery Selection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_min
            // 
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(708, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(36, 32);
            this.btn_min.TabIndex = 0;
            this.btn_min.Text = "─";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Location = new System.Drawing.Point(761, 12);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(36, 32);
            this.btn_max.TabIndex = 0;
            this.btn_max.Text = "□";
            this.btn_max.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(812, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 32);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // randomTimer
            // 
            this.randomTimer.Interval = 50;
            this.randomTimer.Tick += new System.EventHandler(this.randomTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(872, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6+1LotterySelection";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_min;
        private Button btn_max;
        private Button btn_Close;
        private Button btn_clear;
        private Button btn_print;
        private Button btn_confirm;
        private Button btn_write;
        private Button btn_delete;
        private Button btn_random;
        private Button btn_random_group;
        private Label label10;
        private TextBox smallNum2;
        private TextBox smallNum7;
        private TextBox smallNum6;
        private TextBox textNumber;
        private TextBox smallNum5;
        private TextBox smallNum4;
        private TextBox smallNum3;
        private TextBox smallNum1;
        private ListBox numberList;
        private Label bigNum7;
        private Label bigNum6;
        private Label bigNum5;
        private Label bigNum4;
        private Label bigNum3;
        private Label bigNum2;
        private Label bigNum1;
        private Label label2;
        private System.Windows.Forms.Timer randomTimer;
    }
}