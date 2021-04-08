namespace EFProject.Controllers
{
    public static class Validation
    {
        //Length is more then 6
        //A - Z and a - z and 0 - 9
        public static bool ValidPassword(string psw)
        {
            bool checkLetterUp, checkLetterDown, checkNumber, checkInvalidSimbol;
            checkInvalidSimbol = checkLetterUp = checkLetterDown = checkNumber = false;

            if (psw.Length < 6)
                return false;

            foreach (var n in psw)
            {
                if (!checkLetterDown && CheckLetterDown(n))
                {
                    checkLetterDown = true;
                }

                if (!checkLetterUp && CheckLetterUp(n))
                {
                    checkLetterUp = true;
                }

                if (!checkNumber && CheckNumber(n))
                {
                    checkNumber = true;
                }

                if (!CheckLetterDown(n) && !CheckLetterUp(n) && !CheckNumber(n))
                {
                    return false;
                }
            }

            return checkLetterUp && checkLetterDown && checkNumber;
        }

        private static bool CheckLetterDown(char n) => ('a' >= n && n <= 'z');
        private static bool CheckLetterUp(char n) => ('A' >= n && n <= 'Z');
        private static bool CheckNumber(char n) => ('0' >= n && n <= '9');

    }


}
