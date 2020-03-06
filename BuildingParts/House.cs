using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// тим лидер формирует полностью команду рабочих и следит за постройкой дома
/// документация по дому, какая стадия, что построено принадлежит дому и основной экземлпят лежит "дома"
/// и при создании отчета, бригадир всю информацию берез из документации о доме(что построено, отрисовка дома и тд) те получает посути копию, и на основании ее формирует отчет
/// </summary>

namespace BuildingParts
{
	public sealed class House_Build : Ipart
	{
		TeamLeader temlead;//класс бригадира
		List<Ipart> house;

		string current_stage_name;//активная стройка, что делается на данный момент
		bool finished;//завешен текущий проэкт или нет
		float time_for_build; //время постройки, зависит от количества рабочих
		int count;



		/// <summary>
		/// рисую все части завершенные
		/// </summary>
		public void DrawPart()
		{
			foreach (var item in house)
			{
				if (item.Finished)
				{
					item.DrawPart();
				}
			}
		}




		/// <summary>
		/// можем ли мы выполнять текущую стадию == проверка строителями текущий стадии по заданию
		/// </summary>
		/// <param name="what_need_todo"></param>
		/// <returns></returns>
		public bool CheckStage(string what_need_todo)
		{

			if (what_need_todo == "Basement" && house.Find(s => s.CurrentNamePart == "Basement" && s.Finished == false) != null) return true;
			else
				if (what_need_todo == "Walls" && house.Find(s => s.CurrentNamePart == "Basement" && s.Finished) != null) return true;
			else
				if (what_need_todo == "Door" && house.Find(s => s.CurrentNamePart == "Window" && s.Finished == true) != null) return true;
			else
				if (what_need_todo == "Window" && house.Find(s => s.CurrentNamePart == "Walls" && s.Finished) != null)
			{
				if (what_need_todo == "Window" && house.Find(s => s.CurrentNamePart == "Roof" && s.Finished) != null)
				{
					return true;
				}
				else return false;
			}
			else
				if (what_need_todo == "Roof" && house.Find(s => s.CurrentNamePart == "Walls" && s.Finished == true) != null) return true;
			else return false;

		}


		/// <summary>
		/// начинаем строить, и посути сразу заканчиваем постройку, тк небыло указано что нужно учитывать время строительства и тд
		/// </summary>
		/// <param name="part_of_object"></param>
		public void StartBuild(string part_of_object)
		{
			if (!finished)
			{
				if (part_of_object == current_stage_name)
				{
					Console.WriteLine("We busy now at this stage!!");
					return;
				}
				else
				if (house.Find(s => s.CurrentNamePart == part_of_object && s.Finished) != null)
				{
					Console.WriteLine("This stage is already done!");
					return;
				}
				else
				if (CheckStage(part_of_object))
				{
					for (int i = 0; i < temlead.Team.All_workers.Count(); i++)
					{
						if (!temlead.Team.All_workers[i].IsWorked) temlead.Team.All_workers[i].IsWorked = true;
					}
					current_stage_name = part_of_object;

					StoprWork();
				}
				else Console.WriteLine("We cant do this object!");
			}
			else Console.WriteLine("House is ready,\n check Brigadir report");
		}

		/// <summary>
		/// вызов бригадира, который делает отчет!закрытый метод
		/// </summary>
	




		/// <summary>
		/// посути меню для работы
		/// </summary>
		public void StartWork()
		{

			int choice = 0;
			do
			{
				Console.WriteLine("1. Построить фундамент");
				Console.WriteLine("2. Построить стены");
				Console.WriteLine("3. Установить крышу");
				Console.WriteLine("4. Построить окна");
				Console.WriteLine("5. Установить двери");
				Console.WriteLine("6. Отчет бригадира");
				Console.WriteLine("7. Выход");
				int.TryParse(Console.ReadLine(), out choice);
				switch (choice)
				{
					case 1:
						StartBuild("Basement");
						break;
					case 2: StartBuild("Walls"); break;
					case 3: StartBuild("Roof"); break;
					case 4: StartBuild("Window"); break;
					case 5: StartBuild("Door"); break;
					case 6:
						Console.Clear();
						Console.WriteLine();
						temlead.ShowInfo();
						DrawPart();
						Console.WriteLine();
						break;
					case 7: break;
					default:
						break;
				}


			} while (choice != 7);
		}
		/// <summary>
		/// метод сообщает о том что работа окончена
		/// </summary>
		public void StoprWork()
		{
			if (current_stage_name != null)
			{
				for (int i = 0; i < house.Count(); i++)
				{
					if (house[i].CurrentNamePart == current_stage_name)
					{
						house[i].Finished = true;//отмечаю что текущая часть построена, для отчета
						TeamLeader.Report a = new TeamLeader.Report(house[i].CurrentNamePart, house[i].Count, house[i].TimeForBild);
						temlead.Reports.Add(a);
						break;
					}
				}
				for (int i = 0; i < temlead.Team.All_workers.Count(); i++)//отмечаю что все рабочие перестали работать
				{
					temlead.Team.All_workers[i].IsWorked = false;
				}
			}
			else Console.WriteLine("Workers not busy now!");
		}




		#region Constructors+Prop

		public House_Build(string brigadirname, int total_workers)
		{
			house = new List<Ipart>();
			house.Add(new Basement(150.0f));
			house.Add(new Walls(4, 168));
			house.Add(new Window(4, 9.0f));
			house.Add(new Door(1, 3.0f));
			house.Add(new Roof(1, 169));
			this.temlead = new TeamLeader(brigadirname, total_workers);
			current_stage_name = null;
			finished = false;
		}


		public float TimeForBild { get => time_for_build; set => time_for_build = value; }
		public int Count { get => count; set => count = value; }
		public string CurrentNamePart { get => current_stage_name; set => current_stage_name = value; }
		public bool Finished { get => finished; set => finished = value; }
		#endregion
	}
}
