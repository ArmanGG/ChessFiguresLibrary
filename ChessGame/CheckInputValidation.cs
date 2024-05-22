public class CheckInputValidation
{
    public int x { get; }
    public char y {  get; }
    public FiguresColor color { get; }
    public bool Valid { get; }
    public  CheckInputValidation(string a, string b="WK")
    {
        if(Check(a, b))
        {
             x = a[1] - 48;
             y = a[0];
               Valid = true;
            if (b[0] == 'W')
            {
                color=FiguresColor.W;
            }else
             color=FiguresColor.B;
        }

    }
    static bool Check(string s1, string s3)
    {
        string letters = "";
        string numbers = "";
        string colors = "";
        string figures = "";
        foreach (char c in s1)
        {
            if (char.IsLetter(c))
            {
                letters += c;
            }
            else if (char.IsDigit(c))
            {
                numbers += c;
            }
        }

        bool b = false;
        if (int.TryParse(numbers, out int result1) && char.TryParse(letters, out char result2) && s3.Length == 2)
        {

            foreach (FiguresSymbol figure in Enum.GetValues(typeof(FiguresSymbol)))
            {


                if (figure.ToString()[0] == s3[1])
                {
                    b = true;
                }

            }
            if ((result1 >= 1 && result1 < 9 && result2 >= 'A' && result2 <= 'H' && b == true) && s3[0] == 'W' || s3[0] == 'B')
            {
                b = true;
            }
            else b = false;
            if (!b)
            {
              
                b = false;
            }
        }
        else
        {
          
            b = false;
        }
        return b;
    }
}
