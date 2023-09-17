namespace Program
{
	public class NumberConverter
	{
		public NumberConverter() { }

        private readonly Dictionary<int, string> numbers = new()
		{
			{ 5, "���"},
			{ 6, "����"},
			{ 7, "���"},
			{ 8, "���"},
			{ 9, "�����"},
			{ 10, "�����"},
			{ 11, "����������"},
			{ 12, "���������"},
			{ 13, "���������"},
			{ 14, "�����������"},
			{ 15, "���������"},
			{ 16, "����������"},
			{ 17, "���������"},
			{ 18, "�����������"},
			{ 19, "�����������"},
			{ 20, "�������"},
			{ 30, "�������"},
			{ 40, "�����"},
			{ 90, "��������"},
			{ 100, "��"},
			{ 1000, "�����" },
			{ 1_000_000, "�������" },
			{ 1_000_000_000, "��������" },
		};

		
		public string declensionNumber(int number, string gender, string _case)
		{
			if (number == 0)
			{
				return _case switch
				{
					"�" => "����",
					"�" => "����",
					"�" => "����",
					"�" => "����",
					"�" => "�����",
					"�" => "����",
					_ => "",
				};
			}
			else if (number == 1)
			{
				return _case switch
				{
					"�" => gender switch
					{
						"�" => "����",
						"�" => "����",
						"�" => "����",
						_ => "",
					},
					"�" => gender switch
					{
						"�" => "������",
						"�" => "�����",
						"�" => "������",
						_ => "",
					},
					"�" => gender switch
					{
						"�" => "������",
						"�" => "�����",
						"�" => "������",
						_ => "",
					},
					"�" => gender switch
					{
						"�" => "����",
						"�" => "����",
						"�" => "����",
						_ => "",
					},
					"�" => gender switch
					{
						"�" => "�����",
						"�" => "�����",
						"�" => "�����",
						_ => "",
					},
					"�" => gender switch
					{
						"�" => "�����",
						"�" => "�����",
						"�" => "�����",
						_ => "",
					},
					_ => "",
				};
			}
			else if (number == 2)
			{
				return _case switch
				{
					"�" => gender switch
					{
						"�" => "���",
						"�" => "���",
						"�" => "���",
						_ => "",
					},
					"�" => "����",
					"�" => "����",
					"�" => gender switch
					{
						"�" => "���",
						"�" => "���",
						"�" => "���",
						_ => "",
					},
					"�" => "�����",
					"�" => "����",
					_ => "",
				};
			}
			else if (number == 3)
			{
				return _case switch
				{
					"�" => "���",
					"�" => "����",
					"�" => "����",
					"�" => "���",
					"�" => "�����",
					"�" => "����",
					_ => "",
				};
			}
			else if (number == 4)
			{
				return _case switch
				{
					"�" => "������",
					"�" => "�������",
					"�" => "�������",
					"�" => "������",
					"�" => "��������",
					"�" => "�������",
					_ => "",
				};
			}
			else if (number == 8)
			{
				return _case switch
				{
					"�" => numbers[8] + "���",
					"�" => numbers[8] + "���",
					"�" => numbers[8] + "���",
					"�" => numbers[8] + "���",
					"�" => numbers[8] + "����",
					"�" => numbers[8] + "���",
					_ => "",
				};
			}
			else if (number >= 5 && number <= 20 || number == 30)
			{
				return _case switch
				{
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "��",
					"�" => numbers[number] + "�",
					_ => "",
				};
			}
			else if (number == 40)
			{
				return _case switch
				{
					"�" => numbers[number] + "",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					_ => "",
				};
			}
			else if (number == 50 || number == 60 || number == 70 || number == 80)
			{
				return _case switch
				{
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10],
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10] + "�",
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10] + "�",
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10],
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10] + "��",
					"�" => declensionNumber(number / 10, gender, _case) + numbers[10] + "�",
					_ => "",
				};
			}
			else if (number == 90 || number == 100)
			{
				return _case switch
				{
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					"�" => numbers[number] + "�",
					_ => "",
				};
			}
			else if (number == 200)
			{
				return _case switch
				{
					"�" => "������",
					"�" => "�������",
					"�" => "��������",
					"�" => "������",
					"�" => "����������",
					"�" => "��������",
					_ => "",
				};
			}
			else if (number == 300 || number == 400)
			{
				return _case switch
				{
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "����",
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "�����",
					"�" => declensionNumber(number / 100, gender, _case) + "����",
					_ => "",
				};
			}
			else if (number == 500 || number == 600 || number == 700 || number == 800 || number == 900)
			{
				return _case switch
				{
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "����",
					"�" => declensionNumber(number / 100, gender, _case) + "���",
					"�" => declensionNumber(number / 100, gender, _case) + "�����",
					"�" => declensionNumber(number / 100, gender, _case) + "����",
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
					"�" => numbers[1000] + "�",
					"�" => numbers[1000] + "�",
					"�" => numbers[1000] + "�",
					"�" => numbers[1000] + "�",
					"�" => numbers[1000] + "��",
					"�" => numbers[1000] + "�",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"�" => numbers[1000] + "�",
					"�" => numbers[1000],
					"�" => numbers[1000] + "��",
					"�" => numbers[1000] + "�",
					"�" => numbers[1000] + "���",
					"�" => numbers[1000] + "��",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"�" => numbers[1000],
					"�" => numbers[1000],
					"�" => numbers[1000] + "��",
					"�" => numbers[1000],
					"�" => numbers[1000] + "���",
					"�" => numbers[1000] + "��",
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
					"�" => numbers[1_000_000],
					"�" => numbers[1_000_000] + "�",
					"�" => numbers[1_000_000] + "�",
					"�" => numbers[1_000_000],
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "�",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"�" => numbers[1_000_000] + "�",
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "�",
					"�" => numbers[1_000_000] + "���",
					"�" => numbers[1_000_000] + "��",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "��",
					"�" => numbers[1_000_000] + "���",
					"�" => numbers[1_000_000] + "��",
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
					"�" => numbers[1_000_000_000],
					"�" => numbers[1_000_000_000] + "�",
					"�" => numbers[1_000_000_000] + "�",
					"�" => numbers[1_000_000_000],
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "�",
					_ => "",
				};
			}
			else if (determinant > 1 && determinant < 5)
			{
				return _case switch
				{
					"�" => numbers[1_000_000_000] + "�",
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "�",
					"�" => numbers[1_000_000_000] + "���",
					"�" => numbers[1_000_000_000] + "��",
					_ => "",
				};
			}
			else
			{
				return _case switch
				{
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "��",
					"�" => numbers[1_000_000_000] + "���",
					"�" => numbers[1_000_000_000] + "��",
					_ => "",
				};
			}
		}
	}
}