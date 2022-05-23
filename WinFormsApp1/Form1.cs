using System.Drawing.Drawing2D;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            Graphics g=e.Graphics;
            Color FColor = Color.White; //��ɫ1
            Color TColor = Color.Blue;  //��ɫ2
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.Vertical);  //ʵ����ˢ�ӣ���һ������ָʾ��ɫ���򣬵ڶ����͵����������ֱ𽥱���ɫ�Ŀ�ʼ�ͽ��������ĸ�������ʾ��ɫ�ķ���
            g.FillRectangle(b, this.ClientRectangle);  //������ɫ
        }
    }
}