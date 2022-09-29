namespace NetCore_2.Models;
public class StringProcess
{
    public string RemoveRemainingWhiteSpace(string strInput)
    {
        string strResult = "";
        strInput = strInput.Trim();
        while(strInput.IndexOf("  ")>0)
        {
            strInput = strInput.Replace("  "," ");
        }
        strResult = strInput;
        return strResult;

    }
    public string LowerToUpper(string strInput)
    {   
        string strResult = "";
        strInput = strInput.ToUpper();
        strResult = strInput;
        return strResult;
    }
}