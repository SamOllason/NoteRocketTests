using NoteRocket.Client.Components;

namespace NoteRocketTests;
public class NotePageTests : BunitTestContext
{
    [Test]
    public void PageHasTitle()
    {
        // Arrange
        var cut = RenderComponent<NotePage>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("h1").MarkupMatches("<h1>Ti</h1>");
    }
}
