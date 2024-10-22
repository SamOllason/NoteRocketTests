using NoteRocket.Client.Models;
namespace NoteRocketTests;

[TestFixture]
public class NoteRepositoryTests
{

	//[Test]
	//public void UpdateNote_NoteIdDoesntMatchNote_Aborts()
	//{
	//    //Setup

	//    var id = 1;
	//    var note = new Note { Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal };

	//    //Arrange

	//    var bob = new NotesService();
	//    var outcome = bob.UpdateNote(id, note);

	//    //Act
	//    Assert.AreEqual(outcome, "updated");
	//}

	[Test]
	public void UpdateNote_NoteIdDoesntMatchNote_Aborts()
	{
		//Setup

		var id = 1;
		var note = new Note { Id = 1, Title = "Shopping list", Body = "carrot, broccoli...", Category = Category.Personal };

		//Arrange

		var bob = new NotesService();
		var outcome = bob.UpdateNote(id, note);

		//Act
		Assert.AreEqual(outcome, "updated");
	}
}