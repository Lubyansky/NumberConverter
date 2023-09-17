using System.Text;

namespace Program
{
    public class Parser
    {
        private readonly NumberConverter numberConverter;

        public Parser(NumberConverter _numberConverter) {
            numberConverter = _numberConverter;
        }

        public string sumProp(long nSum, string sGender, string sCase)
        {
            var inputNumber = Math.Abs(nSum);

            if(inputNumber > 999_999_999_999)
            {
                throw new ArgumentException("Число равно триллиону и больше");
            }

            // преобразование числа в массив чисел в обратном порядке (12345 => [5, 4, 3, 2, 1])
            List<int> numberList = generateNumberList(inputNumber);

            // группировка элементов массива чисел в подмассивы по три элемента ([5, 4, 3, 2, 1] => [[5, 4, 3], [2, 1]])
            int[][] numberListGrouped = groupNumberList(numberList);

            // преобразование подмассивов в конечные числа для преобразования в строку ([[5, 4, 3], [2, 1]] => [12, 1000, 300, 40, 5])
            int[] numberListConverted = convertNumberList(numberListGrouped);

            StringBuilder resultString = new();

            resultString.Append(checkSign(nSum));

            for (int i = 0; i < numberListConverted.Length; i++)
            {
                int currNumber = numberListConverted[i];
                string convertNumber;

                // Особое склонение по роду у чисел "1" и "2" перед другими разрядами
                if((currNumber == 1 || currNumber == 2) && i < numberListConverted.Length - 1 && numberListConverted[i + 1] == 1000)
                {
                    convertNumber = numberConverter.declensionNumber(currNumber, "Ж", sCase);
                    resultString.Append(convertNumber + ' ');

                    continue;
                }
                else if ((currNumber == 1 || currNumber == 2) && i < numberListConverted.Length - 1 && numberListConverted[i + 1] > 1000)
                {
                    convertNumber = numberConverter.declensionNumber(currNumber, "М", sCase);
                    resultString.Append(convertNumber + ' ');

                    continue;
                }


                if(currNumber < 999)
                {
                    convertNumber = numberConverter.declensionNumber(currNumber, sGender, sCase);
                }
                else
                {
                    int prevNumber = numberListConverted[i - 1];
                    convertNumber = numberConverter.declensionBigNumber(currNumber, sCase, prevNumber);
                }

                resultString.Append(convertNumber + ' ');
            }

            return resultString.ToString();
        }

        private List<int> generateNumberList(long number)
        {
            List<int> numberList = new();

            if (number == 0)
            {
                numberList.Add(0);
            }

            while (number > 0)
            {
                int currNumber = (int)(number % 10);
                numberList.Add(currNumber);
                number /= 10;
            }

            return numberList;
        }

        private int[][] groupNumberList(List<int> numberList)
        {
            int i = 0;
            return numberList.GroupBy(s => i++ / 3).Select(s => s.ToArray()).ToArray();
        }

        private int[] convertNumberList(int[][] numberListGrouped)
        {
            List<int> resultList = new();

            int position = -1;
            foreach (var numberGroup in numberListGrouped)
            {
                position += numberGroup.Length;

                List<int> convertedNumberGroup = convertNumberGroup(numberGroup, position);

                if (convertedNumberGroup.Count() > 0)
                {
                    resultList.InsertRange(0, convertedNumberGroup);
                }
            }

            return resultList.ToArray();
        }

        private List<int> convertNumberGroup(int[] numberGroup, int position)
        {

            List<int> resultGroup = new();


            int onesPlace = 0;
            int tensPlace = 0;
            int hundredsPlace = 0;


            if (numberGroup.Length > 0)
            {
                onesPlace = numberGroup[0];
            }
            if(numberGroup.Length > 1)
            {
                tensPlace = numberGroup[1] * 10;
            } 
            if (numberGroup.Length > 2)
            {
                hundredsPlace = numberGroup[2] * 100;
            }

            
            if (hundredsPlace >= 100)
            {
                resultGroup.Add(hundredsPlace);
            }

            if (tensPlace >= 20)
            {
                resultGroup.Add(tensPlace);
            }
            else if (tensPlace == 10) {
                resultGroup.Add(tensPlace + onesPlace);
            }

            if (onesPlace > 0 && (tensPlace < 10 || tensPlace >= 20))
            {
                resultGroup.Add(onesPlace);
            }
            else if (onesPlace == 0 && position == 0)
            {
                resultGroup.Add(0);
            }


            if (position >= 3 && position < 6 && resultGroup.Count > 0)
            {
                resultGroup.Add(1000);
            }
            else if (position >= 6 && position < 9 && resultGroup.Count > 0)
            {
                resultGroup.Add(1_000_000);
            }
            else if (position >= 9 && position < 12 && resultGroup.Count > 0)
            {
                resultGroup.Add(1_000_000_000);
            }


            return resultGroup;
        }

        private string checkSign(long number)
        {
            return number >= 0 ? "" : "минус ";
        }
    }
}