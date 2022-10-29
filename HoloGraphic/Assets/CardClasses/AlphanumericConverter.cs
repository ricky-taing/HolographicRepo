public class AlphanumericConverter
{
    public void alphanumericCheck(string valueToConvert)
    {
        //check if alphanumeric, and handle cases
    }
    public int alphanumericToNumeric(string alphanumericString)
    {
        switch (alphanumericString.ToLower())
        {
            case "instant":
                {
                    return 1;
                }
            case "single":
                {
                    return 1;
                }
            default:
                return 0;
        }
    }
}
