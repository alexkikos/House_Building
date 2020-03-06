using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
	public sealed class TeamLeader : Iworker
	{
		/// <summary>
		/// вложенная структура для хранения данных, можно было без нее, но захотелось задействовать
		/// используется в формировании отчета в house
		/// </summary>
		public struct Report
		{

			public string name;
			public double count;
			public double time;

			public Report(string name, double count, double time)
			{
				this.name = name;
				this.count = count;
				this.time = time;
			}
			
		}


		Team team;
		/// <summary>
		/// запрос отчета
		/// </summary>
		List<Report> reports;
		string lead_name;//имя бригадира
		bool isWorked;//работает или нет


	

		public TeamLeader(string lead_name, int total_workers)
		{
			this.lead_name = lead_name;
			this.isWorked = false;
			reports = new List<Report>();
			team = new Team(total_workers);
		}

		public string Name_Worker { get => lead_name; set => lead_name = value; }
		public bool IsWorked { get => isWorked; set => isWorked = value; }
		public Team Team { get => team; }
		public List<Report> Reports { get => reports; set => reports = value; }



		/// <summary>
		/// get a copy from house what done
		/// </summary>
		/// <param name="all_finish_stage"></param>
		public void ShowInfo()
		{

			Console.WriteLine("==============================REPORT BRIGADIR======================================");
			foreach (var item in Reports)
			{
				Console.WriteLine("Stage is finish: " + item.name + "; count: " + item.count + " ; Time for build: " + item.count * item.time / 24.0f + " days");
			}
			if (Reports.Count < 5) Console.WriteLine("Waiting for New Tasks");
			else Console.WriteLine("House is ready!");
			Console.WriteLine("===================================================================================");
		}


	}
}
