using BusinessLogic.Model;
using BusinessLogic.Services.Implementation;

namespace BusinessLogicTest.Fixtures
{
	public class ParkeringspladsServiceFixture : ParkeringspladsService
	{
		public Parkeringsplads Parkeringsplads => _parkeringsplads;
	}
}