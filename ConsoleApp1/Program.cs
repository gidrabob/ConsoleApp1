
using System.Transactions;

namespace Lesson
{
        
    public class Programm()
    {
        public static void Main()
        {
            //Створіть структуру «Десяткове число». 
            //Визначте в ній необхідні поля і методи.Реалізуйте наступну функціональність:
            //■ Перевести число у двійкову систему; 
            //■ Перевести число у вісімкову систему; 
            //■ Перевести число у шістнадцяткову систему.

            //Console.WriteLine($"Enter nubmer you wanna convert:");
            //int numberToConvert = Convert.ToInt32( Console.ReadLine() );

            //Convertor binaryNumber = new Convertor();
            //binaryNumber.ConvertorToBinary(numberToConvert);
            //Console.WriteLine("Binary");
            //binaryNumber.Show();

            //Convertor hexadecimalNumber = new Convertor();
            //hexadecimalNumber.ConvertorToHexadecimal(numberToConvert);
            //Console.WriteLine("Hexadecimal");
            //hexadecimalNumber.Show();

            //Convertor octalNumber = new Convertor();
            //octalNumber.ConvertorToOctal(numberToConvert);
            //Console.WriteLine("Octal");
            //octalNumber.Show();

            //Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима. 
            //У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо) і поле для зберігання копійок
            //(центи, євроценти, копійки тощо) 
            //Реалізувати методи виведення суми на екран, задання значень частин 
            //(цілої частини грошей та копійок).
            //На базі класу Money створити клас Product для роботи з продуктом або товаром. 
            //Реалізувати метод, який дозволяє зменшити ціну на задане число. 
            //Для кожного з класів реалізувати необхідні методи і поля. 
            //Додати iнкапсуляцiю до полiв та методiв якщо треба.

            //Console.WriteLine("Enter the integer part cost you product:");
            //int integerPart = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the coin part cost you product");
            //int coinPart = Convert.ToInt32(Console.ReadLine());

            //Money firstMoneyCurrent = new Money
            //{
            //    IntegerPart = integerPart,
            //    CoinPart = coinPart
            //};
            //firstMoneyCurrent.ShowMoney();
            //Console.WriteLine("Enter the product name:");
            //string? productName = Console.ReadLine();

            //Product firstProduct = new Product
            //{
            //    ProductPrice = firstMoneyCurrent,
            //    ProductName = productName
            //};
            //firstProduct.ShowProductAndPrice();
            //firstProduct.DiscountProduct(10, 20);
            //Console.WriteLine("Price with discount");
            //firstProduct.ShowProductAndPrice();



            //Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». 
            //За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики. 
            //Реалізуйте для кожного з класів методи:
            //■ Sound — видає звук музичного інструменту (пишемо текстом у консоль); 
            //■ Show — відображає назву музичного інструменту;            
            //■ Desc — відображає опис музичного інструменту; 
            //■ History — відображає історію створення музичного інструменту.
            //Додати iнкапсуляцiю до полiв та методiв якщо треба.

            //Console.WriteLine();
            //Console.ReadLine();

            //Violin violinInstument = new Violin("violin", "bowed musical instrument with 4 strings","play violin", "The appearance of the cello dates back to the late 15th and early 16th centuries.");
            //violinInstument.Show();
            //violinInstument.Desc();
            //violinInstument.Sound();
            //violinInstument.History();
        }
    }
}
