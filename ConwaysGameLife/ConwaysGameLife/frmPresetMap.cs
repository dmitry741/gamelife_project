using System;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    public partial class frmPresetMap : Form
    {
        public frmPresetMap()
        {
            InitializeComponent();
        }

        int m_selectedIndex = 0;

        #region === public ===

        public int[,] map
        {
            get
            {
                AbstractPresetMap apm = listBox1.SelectedItem as AbstractPresetMap;
                return apm.map;
            }
        }

        #endregion

        private void frmPresetMap_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Glider());
            listBox1.Items.Add(new Pentadecatlon());
            listBox1.Items.Add(new Eight());
            listBox1.Items.Add(new Spinner());
            listBox1.Items.Add(new Baken());
            listBox1.Items.Add(new Clock());
            listBox1.Items.Add(new SpaceShuttle());
            listBox1.Items.Add(new Stick());
            listBox1.Items.Add(new Oscillator());
            listBox1.Items.Add(new Pulsar());
            listBox1.Items.Add(new ToggleSwitch());
            listBox1.Items.Add(new PingPong());
            listBox1.Items.Add(new GliderRifle());
            listBox1.Items.Add(new RifleCreation());
            listBox1.Items.Add(new Pentamimo());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            m_selectedIndex = listBox1.SelectedIndex;
        }
    }

    abstract class AbstractPresetMap
    {
        string m_description = "Abstract Preset Map";

        public AbstractPresetMap(string desc)
        {
            m_description = desc;
        }

        protected int[,] Transform(int[,] m)
        {
            int xBound = m.GetUpperBound(0) + 1;
            int yBound = m.GetUpperBound(1) + 1;

            int[,] map = new int[yBound, xBound];

            for (int i = 0; i < xBound; i++)
            {
                for (int j = 0; j < yBound; j++)
                {
                    map[j, i] = m[i, j];
                }
            }

            return map;
        }

        public int width
        {
            get
            {
                int[,] m = map;
                return (m != null) ? m.GetUpperBound(0) + 1 : 0;
            }
        }

        public int height
        {
            get
            {
                int[,] m = map;
                return (m != null) ? m.GetUpperBound(1) + 1 : 0;
            }
        }

        abstract public int[,] map { get; }

        public string description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public override string ToString()
        {
            return m_description;
        }
    }

    class Glider : AbstractPresetMap
    {
        public Glider() : base("Glider") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 1, 0 },
                                { 0, 0, 1 },
                                { 1, 1, 1 } };

                return Transform(map);
            }
        }
    }

    class Pentadecatlon : AbstractPresetMap
    {
        public Pentadecatlon() : base("Pentadecatlon") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                                { 1, 1, 0, 1, 1, 1, 1, 0, 1, 1 },
                                { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class Eight : AbstractPresetMap
    {
        public Eight() : base("Eight") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 1, 1, 1, 0, 0, 0 },
                                { 1, 1, 1, 0, 0, 0 },
                                { 1, 1, 1, 0, 0, 0 },
                                { 0, 0, 0, 1, 1, 1 },
                                { 0, 0, 0, 1, 1, 1 },
                                { 0, 0, 0, 1, 1, 1 } };

                return Transform(map);
            }
        }
    }

    class Spinner : AbstractPresetMap
    {
        public Spinner() : base("Spinner") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
                                { 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0 },
                                { 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0 },
                                { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1 },
                                { 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1 },
                                { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class Baken : AbstractPresetMap
    {
        public Baken() : base("Baken") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 1, 1, 0, 0 },
                                { 1, 1, 0, 0 },
                                { 0, 0, 1, 1 },
                                { 0, 0, 1, 1 } };

                return Transform(map);
            }
        }
    }

    class Clock : AbstractPresetMap
    {
        public Clock() : base("Clock") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 1, 0, 0 },
                                { 0, 1, 0, 1 },
                                { 1, 0, 1, 0 },
                                { 0, 0, 1, 0 } };

                return Transform(map);
            }
        }
    }

    class SpaceShuttle : AbstractPresetMap
    {
        public SpaceShuttle() : base("Space Shuttle") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 1, 0 },
                                { 0, 0, 0, 0, 1 },
                                { 1, 0, 0, 0, 1 },
                                { 0, 1, 1, 1, 1 } };

                return Transform(map);
            }
        }
    }

    class Stick : AbstractPresetMap
    {
        public Stick() : base("Stick") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class Oscillator : AbstractPresetMap
    {
        public Oscillator() : base("Herz's Oscillator") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1 },
                                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1 },
                                { 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0 },
                                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1 },
                                { 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class Pulsar : AbstractPresetMap
    {
        public Pulsar() : base("Pulsar СР 48-56-72") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class ToggleSwitch : AbstractPresetMap
    {
        public ToggleSwitch() : base("Toggle switch") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 1, 1, 1, 0, 1, 1, 1 },
                                { 1, 0, 0, 0, 0, 0, 1 },
                                { 0, 0, 1, 0, 1, 0, 0 },
                                { 0, 1, 1, 0, 1, 1, 0 },
                                { 1, 0, 0, 0, 0, 0, 1 } };

                return Transform(map);
            }
        }
    }

    class PingPong : AbstractPresetMap
    {
        public PingPong() : base("Ping-pong") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class GliderRifle : AbstractPresetMap
    {
        public GliderRifle() : base("Glider Rifle") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
                                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }

    class Pentamimo : AbstractPresetMap
    {
        public Pentamimo() : base("Pentamino: long life") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 1,  1},
                                { 1, 1, 0 },
                                { 0, 1, 0 } };

                return Transform(map);
            }
        }
    }

    class RifleCreation : AbstractPresetMap
    {
        public RifleCreation() : base("Creation of glider rifle") { }

        public override int[,] map
        {
            get
            {
                int[,] map = {  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                                { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }
}
