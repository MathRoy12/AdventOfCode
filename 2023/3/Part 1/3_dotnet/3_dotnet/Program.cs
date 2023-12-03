using System.Text.RegularExpressions;

StreamReader sr = new StreamReader("input.txt");

string input = sr.ReadToEnd();

string[] lines = input.Split("\n");

int sum = 0;

Regex rgx = new Regex("[^0-9.]");
Regex rgx2 = new Regex("[0-9]");


for (int i = 0; i < lines.Length; i++)
{
    for (int j = 0; j < lines[i].Length - 1; j++)
    {
        int lastNum = 0;
        if (rgx.IsMatch(lines[i][j].ToString()))
        {
            if (rgx2.IsMatch(lines[i != 0 ? i - 1 : 0][j != 0 ? j - 1 : 0].ToString()) && i != 0 && j != 0)
            {
                int x = j - 1;
                int y = i - 1;
                string num = lines[i - 1][j - 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j - 1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i - 1][j].ToString()))
            {
                int x = j;
                int y = i - 1;
                string num = lines[i - 1][j].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i - 1][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i - 1;
                string num = lines[i - 1][j + 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i][j - 1].ToString()))
            {
                int x = j - 1;
                int y = i;
                string num = lines[i][j - 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j -1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i;
                string num = lines[i][j + 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i + 1][j - 1].ToString()))
            {
                int x = j - 1;
                int y = i + 1;
                string num = lines[i + 1][j - 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j -1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i + 1][j].ToString()))
            {
                int x = j;
                int y = i + 1;
                string num = lines[i + 1][j].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }

            if (rgx2.IsMatch(lines[i + 1][j + 1].ToString()))
            {
                int x = j + 1;
                int y = i + 1;
                string num = lines[i + 1][j + 1].ToString();

                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x--;
                    if (x < 0 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num = lines[y][x].ToString() + num;
                }

                x = j + 1;
                while (rgx2.IsMatch(lines[y][x].ToString()))
                {
                    x++;
                    if (x > lines[y].Length - 1 || !rgx2.IsMatch(lines[y][x].ToString()))
                        break;
                    num += lines[y][x].ToString();
                }

                if (int.Parse(num) != lastNum)
                {
                    sum += int.Parse(num);
                    lastNum = int.Parse(num);
                }
            }
        }
    }
}

Console.WriteLine(sum);

sr.Close();