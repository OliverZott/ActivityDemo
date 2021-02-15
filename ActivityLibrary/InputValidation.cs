namespace ActivityLibrary
{
    public class InputValidation
    {

        public static bool IsInputValid(string input, int listLength, bool upperBorderCallback = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if (!int.TryParse(input, out _))
            {
                return false;
            }

            if (int.Parse(input) < 1)
            {
                return false;
            }

            if (upperBorderCallback && int.Parse(input) > listLength)
            {
                return false;
            }

            return true;
        }
    }
}