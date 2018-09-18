using BusinessLogic.Model;
using BusinessLogicTest.Fixtures;
using Xunit;

namespace BusinessLogicTest
{
	public class ParkeringspladsServiceSkal
	{
		[Fact]
		public void FjerneBilenFraParkeringspladsen_Ved_ForladPladsen()
		{
			// Arrange
			var sut = new ParkeringspladsServiceFixture();
			var regNr = "12345678";
			var bil = new Bil {RegNr = regNr};
			sut.Parkeringsplads.Biler.Add(bil);

			// Act
			sut.ForladParkeringspladsen(bil);

			// Assert
			Assert.DoesNotContain(sut.Parkeringsplads.Biler, a => a.RegNr == regNr);
		}

		[Fact]
		public void HenteAlleBilerPaaParkeringspladsen_Ved_AlleBiler()
		{
			// Arrange
			var sut = new ParkeringspladsServiceFixture();
			var expected = 2;
			sut.Parkeringsplads.Biler.AddRange(new[] {new Bil(), new Bil()});

			// Act
			var actual = sut.AlleBiler();

			// Assert
			Assert.Equal(expected, actual.Count);
		}

		[Fact]
		public void TilfoejeEnBilTilParkeringspladsen_Ved_Ankomst()
		{
			// Arrange
			var sut = new ParkeringspladsServiceFixture();
			var regNr = "12345678";
			var bil = new Bil {RegNr = regNr};

			// Act
			sut.AnkomTilParkeringspladsen(bil);

			// Assert
			Assert.Contains(sut.Parkeringsplads.Biler, a => a.RegNr == regNr);
		}
	}
}