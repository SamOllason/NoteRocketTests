using NoteRocket.Client.Components;
using NoteRocket.Client.Pages;

namespace NoteRocketTests;
public class NotesTests : BunitTestContext
{
    [Test]
    public void NotePage_RendersTitle()
    {
        // Arrange
        var cut = RenderComponent<Notes>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("h1").MarkupMatches("<h1>Notes</h1>");
    }

    [Test]
    public void NotePage_RendersCategoryButtons()
    {
        // Arrange
        var cut = RenderComponent<Notes>();

        // Assert
        cut.Find("#button-Personal").MarkupMatches("<button id='button-Personal'>Personal</button>");
        //cut.Find("button").MarkupMatches("<button>Personal</button>");
        //cut.Find("button").MarkupMatches("<button>Random</button>");
    }
}
