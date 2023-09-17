namespace Program
{
    class Program
    {
        struct TestValue
        {
            public long nSum;
            public string sGender;
            public string sCase;

            public TestValue(long _nSum, string _sGender, string _sCase)
            {
                nSum = _nSum;
                sGender = _sGender;
                sCase = _sCase;
            }
        }

        public static void Main()
        {
            List<TestValue> testValues = new()
		    {
                new TestValue(12, "М", "И"),
                new TestValue(12345, "М", "Т"),
                new TestValue(16, "М", "И"),
                new TestValue(18, "М", "И"),
                new TestValue(225, "М", "И"),
                new TestValue(150, "М", "И"),
                new TestValue(1, "М", "И"),
                new TestValue(1, "Ж", "И"),
                new TestValue(0, "М", "И"),
                new TestValue(1105, "М", "И"),
                new TestValue(2066, "М", "И"),
                new TestValue(-23, "М", "И"),
                new TestValue(2, "М", "В"),
                new TestValue(2, "Ж", "В"),
                new TestValue(1_000, "М", "И"),
                new TestValue(1_000_001, "Ж", "И"),
                new TestValue(1_000_000_000, "М", "И"),
                new TestValue(2_000, "М", "И"),
                new TestValue(2_000_000, "М", "И"),
                new TestValue(2_000_000_000, "М", "Д"),
                new TestValue(301_002_341_123, "М", "И"),
                new TestValue(105, "М", "Д"),
                new TestValue(205, "М", "Д"),
                new TestValue(116, "М", "Д") ,
                new TestValue(360, "М", "Р"),
                new TestValue(458, "М", "В"),
                new TestValue(00805, "М", "Р"),
            };

            Parser parser = new(new NumberConverter());

            foreach (var testValue in testValues)
            {
                string convertNumber = parser.sumProp(testValue.nSum, testValue.sGender, testValue.sCase);
                Console.WriteLine($"Число: {testValue.nSum}\nПол: {testValue.sGender}\nПадеж: {testValue.sCase}\nРезультат: {convertNumber}\n");
            }

            // ИЗ ТЗ
            /*Console.WriteLine(parser.sumProp(31, "М", "Р"));
            Console.WriteLine(parser.sumProp(22, "С", "Т"));
            Console.WriteLine(parser.sumProp(154_323, "М", "И"));
            Console.WriteLine(parser.sumProp(154_323, "М", "Т"));*/
        }
    }
}



