namespace LabWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choose = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.Graph1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Graph2 = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transform = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Filter1 = new System.Windows.Forms.Button();
            this.Filter2 = new System.Windows.Forms.Button();
            this.Filter3 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(277, 311);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(303, 57);
            this.choose.TabIndex = 0;
            this.choose.Text = "Choose photo";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // Photo
            // 
            this.Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Photo.Location = new System.Drawing.Point(0, 0);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(429, 305);
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // Graph1
            // 
            this.Graph1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Graph1.Location = new System.Drawing.Point(9, 310);
            this.Graph1.Margin = new System.Windows.Forms.Padding(2);
            this.Graph1.Name = "Graph1";
            this.Graph1.Size = new System.Drawing.Size(264, 326);
            this.Graph1.TabIndex = 2;
            this.Graph1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 639);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brightness histogram\r\nof the original picture";
            // 
            // Graph2
            // 
            this.Graph2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Graph2.Location = new System.Drawing.Point(585, 310);
            this.Graph2.Margin = new System.Windows.Forms.Padding(2);
            this.Graph2.Name = "Graph2";
            this.Graph2.Size = new System.Drawing.Size(264, 326);
            this.Graph2.TabIndex = 4;
            this.Graph2.TabStop = false;
            // 
            // Result
            // 
            this.Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(427, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(429, 305);
            this.Result.TabIndex = 5;
            this.Result.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(582, 638);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brightness histogram\r\nof the resulting picture";
            // 
            // transform
            // 
            this.transform.Location = new System.Drawing.Point(277, 375);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(303, 57);
            this.transform.TabIndex = 7;
            this.transform.Text = "Image correction";
            this.transform.UseVisualStyleBackColor = true;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(277, 437);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(303, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 477);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conversion factor (1..50)\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Filter1
            // 
            this.Filter1.Location = new System.Drawing.Point(277, 504);
            this.Filter1.Name = "Filter1";
            this.Filter1.Size = new System.Drawing.Size(100, 57);
            this.Filter1.TabIndex = 10;
            this.Filter1.Text = "Filter 1";
            this.Filter1.UseVisualStyleBackColor = true;
            this.Filter1.Click += new System.EventHandler(this.Filter1_Click);
            // 
            // Filter2
            // 
            this.Filter2.Location = new System.Drawing.Point(378, 504);
            this.Filter2.Name = "Filter2";
            this.Filter2.Size = new System.Drawing.Size(100, 57);
            this.Filter2.TabIndex = 11;
            this.Filter2.Text = "Filter 2";
            this.Filter2.UseVisualStyleBackColor = true;
            this.Filter2.Click += new System.EventHandler(this.Filter2_Click);
            // 
            // Filter3
            // 
            this.Filter3.Location = new System.Drawing.Point(479, 504);
            this.Filter3.Name = "Filter3";
            this.Filter3.Size = new System.Drawing.Size(100, 57);
            this.Filter3.TabIndex = 12;
            this.Filter3.Text = "Filter 3";
            this.Filter3.UseVisualStyleBackColor = true;
            this.Filter3.Click += new System.EventHandler(this.Filter3_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(277, 578);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(303, 57);
            this.save.TabIndex = 13;
            this.save.Text = "Save the result";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(858, 687);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Filter3);
            this.Controls.Add(this.Filter2);
            this.Controls.Add(this.Filter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(874, 739);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 675);
            this.Name = "Form1";
            this.Text = "Image changing";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox Graph1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Graph2;
        private System.Windows.Forms.PictureBox Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Filter1;
        private System.Windows.Forms.Button Filter2;
        private System.Windows.Forms.Button Filter3;
        private System.Windows.Forms.Button save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

