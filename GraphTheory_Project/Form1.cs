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
        private int widthDinh = 180;
        private int heightDinh = 100;
        private int heightTextbox = 46;

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

        private void veDinh()
        {
            // Lấy graphics từ panel_Graph
            Graphics g = panel_Graph.CreateGraphics();

            // Vẽ các đỉnh trên đồ thị
            foreach (Dinh dinh in dtvh.Dinh)
            {
                // Vẽ đỉnh dưới dạng hình tròn
                int x = dinh.ToadoX;
                int y = dinh.ToadoY;
                g.FillEllipse(Brushes.Red, x, y, 20, 20);
                g.DrawString(dinh.Ten, new Font("Arial", 14), Brushes.Black, x + 1, y - 20);
            }
        }

        private void bt_themDinh_Click(object sender, EventArgs e)
        {
            Dinh newDinh = new Dinh();
            string tenDinh = txbThemDinh.Text;
            int length = dtvh.Dinh.Count;        // Lấy số lượng của lớp Đỉnh
            if (txbThemDinh.Text == "")
            {
                // Kiểm tra đầu vào
                MessageBox.Show("Vui lòng nhập đỉnh", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
            }
            else
            { 
                // Tạo đỉnh đầu tiên
                if (length == 0)
                {
                    newDinh.Ten = tenDinh;
                    newDinh.ToadoX = 137;
                    newDinh.ToadoY = 99;
                    dtvh.Dinh.Add(newDinh);
                    veDinh();
                }
                // Tạo đỉnh tiếp theo
                else if (length > 0)
                {
                    // Lấy đỉnh cuối của mảng Đỉnh
                    Dinh dinhCuoi = dtvh.Dinh[length - 1];

                    // Kiểm tra tọa độ x của đỉnh được tạo với chiều rộng của panel_Graph
                    if (dinhCuoi.ToadoX + 20 + widthDinh >= panel_Graph.Width - 1)
                    {
                        // Kiểm tra tọa độ y của đỉnh được tạo với (chiều cao của panel_Graph - chiều cao của textbox)
                        if (dinhCuoi.ToadoY + 20 + heightDinh >= panel_Graph.Height - heightTextbox)
                        {
                            MessageBox.Show("Không thể thêm đỉnh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;      // Thoát khỏi hàm
                        }
                        else
                        {
                            // Gán giá trị tọa độ x của đỉnh được tạo = với giá trị tọa độ x đỉnh đầu tiên
                            // Gía trị tọa độ y của đỉnh được tạo = giá trị tọa độ y đỉnh đầu tiên + đường kính của hình tròn được vẽ + khoảng cách chiều cao của 2 đỉnh
                            newDinh.ToadoX = 137;
                            newDinh.ToadoY = dinhCuoi.ToadoY + 20 + heightDinh;
                        }
                    }
                    else
                    {
                        // Gán giá trị tọa độ x của đỉnh được tạo = giá trị tọa độ x của đỉnh đầu tiên + đường kính của hình tròn được vẽ + khoảng cách chiều rộng của 2 đỉnh
                        // Gán giá trị tọa độ y của đỉnh được tạo = giá trị tọa độ y của đỉnh đầu tiên
                        newDinh.ToadoX = dinhCuoi.ToadoX + 20 + widthDinh;
                        newDinh.ToadoY = dinhCuoi.ToadoY;
                    }
                    newDinh.Ten = tenDinh;
                    dtvh.Dinh.Add(newDinh);
                    veDinh();
                }
                // Clear giá trị đầu vào
                txbThemDinh.Text = "";
            }
        }


    }
}