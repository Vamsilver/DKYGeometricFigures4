using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKYGeometricFigures4
{
    public partial class MainForm : Form
    {
        private Point startPoint;
        private Point endPoint;
        private readonly Figures figures;
        private Figure currentFigure;
        private string currentFigureName;
        private Color strokeColor = Color.Black;
        private Color fillColor = Color.Transparent;

        public MainForm()
        {
            figures = new();
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, workplace, new object[] { true });
            ChangeStrokeColorBtn.BackColor = strokeColor;
            ChangeFillColorBtn.Text = fillColor.ToString();
        }

        private void workplace_Paint(object sender, PaintEventArgs e)
        {
            var drawer = new Drawer(e.Graphics);
            figures.Draw(drawer);
            currentFigure?.Draw(drawer);
        }

        private void workplace_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void workplace_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                endPoint = new Point(e.X, e.Y);
                if(currentFigure is not null)
                {
                    figures.Add(currentFigure);
                }
                workplace.Invalidate();
            }
        }

        private void workplace_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                endPoint = new Point(e.X, e.Y);
                UpdateCurrentFigure();
                workplace.Invalidate();
            }
        }

        private void UpdateCurrentFigure()
        {
            var pen = new StrokeData(int.Parse(ChangeStrokeWidthTB.Text == "" ? "1"
                : ChangeStrokeWidthTB.Text), strokeColor);

            switch (currentFigureName)
            {
                case "T":
                    
                    currentFigure = new Triangle(new Point(startPoint.X,endPoint.Y),
                        new Point((startPoint.X + endPoint.X) / 2,startPoint.Y), 
                        endPoint, pen, fillColor);
                    break;

                case "C":
                    var radius = (int)Math.Sqrt(
                        Math.Pow(endPoint.X - startPoint.X, 2) +
                        Math.Pow(endPoint.Y - startPoint.Y, 2));

                    currentFigure = new Circle(startPoint, radius, pen, fillColor);
                    break;

                case "L":
                    currentFigure = new Line(startPoint, endPoint, pen);
                    break;

                case "R":
                    var startX = Math.Min(startPoint.X, endPoint.X);
                    var startY = Math.Min(startPoint.Y, endPoint.Y);
                    var width = Math.Abs(endPoint.X - startPoint.X);
                    var height = Math.Abs(endPoint.Y - startPoint.Y);

                    currentFigure = new Rectangle(new Point(startX, startY), height, width, pen, fillColor);
                    break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(ModifierKeys == Keys.Control)
            {
                if(e.KeyCode == Keys.S)
                {
                    SaveDrawings();
                }
                else if(e.KeyCode == Keys.L)
                {
                    LoadDrawings();
                }
                else if(e.KeyCode == Keys.Z)
                {
                    figures.PopBack();
                    currentFigure = null;
                    workplace.Invalidate();
                }
            }
        }

        private void SaveDrawings()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    figures.Save(saveFileDialog.FileName);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Файл уже существует", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDrawings()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    figures.Load(openFileDialog.FileName);
                    workplace.Invalidate();
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Невозможно найти указанный файл", "Ошибка в данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Невозможно открыть", "Ошибка в данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            figures.Clear();
            currentFigure = null;
            workplace.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDrawings();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDrawings();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ChangeStrokeColorBtn_Click(object sender, EventArgs e)
        {
            if(ChangeStrokeColorDialog.ShowDialog() == DialogResult.OK)
            {
                strokeColor = ChangeStrokeColorDialog.Color;
                ChangeStrokeColorBtn.BackColor = strokeColor;
            }
        }

        private void ChangeStrokeWidthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.Equals('\n'))
            {
                e.Handled = true;
            }
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            currentFigureName = "L";
        }

        private void TrinagleBtn_Click(object sender, EventArgs e)
        {
            currentFigureName = "T";
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            currentFigureName = "R";
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            currentFigureName = "C";
        }

        private void ChangeFillColorBtn_Click(object sender, EventArgs e)
        {
            if(ChangeFillColorDialog.ShowDialog() == DialogResult.OK)
            {
                fillColor = ChangeFillColorDialog.Color;
                ChangeFillColorBtn.BackColor = fillColor;
                if(fillColor == Color.Transparent)
                {
                    ChangeFillColorBtn.Text = Color.Transparent.ToString();
                }
                else
                {
                    ChangeFillColorBtn.Text = "";
                }
            }
        }
    }
}
