using NoteRocket.Client.Components;

namespace NoteRocketTests;
public class NotePageTests : BunitTestContext
{
    [Test]
    public void NotePage_RendersTitle()
    {
        // Arrange
        //var cut = RenderComponent<NotePage>(parameters => parameters);

        var cut = RenderComponent<NotePage>(parameters => parameters
            .Add(p => p.Id, 1));

        // Assert
        cut.Find("h1").MarkupMatches("<h1>Shopping list</h1>");
    }
}
