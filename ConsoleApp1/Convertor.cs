using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public struct Convertor
    {
        public string _userNumber; 
        public string ConvertorToBinary(int userNumber)
        {
            _userNumber = Convert.ToString(userNumber, 2);
            return _userNumber;
        }
        public string ConvertorToOctal(int userNumber)
        {
            _userNumber = Convert.ToString(userNumber, 8);
            return _userNumber;
        }
        public string ConvertorToHexadecimal(int userNumber)
        {
            _userNumber = Convert.ToString(userNumber, 16);
            return _userNumber;
        }

        public void Show()
        {
            Console.WriteLine(_userNumber);
        }
    }
}
