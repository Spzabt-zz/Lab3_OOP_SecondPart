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
    /*public delegate void MyDelegate(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox1, Rectangle rectangle,
        Point[] points,
        Color color);*/

    public partial class Form1 : Form
    {
        private readonly Bitmap _bitmap;
        private readonly Random _random;
        private readonly List<CEmblem> _cEmblems;
        private Graphics _graphics;
        private CEmblem _cEmblem;
        private int _squareCount = 1;
        private int _circleCount = 1;
        private int _triangleCount = 1;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _cEmblems = new List<CEmblem>();
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
            var rectangle = new Rectangle(0, 0, 100, 100);
            _cEmblem = new Square(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Square №{_squareCount++}", rectangle, null);
            CreateObject();
        }

        private void createCircleButton_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle(100, 0, 100, 100);
            _cEmblem = new Circle(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Circle №{_circleCount++}", rectangle, null);
            CreateObject();
        }

        private void createTriangleButton_Click(object sender, EventArgs e)
        {
            var point1 = new Point(200, 0);
            var point2 = new Point(300, 50);
            var point3 = new Point(200, 100);
            /*var point1 = new Point(200, 100);
            var point2 = new Point(300, 150);
            var point3 = new Point(200, 200); */
            var points = new Point[]
            {
                point1,
                point2,
                point3
                //new Point( 200,0/*_random.Next(0, 10), _random.Next(300, 350)*/),
                //new Point( 300, 50/*_random.Next(100, 150), _random.Next(300, 350)*/),
                //new Point( 200, 100/*_random.Next(50, 70), _random.Next(240, 260)*/)
            };

            _cEmblem = new Triangle(Color.FromArgb(_random.Next(256), _random.Next(256),
                _random.Next(256)), $"Triangle №{_triangleCount++}", points, point1, point2, point3);
            CreateObject();
        }

        private void CreateObject()
        {
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
                    {
                        cEmblem.HideEmblem(_graphics, pictureBox1, cEmblem.Rectangle, cEmblem.GetPointsArray());
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.ShowEmblem(_graphics, cEmblem.Rectangle /*cEmblem.GetRectangle()*/, cEmblem.Color,
                            cEmblem.GetPointsArray());
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.EnlargeObject);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.EnlargeObject(cEmblem, _graphics, pictureBox1,
                            cEmblem.Rectangle /*cEmblem.GetRectangle()*/, cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.ReduceObject);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.ReduceObject(cEmblem, _graphics, pictureBox1,
                            cEmblem.Rectangle /*cEmblem.GetRectangle()*/, cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void yUpButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.yUp);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.YUp(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void yDownButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.yDown);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.YDown(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void xRightButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.xRight);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.XRight(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void xLeftButton_Click(object sender, EventArgs e)
        {
            //MakeDrawings(_cEmblem.xLeft);
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.XLeft(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        /*private void MakeDrawings(MyDelegate myDelegate)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        myDelegate(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle, cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }*/

        private void ySuperUpButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.SuperYUp(cEmblem, _graphics, pictureBox1, cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void ySuperDownButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.SuperYDown(cEmblem, _graphics, pictureBox1,
                            cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void xSuperRightButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.SuperXRight(cEmblem, _graphics, pictureBox1,
                            cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }

        private void xSuperLeftButton_Click(object sender, EventArgs e)
        {
            using (_graphics = Graphics.FromImage(_bitmap))
                foreach (var cEmblem in _cEmblems)
                {
                    if (objectSelector.Text == cEmblem.Name)
                    {
                        cEmblem.SuperXLeft(cEmblem, _graphics, pictureBox1,
                            cEmblem.Rectangle /*cEmblem.GetRectangle()*/,
                            cEmblem.GetPointsArray(),
                            cEmblem.Color);
                        break;
                    }
                }

            pictureBox1.Image = _bitmap;
        }
    }
}