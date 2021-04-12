namespace WindowsFormsApplication1
{
    partial class frmPuzzleGame
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbKhung = new System.Windows.Forms.GroupBox();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblBuocDi = new System.Windows.Forms.Label();
            this.lblThoiGianDem = new System.Windows.Forms.Label();
            this.tmrThoiGianDem = new System.Windows.Forms.Timer(this.components);
            this.btnTamDung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGiaiToiUu = new System.Windows.Forms.Button();
            this.lblTimeGiai = new System.Windows.Forms.Label();
            this.lblBuocDuyet = new System.Windows.Forms.Label();
            this.gbAnhGoc = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gbKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhung
            // 
            this.gbKhung.Controls.Add(this.pictureBox6);
            this.gbKhung.Controls.Add(this.pictureBox5);
            this.gbKhung.Controls.Add(this.pictureBox4);
            this.gbKhung.Controls.Add(this.pictureBox3);
            this.gbKhung.Controls.Add(this.pictureBox2);
            this.gbKhung.Controls.Add(this.pictureBox1);
            this.gbKhung.Controls.Add(this.pbx1);
            this.gbKhung.Controls.Add(this.pbx2);
            this.gbKhung.Controls.Add(this.pbx3);
            this.gbKhung.Controls.Add(this.pbx4);
            this.gbKhung.Controls.Add(this.pbx5);
            this.gbKhung.Controls.Add(this.pbx6);
            this.gbKhung.Controls.Add(this.pbx7);
            this.gbKhung.Controls.Add(this.pbx8);
            this.gbKhung.Controls.Add(this.pbx9);
            this.gbKhung.Location = new System.Drawing.Point(44, 5);
            this.gbKhung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKhung.Name = "gbKhung";
            this.gbKhung.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKhung.Size = new System.Drawing.Size(566, 541);
            this.gbKhung.TabIndex = 0;
            this.gbKhung.TabStop = false;
            this.gbKhung.Text = "Khung";
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.Color.LightCoral;
            this.btnChoiLai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLai.Location = new System.Drawing.Point(660, 548);
            this.btnChoiLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(79, 52);
            this.btnChoiLai.TabIndex = 1;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1124, 545);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 52);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblBuocDi
            // 
            this.lblBuocDi.AutoSize = true;
            this.lblBuocDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBuocDi.Location = new System.Drawing.Point(83, 559);
            this.lblBuocDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuocDi.Name = "lblBuocDi";
            this.lblBuocDi.Size = new System.Drawing.Size(132, 24);
            this.lblBuocDi.TabIndex = 2;
            this.lblBuocDi.Text = "Số Bước Đi: ";
            // 
            // lblThoiGianDem
            // 
            this.lblThoiGianDem.AutoSize = true;
            this.lblThoiGianDem.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDem.Location = new System.Drawing.Point(819, 336);
            this.lblThoiGianDem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGianDem.Name = "lblThoiGianDem";
            this.lblThoiGianDem.Size = new System.Drawing.Size(248, 75);
            this.lblThoiGianDem.TabIndex = 3;
            this.lblThoiGianDem.Text = "00:00:00";
            // 
            // tmrThoiGianDem
            // 
            this.tmrThoiGianDem.Enabled = true;
            this.tmrThoiGianDem.Interval = 900;
            this.tmrThoiGianDem.Tick += new System.EventHandler(this.TinhThoiGian);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.LightCoral;
            this.btnTamDung.Enabled = false;
            this.btnTamDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.Location = new System.Drawing.Point(767, 548);
            this.btnTamDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(88, 52);
            this.btnTamDung.TabIndex = 4;
            this.btnTamDung.Text = "Tạm Dừng";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(891, 545);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giải BFS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(289, 554);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 41);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<< Đi Lui";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnDiLui_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightCoral;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(419, 554);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 41);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Đi Tới >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnDiToi_Click);
            // 
            // btnGiaiToiUu
            // 
            this.btnGiaiToiUu.BackColor = System.Drawing.Color.LightPink;
            this.btnGiaiToiUu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiaiToiUu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiToiUu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGiaiToiUu.Location = new System.Drawing.Point(1008, 548);
            this.btnGiaiToiUu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiaiToiUu.Name = "btnGiaiToiUu";
            this.btnGiaiToiUu.Size = new System.Drawing.Size(79, 52);
            this.btnGiaiToiUu.TabIndex = 7;
            this.btnGiaiToiUu.Text = "Giải Tối Ưu";
            this.btnGiaiToiUu.UseVisualStyleBackColor = false;
            this.btnGiaiToiUu.Click += new System.EventHandler(this.btnGiaiToiUu_Click);
            // 
            // lblTimeGiai
            // 
            this.lblTimeGiai.AutoSize = true;
            this.lblTimeGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeGiai.Location = new System.Drawing.Point(827, 437);
            this.lblTimeGiai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeGiai.Name = "lblTimeGiai";
            this.lblTimeGiai.Size = new System.Drawing.Size(225, 25);
            this.lblTimeGiai.TabIndex = 8;
            this.lblTimeGiai.Text = "Thoi gian giai : 0.0 ms";
            this.lblTimeGiai.Click += new System.EventHandler(this.lblTimeGiai_Click);
            // 
            // lblBuocDuyet
            // 
            this.lblBuocDuyet.AutoSize = true;
            this.lblBuocDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDuyet.Location = new System.Drawing.Point(827, 476);
            this.lblBuocDuyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuocDuyet.Name = "lblBuocDuyet";
            this.lblBuocDuyet.Size = new System.Drawing.Size(176, 25);
            this.lblBuocDuyet.TabIndex = 9;
            this.lblBuocDuyet.Text = "Số bước duyệt: 0";
            // 
            // gbAnhGoc
            // 
            this.gbAnhGoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAnhGoc.BackgroundImage")));
            this.gbAnhGoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAnhGoc.Location = new System.Drawing.Point(713, 15);
            this.gbAnhGoc.Margin = new System.Windows.Forms.Padding(4);
            this.gbAnhGoc.Name = "gbAnhGoc";
            this.gbAnhGoc.Padding = new System.Windows.Forms.Padding(4);
            this.gbAnhGoc.Size = new System.Drawing.Size(436, 304);
            this.gbAnhGoc.TabIndex = 0;
            this.gbAnhGoc.TabStop = false;
            this.gbAnhGoc.Text = "Hình Gốc";
            this.gbAnhGoc.Enter += new System.EventHandler(this.gbAnhGoc_Enter);
            // 
            // pbx1
            // 
            this.pbx1.Image = global::WindowsFormsApplication1.Properties.Resources._10;
            this.pbx1.Location = new System.Drawing.Point(23, 28);
            this.pbx1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(168, 100);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx2
            // 
            this.pbx2.Image = global::WindowsFormsApplication1.Properties.Resources._11;
            this.pbx2.Location = new System.Drawing.Point(199, 28);
            this.pbx2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(168, 100);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(375, 28);
            this.pbx3.Margin = new System.Windows.Forms.Padding(4);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(173, 100);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(23, 136);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(168, 87);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(199, 136);
            this.pbx5.Margin = new System.Windows.Forms.Padding(4);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(168, 87);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(375, 136);
            this.pbx6.Margin = new System.Windows.Forms.Padding(4);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(173, 87);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(23, 231);
            this.pbx7.Margin = new System.Windows.Forms.Padding(4);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(168, 83);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(199, 231);
            this.pbx8.Margin = new System.Windows.Forms.Padding(4);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(168, 83);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(375, 231);
            this.pbx9.Margin = new System.Windows.Forms.Padding(4);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(173, 83);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 85);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(196, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 85);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(17, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 85);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::WindowsFormsApplication1.Properties.Resources._13;
            this.pictureBox4.Location = new System.Drawing.Point(375, 412);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 85);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(194, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 85);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(17, 412);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(173, 85);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 683);
            this.Controls.Add(this.lblBuocDuyet);
            this.Controls.Add(this.lblTimeGiai);
            this.Controls.Add(this.btnGiaiToiUu);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.lblThoiGianDem);
            this.Controls.Add(this.lblBuocDi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.gbAnhGoc);
            this.Controls.Add(this.gbKhung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Ghép Hình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraThoatChuongTrinh);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKhung;
        private System.Windows.Forms.GroupBox gbAnhGoc;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblBuocDi;
        private System.Windows.Forms.Label lblThoiGianDem;
        private System.Windows.Forms.Timer tmrThoiGianDem;
        private System.Windows.Forms.Button btnTamDung;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnGiaiToiUu;
		private System.Windows.Forms.Label lblTimeGiai;
		private System.Windows.Forms.Label lblBuocDuyet;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

