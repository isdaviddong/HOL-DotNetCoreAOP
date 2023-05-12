using System;

namespace HOL_CoreAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立BMIProcessor物件
            BMIProcessor BMI = new BMIProcessor();
            BMI.Height = 170;
            BMI.Weight = 70;
            //計算BMI
            var ret = BMI.Calculate();
            //顯示
            Console.WriteLine($"BMI : {ret}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }

    public class BMIProcessor
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public Decimal BMI
        {
            get
            {
                return Calculate();
            }
        }

        //計算BMI
        public Decimal Calculate()
        {
            Decimal result = 0;

            Decimal height = (Decimal)Height / 100;
            result = Weight / (height * height);
            //希望每次被呼叫時，都寫一個LOG
            
            return result;
        }
    }

}
