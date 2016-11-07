namespace ConwaysGameLife
{
    public interface ILifeRule
    {
        int GetCellStatus(int neighbors, int currentStatus);
        string description { get; }
    }

    class ClassicConwaysRules : ILifeRule
    {
        public int GetCellStatus(int neighbors, int currentStatus)
        {
            // 0 -no cell
            // 1 - new cell
            // 2 - old cell

            int status;

            if (currentStatus == 0)
            {
                status = (neighbors == 3) ? 1 : 0;
            }
            else
            {
                status = (neighbors == 2 || neighbors == 3) ? 2 : 0;
            }

            return status;
        }

        public string description => "Classic Conway's rules: B3/S23";

        public override string ToString()
        {
            return description;
        }
    }

    class MyLifeMyRules : ILifeRule
    {
        public int GetCellStatus(int neighbors, int currentStatus)
        {
            // 0 -no cell
            // 1 - new cell
            // 2 - old cell

            int status;

            if (currentStatus == 0)
            {
                status = (neighbors == 3) ? 1 : 0;
            }
            else
            {
                status = (neighbors == 3 || neighbors == 5) ? 2 : 0;
            }

            return status;
        }

        public string description => "Alternative rules: B3/S35";

        public override string ToString()
        {
            return description;
        }
    }

    class UserLifeRules : ILifeRule
    {
        string m_description = "New rules";

        public UserLifeRules()
        {
            newCellNeighbors1 = 3;
            newCellSign1 = 0;
            newCellOrEnable = false;
            newCellNeighbors2 = 0;
            newCellSign2 = 0;

            cellGoOnNeighbors1 = 2;
            cellGoOnSign1 = 0;
            cellGoOnOrEnable = true;
            cellGoOnNeighbors2 = 3;
            cellGoOnSign2 = 0;
        }

        public UserLifeRules(string d)
        {
            m_description = d;

            newCellNeighbors1 = 3;
            newCellSign1 = 0;
            newCellOrEnable = false;
            newCellNeighbors2 = 0;
            newCellSign2 = 0;

            cellGoOnNeighbors1 = 2;
            cellGoOnSign1 = 0;
            cellGoOnOrEnable = true;
            cellGoOnNeighbors2 = 3;
            cellGoOnSign2 = 0;
        }

        private bool Condition(int Sign, int number1, int number2)
        {
            // 0 =, 1 >, 2 <
            bool result = false;

            if (Sign == 0)
                result = (number1 == number2);
            else if (Sign == 1)
                result = (number1 > number2);
            else if (Sign == 2)
                result = (number1 < number2);

            return result;
        }

        public int newCellNeighbors1 { get; set; }
        public int newCellNeighbors2 { get; set; }
        public int newCellSign1 { get; set; } // 0 =, 1 >, 2 <
        public int newCellSign2 { get; set; } // 0 =, 1 >, 2 <
        public bool newCellOrEnable { get; set; }

        public int cellGoOnNeighbors1 { get; set; }
        public int cellGoOnNeighbors2 { get; set; }
        public int cellGoOnSign1 { get; set; } // 0 =, 1 >, 2 <
        public int cellGoOnSign2 { get; set; } // 0 =, 1 >, 2 <
        public bool cellGoOnOrEnable { get; set; }

        public int GetCellStatus(int neighbors, int currentStatus)
        {
            int status;

            if (currentStatus == 0)
            {
                if (newCellOrEnable)
                {
                    status = (Condition(newCellSign1, neighbors, newCellNeighbors1) || Condition(newCellSign2, neighbors, newCellNeighbors2)) ? 1 : 0;
                }
                else
                {
                    status = (Condition(newCellSign1, neighbors, newCellNeighbors1)) ? 1 : 0;
                }
            }
            else
            {
                if (cellGoOnOrEnable)
                {
                    status = (Condition(cellGoOnSign1, neighbors, cellGoOnNeighbors1) || Condition(cellGoOnSign2, neighbors, cellGoOnNeighbors2)) ? 2 : 0;
                }
                else
                {
                    status = (Condition(cellGoOnSign1, neighbors, cellGoOnNeighbors1)) ? 2 : 0;
                }
            }

            return status;
        }

        public string description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public override string ToString()
        {
            return description;
        }
    }
}
