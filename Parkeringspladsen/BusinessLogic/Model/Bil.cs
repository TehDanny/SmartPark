using System;

namespace BusinessLogic.Model
{
	public class Bil : ICloneable
	{
		/// <summary>
		///     Bilens registreringsnummer.
		/// </summary>
		public string RegNr { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}