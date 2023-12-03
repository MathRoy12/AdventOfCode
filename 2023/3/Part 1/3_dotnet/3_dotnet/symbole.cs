namespace _3_dotnet;

public struct symbole
{
    public int x;
    public int y;
    public char symbol;

    public override string ToString()
    {
        return symbol + " (" + x + ", " + y + ")";
    }
}