using A_BFS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class frmPuzzleGame : Form
    {
        int chiSoOTrong, soBuocDi = 0;
        List<Bitmap> mangGoc = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        List<State> ketQuaCuoiCung = new List<State>();
        int currentState = 0;

		List<int> mangCuoi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		// Test case 
		List<int> tesCase1 = new List<int> { 1, 2, 9, 3, 4, 6, 7, 5, 8 }; //trường hợp đb bfs 15/ tối ưu 89
		List<int> tesCase2 = new List<int> { 4, 5, 9, 3, 1, 6, 7, 2, 8 }; //15 nhưng khác số bước duyệt
		List<int> tesCase3 = new List<int> { 4, 9, 5, 3, 1, 6, 7, 2, 8 }; //14 tương tự như 15
		List<int> tesCase4 = new List<int> { 9, 1, 2, 3, 6, 5, 4, 8, 7 }; //bfs không ra, tối ưu ra 53
		List<int> tesCase5 = new List<int> { 9, 1, 3, 2, 6, 5, 4, 7, 8 };//bfs 15 nhưng lâu, tối ưu 37 nhưng nhanh


		List<List<int>> mangTestCase = new List<List<int>>();

		public frmPuzzleGame()
        {
			MessageBox.Show("1");
			InitializeComponent();
			//khởi tạo mảng gốc để so sánh với kqua người chơi
			mangGoc.AddRange(new Bitmap[] { Properties.Resources._10, Properties.Resources._11, Properties.Resources._12, Properties.Resources._13, 
			Properties.Resources._14, Properties.Resources._15, Properties.Resources._16, Properties.Resources._17, Properties.Resources._null });
            lblBuocDi.Text += soBuocDi;
            lblThoiGianDem.Text = "00:00:00";

			// Add test case
			mangTestCase.Add(tesCase1);
			mangTestCase.Add(tesCase2);
			mangTestCase.Add(tesCase3);
			mangTestCase.Add(tesCase4);
			mangTestCase.Add(tesCase5);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            ChoiLai();
			MessageBox.Show("2");
		}

        List<int> ChoiLai()
        {
			MessageBox.Show("3");
			Random r = new Random();
			int j = r.Next(0, 5);
			List<int> mangRandom = mangTestCase[j];

			do
			{
				for (int i = 0; i < 9; i++)
				{
					((PictureBox)gbKhung.Controls[i]).Image = mangGoc[mangRandom[i] - 1];
					if (mangRandom[i] == 9)
						chiSoOTrong = i;
				}
			} while (KiemTraWin());
			return mangRandom;
		}

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
			MessageBox.Show("4");
			DialogResult YesOrNo = new DialogResult();     
            if (lblThoiGianDem.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Bạn có muốn chơi lại hay không kakakakak?","Game Ghép Hình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblThoiGianDem.Text == "00:00:00")
            {
				ChoiLai();
                timer.Reset();
                lblThoiGianDem.Text = "00:00:00";
				soBuocDi = 0;
                lblBuocDi.Text = "Số Bước Đi: 0";
            }
        }

        private void KiemTraThoatChuongTrinh(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Bạn có muốn thoát chương trình hay không kakakak?", "Game Ghép Hình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnThoat && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnThoat && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			KiemTraThoatChuongTrinh(sender, e as FormClosingEventArgs);
		}

        private void btnGiai_Click(object sender, EventArgs e)
        {
			List<int> mangDau = ChoiLai();
            State trThaiDau = new State(mangDau);
            State trThaiCuoi = new State(mangCuoi);
            BFS bfs = new BFS(trThaiDau, trThaiCuoi);

			Stopwatch timer_tmp = new Stopwatch();
			timer_tmp.Reset();
			lblTimeGiai.Text = "Thời gian giải: 0.0 ms";
			timer_tmp.Start();
			
			this.ketQuaCuoiCung = bfs.Solve();

			timer.Stop();
			lblTimeGiai.Text = "Thời gian giải: " + timer_tmp.Elapsed.TotalMilliseconds.ToString() + " ms";
			this.ketQuaCuoiCung.Reverse();
			this.lblBuocDuyet.Text = "Số Bước Duyệt: " + bfs.dem.ToString();
			this.currentState = 0;

			this.lblBuocDi.Text = "Số Bước Đi: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

			State tmp = this.ketQuaCuoiCung[this.currentState];
			List<int> mang = tmp.trangThai;
			for (int j = 0; j < mang.Count; j++)
			{
				((PictureBox)gbKhung.Controls[j]).Image = mangGoc[mang[j]-1];
			}
		}


		private void CachThucDiChuyen(object sender, EventArgs e)
        {
            if (lblThoiGianDem.Text == "00:00:00")
                timer.Start();
            int oNguoiDungChon = gbKhung.Controls.IndexOf(sender as Control);
            if (chiSoOTrong != oNguoiDungChon)
            {
                List<int> danhSachCacChiSoHoHang = new List<int>(new int[] { ((oNguoiDungChon % 3 == 0) ? -1 : oNguoiDungChon - 1), oNguoiDungChon - 3, (oNguoiDungChon % 3 == 2) ? -1 : oNguoiDungChon + 1, oNguoiDungChon + 3 });
                if (danhSachCacChiSoHoHang.Contains(chiSoOTrong))
                {
                    ((PictureBox)gbKhung.Controls[chiSoOTrong]).Image = ((PictureBox)gbKhung.Controls[oNguoiDungChon]).Image;
                    ((PictureBox)gbKhung.Controls[oNguoiDungChon]).Image = mangGoc[8];
					chiSoOTrong = oNguoiDungChon;
                    lblBuocDi.Text = "Số Bước Đi: " + (++soBuocDi);
                    if (KiemTraWin())
                    {
                        timer.Stop();
                        (gbKhung.Controls[8] as PictureBox).Image = mangGoc[8];
                        MessageBox.Show("Chúc mừng bạn đã chiến thắng game...\nThời gian là : " + timer.Elapsed.ToString().Remove(8) + "\nSố Bước Đi : " + soBuocDi, "Game Ghép Hình");
						soBuocDi = 0;
                        lblBuocDi.Text = "Số Bước Đi: 0";
                        lblThoiGianDem.Text = "00:00:00";
                        timer.Reset();
						ChoiLai();
                    }
                }
            }
        }

        bool KiemTraWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbKhung.Controls[i] as PictureBox).Image != mangGoc[i])
					break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void TinhThoiGian(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblThoiGianDem.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnTamDung.Enabled = false;
            else
                btnTamDung.Enabled = true;
        }

        private void btnDiLui_Click(object sender, EventArgs e)
        {
			if(currentState > 0)
			{
				currentState -= 1;

				this.lblBuocDi.Text = "Số Bước Đi: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

				State trt = ketQuaCuoiCung[currentState];

				for (int j = 0; j < trt.trangThai.Count; j++)
				{
					((PictureBox)gbKhung.Controls[j]).Image = mangGoc[trt.trangThai[j] - 1];
				}
			}		
		}

        private void btnDiToi_Click(object sender, EventArgs e)
        {
			if (currentState < ketQuaCuoiCung.Count - 1)
			{
				currentState += 1;

				this.lblBuocDi.Text = "Số Bước Đi: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();

				State trt = ketQuaCuoiCung[currentState];

				for (int j = 0; j < trt.trangThai.Count; j++)
				{
					((PictureBox)gbKhung.Controls[j]).Image = mangGoc[trt.trangThai[j] - 1];
				}
			}				
		}

		private void btnGiaiToiUu_Click(object sender, EventArgs e)
		{
			List<int> mangDau = ChoiLai();
			State trThaiDau = new State(mangDau);
			State trThaiCuoi = new State(mangCuoi);
			BFS bfs = new BFS(trThaiDau, trThaiCuoi);

			Stopwatch timer_tmp = new Stopwatch();
			timer_tmp.Reset();
			lblTimeGiai.Text = "Thời gian giải: 0.0 ms";
			timer_tmp.Start();

			this.ketQuaCuoiCung = bfs.Solve_BestFirstSearch();
			timer.Stop();
			lblTimeGiai.Text = "Thời gian giải: " + timer_tmp.Elapsed.TotalMilliseconds.ToString() + " ms";
			this.ketQuaCuoiCung.Reverse();
			this.lblBuocDuyet.Text = "Số Bước Duyệt: " + bfs.dem.ToString();

			this.currentState = 0;
			this.lblBuocDi.Text = "Số Bước Đi: " + (currentState + 1).ToString() + "/" + this.ketQuaCuoiCung.Count.ToString();
			State tmp = this.ketQuaCuoiCung[this.currentState];
			List<int> mang = tmp.trangThai;
			for (int j = 0; j < mang.Count; j++)
			{
				((PictureBox)gbKhung.Controls[j]).Image = mangGoc[mang[j] - 1];
			}
		}

		private void lblTimeGiai_Click(object sender, EventArgs e)
		{
	
		}

        private void gbAnhGoc_Enter(object sender, EventArgs e)
        {

        }

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnTamDung.Text == "Tạm Dừng")
            {
                timer.Stop();
                gbKhung.Visible = false;
                btnTamDung.Text = "Tiếp Tục";
            }
            else
            {
                timer.Start();
                gbKhung.Visible = true;
                btnTamDung.Text = "Tạm Dừng";
            }
        }
    }
}