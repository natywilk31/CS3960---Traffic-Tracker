namespace TrafficTracker
{
    public partial class Form1 : Form
    {
        private List<Rectangle> roads = new List<Rectangle>();
        private Dictionary<string, Panel> trafficSquares = new Dictionary<string, Panel>();
        bool isRushHour = true;

        public Form1()
        {
            InitializeComponent();

        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set fixed size for the map panel to 1000x1000
            int mapSize = 2000;

            // Calculate position to center the map panel
            int mapPanelX = 500;
            int mapPanelY = 100;

            Panel mapPanel = new Panel
            {
                Location = new Point(mapPanelX, mapPanelY),
                Size = new Size(3000, 2000), // Fixed size of 1000x1000
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Green
            };

            // Horizontal roads
            roads.Add(new Rectangle(0, 100, mapPanel.Width, 200)); // Top road
            roads.Add(new Rectangle(0, 700, mapPanel.Width, 200)); // Bottom road

            // Vertical roads
            roads.Add(new Rectangle(100, 0, 200, mapPanel.Height)); // Left road
            roads.Add(new Rectangle(700, 0, 200, mapPanel.Height)); // Right road

            mapPanel.Paint += MapPanel_Paint;
            mapPanel.Invalidate();

            Controls.Add(mapPanel);

            // Add labels and squares
            AddLabelWithSquare(mapPanel, "1500 East", new Point(1050, 150), Color.Green);
            AddLabelWithSquare(mapPanel, "1300 East", new Point(1050, 750), Color.Green);
            AddLabelWithSquare(mapPanel, "500 South", new Point(125, 400), Color.Green);
            AddLabelWithSquare(mapPanel, "700 South", new Point(725, 400), Color.Green);

            // Create traffic control buttons
            startCycles(mapPanel);
        }

        private void MapPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(Color.Black))
            {
                foreach (var road in roads)
                {
                    e.Graphics.FillRectangle(brush, road);
                }
            }
        }

        private void AddLabelWithSquare(Control parent, string text, Point location, Color color)
        {
            // Create square
            Panel square = new Panel
            {
                Size = new Size(40, 30),
                BackColor = color, // Default color for no rush hour
                Location = new Point(location.X - 10, location.Y + 10)
            };

            // Create label
            Label label = new Label
            {
                Text = text,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(location.X + 30, location.Y),
                AutoSize = true
            };

            // Store square reference for updating color
            trafficSquares[text] = square;

            parent.Controls.Add(square);
            parent.Controls.Add(label);
        }

        private async void startCycles(Panel mapPanel)
        {
            await Task.Delay(2000);

            if (isRushHour)
            {
                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Red;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Red;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Red;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Red;

                await Task.Delay(5000);
                startCycles(mapPanel);
            }

            else
            {
                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Yellow;

                await Task.Delay(5000);

                if (trafficSquares.ContainsKey("1500 East"))
                    trafficSquares["1500 East"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("1300 East"))
                    trafficSquares["1300 East"].BackColor = Color.Yellow;
                if (trafficSquares.ContainsKey("500 South"))
                    trafficSquares["500 South"].BackColor = Color.Green;
                if (trafficSquares.ContainsKey("700 South"))
                    trafficSquares["700 South"].BackColor = Color.Green;

                await Task.Delay(5000);
                startCycles(mapPanel);
            }

        }
    }
}
