using NoteRocket.Client.Pages;

namespace NoteRocketTests;
public class NotesTests : BunitTestContext
{
    [Test]
    public void NotePage_RendersTitle()
    {
        // Arrange
        var cut = RenderComponent<Notes>();

        // Assert
        cut.Find("h1").MarkupMatches("<h1>Notes</h1>");
    }

    [Test]
    public void NotePage_RendersCategoryButtons()
    {
        // Arrange
        var cut = RenderComponent<Notes>();

        // Assert
        cut.Find("#button-Personal").MarkupMatches("<button id='button-Personal'>Personal</button>");
        cut.Find("#button-Learning").MarkupMatches("<button id='button-Learning'>Learning</button>");
        cut.Find("#button-Random").MarkupMatches("<button id='button-Random'>Random</button>");
    }
}
