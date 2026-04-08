using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace multiplayer_paint
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints;
        bool pencilDown;
        int brushSelected = 0;
        private Color selectedColor = Color.Black;
        private NetworkManager network = new NetworkManager();

        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            pencilDown = false;
            network.OnDataReceived = OnDataReceived;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await network.Connect("wss://tcp-server-mppaint.onrender.com/ws");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect: " + ex.Message);
            }
        }

        private void OnDataReceived(string data)
        {
            // Add this block BEFORE the existing x1,y1,x2,y2 parsing try/catch:
            if (data.StartsWith("TEXT,"))
            {
                try
                {
                    // Format: TEXT,x,y,colorName,message
                    string[] parts = data.Split(',', 5); // max 5 parts so message can have commas
                    int x = int.Parse(parts[1]);
                    int y = int.Parse(parts[2]);
                    string colorName = parts[3];
                    string text = parts[4].Replace("<<COMMA>>", ",");

                    panel1.Invoke(() =>
                    {
                        DrawTextOnPanel(new Point(x, y), text, Color.FromName(colorName));
                    });
                }
                catch { }
                return;
            }
            // data format: x1,y1,x2,y2,colorName
            try
            {
                string[] parts = data.Split(',');
                int x1 = int.Parse(parts[0]);
                int y1 = int.Parse(parts[1]);
                int x2 = int.Parse(parts[2]);
                int y2 = int.Parse(parts[3]);
                string colorName = parts[4];

                // must use Invoke because we're on a different thread
                panel1.Invoke(() =>
                {
                    Graphics g = panel1.CreateGraphics();
                    Pen pen = new Pen(Color.FromName(colorName), 10);
                    g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
                });
            }
            catch { }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pencilDown && listOfPoints.Count > 0 && brushSelected == 1)
            {
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(selectedColor, 10);
                Point lastPoint = (Point)listOfPoints[listOfPoints.Count - 1];
                g.DrawLine(pen, lastPoint, e.Location);

                // send to server
                string data = $"{lastPoint.X},{lastPoint.Y},{e.Location.X},{e.Location.Y},{selectedColor.Name}";
                network.Send(data);

                listOfPoints.Add(e.Location);
            }
            else if (pencilDown && listOfPoints.Count > 0 && brushSelected == 2)
            {
                Graphics g = panel1.CreateGraphics();
                Pen pen = new Pen(Color.White, 15);
                Point lastPoint = (Point)listOfPoints[listOfPoints.Count - 1];
                g.DrawLine(pen, lastPoint, e.Location);

                string data = $"{lastPoint.X},{lastPoint.Y},{e.Location.X},{e.Location.Y},White";
                network.Send(data);

                listOfPoints.Add(e.Location);
            }
        }

        // keep all your existing methods below
        private void paintBrush(object sender, EventArgs e) { brushSelected = 1; }
        private void eraser(object sender, EventArgs e) { brushSelected = 2; }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (brushSelected == 3)
            {
                SpawnTextBox(e.Location);
                return; // don't add to listOfPoints
            }
            pencilDown = true;
            listOfPoints.Add(e.Location);
        }

        private void colorPicker(object sender, EventArgs e)
        {
            ToolStripButton clicked = (ToolStripButton)sender;
            string colorName = clicked.Tag.ToString();
            selectedColor = Color.FromName(colorName);
        }

        private void clear(object sender, EventArgs e)
        {
            listOfPoints.Clear();
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            network.Send("CLEAR");
        }

        private void circlePoly(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Will be released in a future update");
        }

        private void squarePoly(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Will be released in a future update");
        }

        private void trianglePoly(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Will be released in a future update");
        }

        private void textButton(object sender, EventArgs e)
        {
            brushSelected = 3;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (brushSelected == 3)
            {
                SpawnTextBox(e.Location);
                return; // don't add to listOfPoints
            }
            pencilDown = true;
            listOfPoints.Add(e.Location);
        }

        // Add this new method:
        private void SpawnTextBox(Point location)
        {
            TextBox tb = new TextBox
            {
                Location = new Point(location.X + panel1.Left, location.Y + panel1.Top),
                Width = 200,
                BackColor = Color.LightYellow,
                ForeColor = selectedColor,
                Font = new Font("Arial", 14),
                BorderStyle = BorderStyle.FixedSingle,
                Text = ""
            };

            this.Controls.Add(tb);
            tb.BringToFront();
            tb.Focus();

            tb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string text = tb.Text.Trim();
                    this.Controls.Remove(tb);

                    if (!string.IsNullOrEmpty(text))
                    {
                        DrawTextOnPanel(location, text, selectedColor);

                        // Send format: TEXT,x,y,colorName,message
                        // Replace commas in text to avoid breaking the protocol
                        string safeText = text.Replace(",", "<<COMMA>>");
                        network.Send($"TEXT,{location.X},{location.Y},{selectedColor.Name},{safeText}");
                    }

                    e.SuppressKeyPress = true; // suppress the ding
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Controls.Remove(tb);
                }
            };

            // Also commit on focus lost
            tb.LostFocus += (s, e) =>
            {
                string text = tb.Text.Trim();
                this.Controls.Remove(tb);

                if (!string.IsNullOrEmpty(text))
                {
                    DrawTextOnPanel(location, text, selectedColor);
                    string safeText = text.Replace(",", "<<COMMA>>");
                    network.Send($"TEXT,{location.X},{location.Y},{selectedColor.Name},{safeText}");
                }
            };
        }

        private void DrawTextOnPanel(Point location, string text, Color color)
        {
            Graphics g = panel1.CreateGraphics();
            g.DrawString(text, new Font("Arial", 14), new SolidBrush(color), location);
        }
    }
}