using NoteRocket.Client.Pages;

namespace NoteRocketTests;
public class NotesTests : BunitTestContext
{
    [Test]
    public void PageHasTitle()
    {
        // Arrange
        var cut = RenderComponent<Notes>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("h1").MarkupMatches("<h1>Notes</h1>");
    }
}
