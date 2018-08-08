using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryPatternsMVC.Models.Adapter
{
	class OldElectricitySystem
	{
		public string MatchThinSocket()
		{
			return "220V";
		}
	}
	// Широковикористовуваний інтерфейс нової системи (специфікація до квартири) 
	interface INewElectricitySystem
	{
		string MatchWideSocket();
	}
	// Ну і власне сама розетка у новій квартирі
	class NewElectricitySystem : INewElectricitySystem
	{
		public string MatchWideSocket()
		{
			return "220V";
		}
	}

	class Adapter : INewElectricitySystem
	{     // Але всередині він таки знає, що коїлося в СРСР  
		private readonly OldElectricitySystem _adaptee;
		public Adapter(OldElectricitySystem adaptee) { _adaptee = adaptee; }


		public string MatchWideSocket()
		{
			return _adaptee.MatchThinSocket();
		}
	}

	class ElectricityConsumer
	{
		public static string ChargeNotebook(INewElectricitySystem electricitySystem)
		{
			return electricitySystem.MatchWideSocket();
		}
	}
}
	

