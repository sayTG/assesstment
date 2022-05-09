namespace CAssessment2.Services
{
    public class CorrectionService : ICorrectionService
    {
        public int MyAtoi(string str)
        {
            string trimStr = str.Trim();
            if (int.TryParse(str, out int result))
            {
                return result;
            }
            else
            {
                if (double.TryParse(str, out double d))
                {
                    if (d < int.MinValue)
                        return int.MinValue;
                    else if (d > int.MaxValue)
                        return int.MaxValue;
                    else if ((d % 1) != 0)
                        return (int)d;
                }
                if (char.IsLetter(str[0]))
                    return 0;
                else if(char.IsPunctuation(trimStr[0]))
                {
                    if (str.Length == 1)
                        return 0;
                    if (!char.IsDigit(trimStr[1]))
                        return 0;
                    else
                    {
                        string newR = "";
                        foreach(char c in trimStr)
                        {
                            if (char.IsLetter(c))
                            {
                                int.TryParse(newR, out int output);
                                return output;
                            }
                            newR += c;
                        }
                    }
                }
                else
                {
                    var splitStr = str.Split(' ');
                    foreach (var s in splitStr)
                    {
                        if (int.TryParse(s, out int output))
                        {
                            return output;
                        }
                    }
                }
            }
            return 0;

        }
    }
}
