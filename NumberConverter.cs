namespace Program
{
	public class NumberConverter
	{
		public NumberConverter() { }

        private readonly Dictionary<int, string> numbers = new()
		{
			{ 5, "пят"},
			{ 6, "шест"},
			{ 7, "сем"},
			{ 8, "вос"},
			{ 9, "девят"},
			{ 10, "десят"},
			{ 11, "одиннадцат"},
			{ 12, "двенадцат"},
			{ 13, "тринадцат"},
			{ 14, "четырнадцат"},
			{ 15, "пятнадцат"},
			{ 16, "шестнадцат"},
			{ 17, "семнадцат"},
			{ 18, "восемнадцат"},
			{ 19, "девятнадцат"},
			{ 20, "двадцат"},
			{ 30, "тридцат"},
			{ 40, "сорок"},
			{ 90, "девяност"},
			{ 100, "ст"},
			{ 1000, "тысяч" },
			{ 1_000_000, "миллион" },
			{ 1_000_000_000, "миллиард" },
		};

		
		public string declensionNumber(int number, string gender, string _case)
		{
			if (number == 0)
			{
				return _case switch
				{
					"И" => "ноль",
					"Р" => "ноля",
					"Д" => "нолю",
					"В" => "ноль",
					"Т" => "нолем",
					"П" => "ноле",
					_ => "",
				};
			}
			else if (number == 1)
			{
				return _case switch
				{
					"И" => gender switch
					{
						"М" => "один",
						"Ж" => "одна",
						"С" => "одно",
						_ => "",
					},
					"Р" => gender switch
					{
						"М" => "одного",
						"Ж" => "одной",
						"С" => "одного",
						_ => "",
					},
					"Д" => gender switch
					{
						"М" => "одному",
						"Ж" => "одной",
						"С" => "одному",
						_ => "",
					},
					"В" => gender switch
					{
						"М" => "один",
						"Ж" => "одну",
						"С" => "одно",
						_ => "",
					},
					"Т" => gender switch
					{
						"М" => "одним",
						"Ж" => "одной",
						"С" => "одним",
						_ => "",
					},
					"П" => gender switch
					{
						"М" => "одном",
						"Ж" => "одной",
						"С" => "одном",
						_ => "",
					},
					_ => "",
				};
			}
			else if (number == 2)
			{
				return _case switch
				{
					"И" => gender switch
					{
						"М" => "два",
						"Ж" => "две",
						"С" => "два",
						_ => "",
					},
					"Р" => "двух",
					"Д" => "двум",
					"В" => gender switch
					{
						"М" => "два",
						"Ж" => "две",
						"С" => "два",
						_ => "",
					},
					"Т" => "двумя",
					"П" => "двух",
					_ => "",
				};
			}
			else if (number == 3)
			{
				return _case switch
				{
					"И" => "три",
					"Р" => "трех",
					"Д" => "трем",
					"В" => "три",
					"Т" => "тремя",
					"П" => "трех",
					_ => "",
				};
			}
			else if (number == 4)
			{
				return _case switch
				{
					"И" => "четыре",
					"Р" => "четырех",
					"Д" => "четырем",
					"В" => "четыре",
					"Т" => "четырьмя",
					"П" => "четырех",
					_ => "",
				};
			}
			else if (number == 8)
			{
				return _case switch
				{
					"И" => numbers[8] + "емь",
					"Р" => numbers[8] + "ьми",
					"Д" => numbers[8] + "ьми",
					"В" => numbers[8] + "емь",
					"Т" => numbers[8] + "ьмью",
					"П" => numbers[8] + "ьми",
					_ => "",
				};
			}
			else if (number >= 5 && number <= 20 || number == 30)
			{
				return _case switch
				{
					"И" => numbers[number] + "ь",
					"Р" => numbers[number] + "и",
					"Д" => numbers[number] + "и",
					"В" => numbers[number] + "ь",
					"Т" => numbers[number] + "ью",
					"П" => numbers[number] + "и",
					_ => "",
				};
			}
			else if (number == 40)
			{
				return _case switch
				{
					"И" => numbers[number] + "",
					"Р" => numbers[number] + "а",
					"Д" => numbers[number] + "а",
					"В" => numbers[number] + "",
					"Т" => numbers[number] + "а",
					"П" => numbers[number] + "а",
					_ => "",
				};
			}
			else if (number == 50 || number == 60 || number == 70 || number == 80)
			{
				return _case switch
				{
					"И" => declensionNumber(number / 10, gender, _case) + numbers[10],
					"Р" => declensionNumber(number / 10, gender, _case) + numbers[10] + "и",
					"Д" => declensionNumber(number / 10, gender, _case) + numbers[10] + "и",
					"В" => declensionNumber(number / 10, gender, _case) + numbers[10],
					"Т" => declensionNumber(number / 10, gender, _case) + numbers[10] + "ью",
					"П" => declensionNumber(number / 10, gender, _case) + numbers[10] + "и",
					_ => "",
				};
			}
			else if (number == 90 || number == 100)
			{
				return _case switch
				{
					"И" => numbers[number] + "о",
					"Р" => numbers[number] + "а",
					"Д" => numbers[number] + "а",
					"В" => numbers[number] + "о",
					"Т" => numbers[number] + "а",
					"П" => numbers[number] + "а",
					_ => "",
				};
			}
			else if (number == 200)
			{
				return _case switch
				{
					"И" => "двести",
					"Р" => "двухсот",
					"Д" => "двумстам",
					"В" => "двести",
					"Т" => "двумястами",
					"П" => "двухстах",
					_ => "",
				};
			}
			else if (number == 300 || number == 400)
			{
				return _case switch
				{
					"И" => declensionNumber(number / 100, gender, _case) + "ста",
					"Р" => declensionNumber(number / 100, gender, _case) + "сот",
					"Д" => declensionNumber(number / 100, gender, _case) + "стам",
					"В" => declensionNumber(number / 100, gender, _case) + "ста",
					"Т" => declensionNumber(number / 100, gender, _case) + "стами",
					"П" => declensionNumber(number / 100, gender, _case) + "стах",
					_ => "",
				};
			}
			else if (number == 500 || number == 600 || number == 700 || number == 800 || number == 900)
			{
				return _case switch
				{
					"И" => declensionNumber(number / 100, gender, _case) + "сот",
					"Р" => declensionNumber(number / 100, gender, _case) + "сот",
					"Д" => declensionNumber(number / 100, gender, _case) + "стам",
					"В" => declensionNumber(number / 100, gender, _case) + "сот",
					"Т" => declensionNumber(number / 100, gender, _case) + "стами",
					"П" => declensionNumber(number / 100, gender, _case) + "стах",
					_ => "",
				};
			}
			else return "";
		}

		public string declensionBigNumber(int number, string _case, int determinant)
		{
			return number switch
			{
				1000 => thousandsDeclension(_case, determinant),
				1_000_000 => millionsDeclension(_case, determinant),
				1_000_000_000 => billionsDeclension(_case, determinant),
				_ => "",
			};
		}

		private string thousandsDeclension(string _case, int determinant)
		{
			if (determinant == 1)
			{
				return _case switch
				{
					"И" => numbers[1000] + "а",
					"Р" => numbers[1000] + "и",
					"Д" => numbers[1000] + "е",
					"В" => numbers[1000] + "у",
					"Т" => numbers[1000] + "ей",
					"П" => numbers[1000] + "е",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"И" => numbers[1000] + "и",
					"Р" => numbers[1000],
					"Д" => numbers[1000] + "ам",
					"В" => numbers[1000] + "и",
					"Т" => numbers[1000] + "ами",
					"П" => numbers[1000] + "ах",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"И" => numbers[1000],
					"Р" => numbers[1000],
					"Д" => numbers[1000] + "ам",
					"В" => numbers[1000],
					"Т" => numbers[1000] + "ами",
					"П" => numbers[1000] + "ах",
					_ => "",
				};
			}
		}

		private string millionsDeclension(string _case, int determinant)
		{
			if (determinant == 1)
			{
				return _case switch
				{
					"И" => numbers[1_000_000],
					"Р" => numbers[1_000_000] + "а",
					"Д" => numbers[1_000_000] + "у",
					"В" => numbers[1_000_000],
					"Т" => numbers[1_000_000] + "ом",
					"П" => numbers[1_000_000] + "е",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"И" => numbers[1_000_000] + "а",
					"Р" => numbers[1_000_000] + "ов",
					"Д" => numbers[1_000_000] + "ам",
					"В" => numbers[1_000_000] + "а",
					"Т" => numbers[1_000_000] + "ами",
					"П" => numbers[1_000_000] + "ах",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"И" => numbers[1_000_000] + "ов",
					"Р" => numbers[1_000_000] + "ов",
					"Д" => numbers[1_000_000] + "ам",
					"В" => numbers[1_000_000] + "ов",
					"Т" => numbers[1_000_000] + "ами",
					"П" => numbers[1_000_000] + "ах",
					_ => "",
				};
			}
		}

		private string billionsDeclension(string _case, int determinant)
		{
			if (determinant == 1)
			{
				return _case switch
				{
					"И" => numbers[1_000_000_000],
					"Р" => numbers[1_000_000_000] + "а",
					"Д" => numbers[1_000_000_000] + "у",
					"В" => numbers[1_000_000_000],
					"Т" => numbers[1_000_000_000] + "ом",
					"П" => numbers[1_000_000_000] + "е",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"И" => numbers[1_000_000_000] + "а",
					"Р" => numbers[1_000_000_000] + "ов",
					"Д" => numbers[1_000_000_000] + "ам",
					"В" => numbers[1_000_000_000] + "а",
					"Т" => numbers[1_000_000_000] + "ами",
					"П" => numbers[1_000_000_000] + "ах",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"И" => numbers[1_000_000_000] + "ов",
					"Р" => numbers[1_000_000_000] + "ов",
					"Д" => numbers[1_000_000_000] + "ам",
					"В" => numbers[1_000_000_000] + "ов",
					"Т" => numbers[1_000_000_000] + "ами",
					"П" => numbers[1_000_000_000] + "ах",
					_ => "",
				};
			}
		}
	}
}