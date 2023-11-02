using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace hanoiskayabashny
{
    public partial class Form1 : Form
    {

        public static List<Button> takeButtons;
        public static List<Button> putButtons;
        public static List<Tower> towers;

        public static PictureBox temp;

        public static int steps;


        public class Tower
        {
            public int placeIndex = 0;
            public Point placeCenterPoint;
            public List<PictureBox> rings = new();
            public Tower(int place)
            {
                this.placeIndex = place;
                this.placeCenterPoint = new Point(85 + placeIndex * 170, 282);
            }
            public void Paint()
            {
                int j = 0;


                foreach (PictureBox ring in rings)
                {
                    int i = ring.Size.Width / 50;

                    int x = placeCenterPoint.X - 25 * i;
                    int y = placeCenterPoint.Y - 58 * j;

                    ring.Location = new Point(x, y);
                    j++;
                }
            }
            public void Take()
            {
                PictureBox takedRing = rings.Last();
                rings.RemoveAt(rings.Count - 1);
                takedRing.Top = 100;

                temp = takedRing;

                CheckTowersToPut();
            }
        }


        public static void CheckTowersToTake()
        {
            for (int i = 0; i < 3; i++)
            {
                if (towers[i].rings.Count > 0)
                {
                    takeButtons[i].Visible = true;
                }
            }
        }

        public static void CheckTowersToPut()
        {
            for (int i = 0; i < 3; i++)
            {
                if (towers[i].rings.Count == 0 || temp.Width < towers[i].rings.Last().Width)
                {
                    putButtons[i].Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            takeButtons = new List<Button>() { button1, button2, button3 };
            putButtons = new List<Button>() { button4, button5, button6 };
            towers = new List<Tower>() { new Tower(0), new Tower(1), new Tower(2) };


            for (int i = 3; i > 0; i--)
            {
                PictureBox ring = new PictureBox();
                ring.Name = i.ToString();

                ring.BackColor = Color.FromArgb(255, 100, 150, 245);
                ring.Size = new Size(50 * i, 50);
                ring.Visible = true;
                ring.Enabled = true;

                this.Controls.Add(ring);
                towers[0].rings.Add(ring);
            }

            CheckTowersToTake();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g;
            g = CreateGraphics();
            Pen p = new(Color.Black, 5);

            Point p1 = new Point(25, 340);
            Point p2 = new Point(145, 340);
            g.DrawLine(p, p1, p2);

            Point p3 = new Point(195, 340);
            Point p4 = new Point(315, 340);
            g.DrawLine(p, p3, p4);

            Point p5 = new Point(355, 340);
            Point p6 = new Point(495, 340);
            g.DrawLine(p, p5, p6);

            g.DrawLine(new Pen(Color.Black, 10), 85, 155, 85, 340);
            g.DrawLine(new Pen(Color.Black, 10), 255, 155, 255, 340);
            g.DrawLine(new Pen(Color.Black, 10), 425, 155, 425, 340);



            foreach (Tower tower in towers)
            {
                tower.Paint();
            }
        }

        private void takeButtons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int index = takeButtons.FindIndex(b => b == button);

            towers[index].Take();

            foreach (Button takeButton in takeButtons)
            {
                takeButton.Visible = false;
            }

            this.Refresh();
        }

        private void putButtons_Click(object sender, EventArgs e)
        {
            foreach (Button putButton in putButtons)
            {
                putButton.Visible = false;
            }
            Button button = (Button)sender;

            int index = putButtons.FindIndex(b => b == button);

            towers[index].rings.Add(temp);



            CheckTowersToTake();

            this.Refresh();

            steps++;

            if (towers[2].rings.Count == 3)
            {
                MessageBox.Show("Вы прошли!", "Сделано шагов: " + steps, MessageBoxButtons.OK);
                for (int i = 0; i < 3; i++)
                {

                    takeButtons[i].Visible = false;
                    putButtons[i].Visible = false;

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
