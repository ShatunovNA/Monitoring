namespace tray2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������ ������� ���� ������ � ����
            notifyIcon1.Visible = true;
            // ��������� ����� ��� ������� �� 2�� ����� �����, 
            //������� �������  notifyIcon1_MouseDoubleClick
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);

            // ��������� ������� �� ��������� ����
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // ��������� ���� ����, � ���� ��� ���� ��������, ������ �������        
            if (WindowState == FormWindowState.Minimized)
            {
                // ������ ���� ���� �� ������
                this.ShowInTaskbar = false;
                // ������ ���� ������ � ���� ��������
                notifyIcon1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ������ ���� ������ �������
            notifyIcon1.Visible = true;
            // ���������� ����������� ���� � ������
            this.ShowInTaskbar = true;
            //������������� ����
            WindowState = FormWindowState.Normal;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
    }
}
