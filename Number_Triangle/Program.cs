int rows = 5;
string[] nbrs = { "1", "2", "3" };

int nbrsCnt = 0;
for (int i = 1; i <= rows; i++)
{
    string strOut = "";
    for (int i2 = 1; i2 <= i; i2++)
    {
        strOut += nbrs[nbrsCnt];
        nbrsCnt = (nbrsCnt + 1) % nbrs.Length;
    }
    Console.WriteLine(strOut);
}