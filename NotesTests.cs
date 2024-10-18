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
        cut.Find("#button-Personal").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Personal'>Personal</button>");
        cut.Find("#button-Learning").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Learning'>Learning</button>");
        cut.Find("#button-Scouts").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Scouts'>Scouts</button>");

    }
}
