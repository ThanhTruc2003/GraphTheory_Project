using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphTheory_Project
{
    public partial class GraphTheory_Project : Form
    {
        private DoThiVoHuong dtvh;

        public GraphTheory_Project()
        {
            InitializeComponent();
            dtvh = new DoThiVoHuong();
        }
 
        private void panel_Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Lấy thông tin kích thước của Panel_Graph
            int panel_GraphWidth = panel_Graph.Width;
            int panel_GraphHeight = panel_Graph.Height;

            // Vẽ hình chữ nhật trùng với kích thước của Panel_Graph
            Pen p = new Pen(Color.SkyBlue, 5);
            g.DrawRectangle(p, 0, 0, panel_GraphWidth - 1, panel_GraphHeight - 1);

        }

        private void panel_Feature_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Lấy thông tin kích thước của Panel_Feature
            int panel_FeatureWidth = panel_Feature.Width;
            int panel_FeatureHeight = panel_Feature.Height;

            // Vẽ hình chữ nhật trùng với kích thước của Panel_Feature
            Pen p = new Pen(Color.SkyBlue, 5);
            g.DrawRectangle(p, 0, 0, panel_FeatureWidth - 1, panel_FeatureHeight - 1);
        }

        private void bt_themDinh_Click(object sender, EventArgs e)
        {
            string tenDinh;
            tenDinh = txbThemDinh.Text;
            string[] TenDinh = { "A", "B", "C" }; // Mảng chứa tên đỉnh
            int[] toadoX = { 100, 200, 300 }; // Mảng chứa tọa độ X của các đỉnh
            int[] toadoY = { 150, 250, 350 }; // Mảng chứa tọa độ Y của các đỉnh

            // Kiểm tra số lượng tọa độ X và Y phải giống nhau
            if (TenDinh.Length != toadoX.Length || TenDinh.Length != toadoY.Length)
            {
                // Xử lý lỗi hoặc thông báo cho người dùng
                MessageBox.Show("Lỗi tọa độ", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    Dinh newDinh = new Dinh();
                    newDinh.Ten = tenDinh;
                       // Lấy tọa độ Y của đỉnh thứ i
                    dtvh.Dinh.Add(newDinh);
                    themDinh();
                    txbThemDinh.Text = "";
            }
        }

        private void themDinh()
        {
            // Lấy graphics từ Panel
            Graphics g = panel_Graph.CreateGraphics();

            // Vẽ các đỉnh trên đồ thị
            foreach (Dinh dinh in dtvh.Dinh)
            {
                // Vẽ đỉnh dưới dạng hình tròn
                int x = dinh.ToadoX;
                int y = dinh.ToadoY;
                g.FillEllipse(Brushes.Red, x, y, 20, 20);
                g.DrawString(dinh.Ten, new Font("Arial", 14), Brushes.Black, x + 2, y - 20);
            }
        }
    }
}