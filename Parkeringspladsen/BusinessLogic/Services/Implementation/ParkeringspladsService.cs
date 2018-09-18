using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Model;
using BusinessLogic.Services.Contract;

namespace BusinessLogic.Services.Implementation
{
	public class ParkeringspladsService : IParkeringspladsService
	{
		protected Parkeringsplads _parkeringsplads;

		public ParkeringspladsService()
		{
			_parkeringsplads = new Parkeringsplads();
		}

		public IReadOnlyList<Bil> AlleBiler()
		{
			throw new System.NotImplementedException();
		}

		public void AnkomTilParkeringspladsen(Bil bil)
		{
			throw new System.NotImplementedException();
		}

		public Bil FindBil(string regNr = "")
		{
			throw new System.NotImplementedException();
		}

		public void ForladParkeringspladsen(Bil bil)
		{
			throw new System.NotImplementedException();
		}
	}
}

