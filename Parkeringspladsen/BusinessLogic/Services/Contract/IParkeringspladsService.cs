using System.Collections.Generic;
using BusinessLogic.Model;

namespace BusinessLogic.Services.Contract
{
	public interface IParkeringspladsService
	{
		/// <summary>
		///     Kaldes når en bil forlader parkeringspladsen.
		/// </summary>
		/// <param name="bil"></param>
		void ForladParkeringspladsen(Bil bil);

		/// <summary>
		///     Kaldes når en bil ankommer til parkeringspladsen.
		/// </summary>
		/// <param name="bil"></param>
		void AnkomTilParkeringspladsen(Bil bil);

		/// <summary>
		///     Find bil med det angivne registreringsnummer.
		/// </summary>
		/// <param name="regNr">
		///     regNr er optional. Hvis den ikke angives returneres en tilfældig bil.
		/// </param>
		/// <returns>Hvis bilen findes returneres denne. Ellers returneres null</returns>
		Bil FindBil(string regNr = "");

		/// <summary>
		///     Hent alle biler på parkeringspladsen.
		/// </summary>
		/// <returns></returns>
		IReadOnlyList<Bil> AlleBiler();
	}
}