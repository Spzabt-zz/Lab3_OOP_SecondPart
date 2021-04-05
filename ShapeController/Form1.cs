using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeController
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;

        //private Graphics[] _tempGraphicsArray;
        private readonly Bitmap _bitmap;
        private readonly Random _random;
        private CEmblem _cEmblem;
        private List<CEmblem> _cEmblems;
        //private List<Rectangle> _rectangles;
        private int _squareCount = 1;
        private int _circleCount = 1;
        private int _triangleCount = 1;
        private int _count = 0;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _cEmblems = new List<CEmblem>();
            //_graphics = Graphics.FromImage(_bitmap);
            //_rectangles = new List<Rectangle>();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                _cEmblem.DrawEmblem(_graphics);
            pictureBox1.Image = _bitmap;

            pictureBox1.Paint -= pictureBox1_Paint;
        }

        private void createSquareButton_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle( /*0, 0, 50, 50*/_random.Next(0, 50), _random.Next(0, 50),
                _random.Next(50, 100), _random.Next(50, 100));
            _cEmblem = new Square(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Square №{_squareCount++}", rectangle, null);
            _cEmblems.Add(_cEmblem);
            objectSelector.Items.Add(_cEmblem.Name);
            pictureBox1.Paint += pictureBox1_Paint;
            Refresh();
        }

        private void createCircleButton_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle(_random.Next(150, 200), _random.Next(50, 100),
                _random.Next(50, 100), _random.Next(50, 100));
            _cEmblem = new Circle(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Circle №{_circleCount++}", rectangle, null);
            _cEmblems.Add(_cEmblem);
            objectSelector.Items.Add(_cEmblem.Name);
            pictureBox1.Paint += pictureBox1_Paint;
            Refresh();
        }

        private void createTriangleButton_Click(object sender, EventArgs e)
        {
            var points = new Point[]
            {
                new Point( /*10,120*/_random.Next(0, 10), _random.Next(300, 350)),
                new Point( /*100, 320*/_random.Next(100, 150), _random.Next(300, 350)),
                new Point( /*30, 250*/_random.Next(50, 70), _random.Next(240, 260))
            };
            _cEmblem = new Triangle(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Triangle №{_triangleCount++}", points);
            _cEmblems.Add(_cEmblem);
            objectSelector.Items.Add(_cEmblem.Name);
            pictureBox1.Paint += pictureBox1_Paint;
            Refresh();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                        cEmblem.HideEmblem(_graphics, pictureBox1, cEmblem.Rectangle, cEmblem.GetPointsArray());
                }
            pictureBox1.Image = _bitmap;
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                        cEmblem.ShowEmblem(_graphics, pictureBox1, cEmblem.Rectangle, cEmblem.Color, cEmblem.GetPointsArray());
                }
            pictureBox1.Image = _bitmap;
        }

        /*private void CreateObject(CEmblem cEmblem)
        {
            cEmblem = new (Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)));
            //splitContainer1.Panel2.Paint += Panel2_Paint;
            pictureBox1.Paint += pictureBox1_Paint;
            Refresh();
        }*/
    }
}