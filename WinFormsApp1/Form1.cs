using System.Drawing.Drawing2D;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g=e.Graphics;
            Color FColor = Color.White; //颜色1
            Color TColor = Color.Blue;  //颜色2
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.Vertical);  //实例化刷子，第一个参数指示上色区域，第二个和第三个参数分别渐变颜色的开始和结束，第四个参数表示颜色的方向。
            g.FillRectangle(b, this.ClientRectangle);  //进行上色
        }
    }
}