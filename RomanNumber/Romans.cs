public class RomanNumber
{
    protected string GetRomanYekan(int givenNumber)
    {
        string romanNumberI = "I";
        string romanNumberV = "V";
        string romanNumberX = "X";
        string romanNumber = null;
        if (givenNumber == 1)
        {

            romanNumber = romanNumberI;
        }
        if (givenNumber == 2)
        {
            romanNumber = string.Concat(romanNumberI, romanNumberI);
        }
        if (givenNumber == 3)
        {
            romanNumber = string.Concat(romanNumberI, romanNumberI, romanNumberI);

        }
        if (givenNumber == 4)
        {
            romanNumber = string.Concat(romanNumberI, romanNumberV);
        }
        if (givenNumber == 5)
        {
            romanNumber = string.Concat(romanNumberV);
        }
        if (givenNumber == 6)
        {
            romanNumber = string.Concat(romanNumberV, romanNumberI);
        }
        if (givenNumber == 7)
        {
            romanNumber = string.Concat(romanNumberV, romanNumberI, romanNumberI);
        }
        if (givenNumber == 8)
        {
            romanNumber = string.Concat(romanNumberV, romanNumberI, romanNumberI, romanNumberI);
        }
        if (givenNumber == 9)
        {
            romanNumber = string.Concat(romanNumberI, romanNumberX);
        }
        return romanNumber;
    }


    protected string GetRomanDahgan(int givenNumebr)
    {
        string romanNumber = string.Empty;
        string romanNumberX = "X";
        string romanNumberL = "L";
        string romanNumberC = "C";
        if (givenNumebr == 1)
        {
            romanNumber = romanNumberX;
        }
        if (givenNumebr == 2)
        {
            romanNumber = string.Concat(romanNumberX, romanNumberX);
        }
        if (givenNumebr == 3)
        {
            romanNumber = string.Concat(romanNumberX, romanNumberX, romanNumberX);
        }
        if (givenNumebr == 4)
        {
            romanNumber = string.Concat(romanNumberX, romanNumberL);
        }
        if (givenNumebr == 5)
        {
            romanNumber = romanNumberL;
        }
        if (givenNumebr == 6)
        {
            romanNumber = string.Concat(romanNumberL, romanNumberX);
        }
        if (givenNumebr == 7)
        {
            romanNumber = string.Concat(romanNumberL, romanNumberX, romanNumberX);
        }
        if (givenNumebr == 8)
        {
            romanNumber = string.Concat(romanNumberL, romanNumberX, romanNumberX, romanNumberX);
        }
        if (givenNumebr == 9)
        {
            romanNumber = string.Concat(romanNumberX, romanNumberC);
        }
        return romanNumber;
    }

    protected string GetRomanSadgan(int givenNumebr)
    {
        string romanNumber = string.Empty;
        string romanNumberD = "D";
        string romanNumberM = "M";
        string romanNumberC = "C";
        if (givenNumebr == 1)
        {
            romanNumber = romanNumberC;
        }
        if (givenNumebr == 2)
        {
            romanNumber = string.Concat(romanNumberC, romanNumberC);
        }
        if (givenNumebr == 3)
        {
            romanNumber = string.Concat(romanNumberC, romanNumberC, romanNumberC);
        }
        if (givenNumebr == 4)
        {
            romanNumber = string.Concat(romanNumberC, romanNumberD);
        }
        if (givenNumebr == 5)
        {
            romanNumber = romanNumberD;
        }
        if (givenNumebr == 6)
        {
            romanNumber = string.Concat(romanNumberD, romanNumberC);
        }
        if (givenNumebr == 7)
        {
            romanNumber = string.Concat(romanNumberD, romanNumberC, romanNumberC);
        }
        if (givenNumebr == 8)
        {
            romanNumber = string.Concat(romanNumberD, romanNumberC, romanNumberC, romanNumberC);
        }
        if (givenNumebr == 9)
        {
            romanNumber = string.Concat(romanNumberC, romanNumberM);
        }
        return romanNumber;
    }


    public string GetRomanNumber(int givenNumebr)
    {
        string romanNumber = string.Empty;
        int sadgan = givenNumebr / 100;
        int sad = givenNumebr % 100;
        int dahgan = (sad / 10);
        int yekan = givenNumebr % 10;

        romanNumber = string.Concat(GetRomanSadgan(sadgan), GetRomanDahgan(dahgan), GetRomanYekan(yekan));
        return romanNumber;
    }
}