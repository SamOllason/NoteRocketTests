using NoteRocket.Client.Components;

namespace NoteRocketTests;
public class NotePageTests : BunitTestContext
{
    [Test]
    public void NotePage_RendersTitle()
    {
        // Arrange
        var cut = RenderComponent<NotePage>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("h1").MarkupMatches("<h1>Ti</h1>");
    }

    [Test]
    public void NotePage_RendersCategoryButtons()
    {
        // Arrange
        var cut = RenderComponent<NotePage>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("button").MarkupMatches("<button>Holidays</button>");
    }
}
