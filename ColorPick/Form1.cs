using System.Threading;

namespace ColorPick
{
    public partial class Form1 : Form
    {

        bool buttonPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        void BackgroundThread()
        {
            while (true)
            {
                if (buttonPressed)
                {
                    Point cursorPosition = Cursor.Position;
                    Color selectedColor = GetColorAt(cursorPosition);
                    panel1.BackColor = selectedColor;
                    string hexValue = ColorTranslator.ToHtml(selectedColor);
                    textBox1.Text = hexValue;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(BackgroundThread) { IsBackground = true };
            thread.Start();
        }

        Color GetColorAt(Point location)
        {
            using (Bitmap pixelContainer = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(pixelContainer))
                {
                    g.CopyFromScreen(location, Point.Empty, pixelContainer.Size);
                }

                return pixelContainer.GetPixel(0, 0);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            Cursor = Cursors.Cross;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            Cursor = Cursors.Default;
        }
    }
}
