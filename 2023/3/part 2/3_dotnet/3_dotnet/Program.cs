using System.Text.RegularExpressions;

StreamReader sr = new StreamReader("input.txt");

string input = sr.ReadToEnd();

string[] lines = input.Split("\n");

int sum = 0;
Regex rgx = new Regex("[0-9]");


for (int i = 0; i < lines.Length; i++)
{
    for (int j = 0; j < lines[i].Length - 1; j++)
    {
        if (lines[i][j] == '*')
        {
            int lastNum = 0;
            List<int> lstInt = new List<int>();
            
            if (rgx.IsMatch(lines[i != 0 ? i - 1 : 0][j != 0 ? j - 1 : 0].ToString()) && i != 0 && j != 0)
            {
                int x = j - 1;
                int y = i - 1;
                string num = lines[i - 1][j - 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j - 1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i - 1][j].ToString()))
            {
                int x = j;
                int y = i - 1;
                string num = lines[i - 1][j].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i - 1][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i - 1;
                string num = lines[i - 1][j + 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i][j - 1].ToString()))
            {
                int x = j - 1;
                int y = i;
                string num = lines[i][j - 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j -1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i;
                string num = lines[i][j + 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i + 1][j - 1].ToString()))
            {
                int x = j - 1;
                int y = i + 1;
                string num = lines[i + 1][j - 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j -1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i + 1][j].ToString()))
            {
                int x = j;
                int y = i + 1;
                string num = lines[i + 1][j].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (rgx.IsMatch(lines[i + 1][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i + 1;
                string num = lines[i + 1][j + 1].ToString();

                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    lstInt.Add(int.Parse(num));
                    lastNum = int.Parse(num);
                }
            }

            if (lstInt.Count == 2)
            {
                sum += lstInt[0] * lstInt[1];
            }
        }
    }
}

Console.WriteLine(sum);

sr.Close();