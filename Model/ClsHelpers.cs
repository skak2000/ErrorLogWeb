/// Create by Skak2000
namespace Model
{
    public static class ClsHelpers
    {
        public static string ShortText(string input)
        {
            string respont = input;
            if (input != null && input.Length > 60)
            {
                respont = input.Substring(0, 60) + "...";
            }
            return respont;
        }
    }
}
