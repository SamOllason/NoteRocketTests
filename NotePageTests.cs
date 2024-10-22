using NoteRocket.Client.Components;
using NoteRocket.Client.Models;

namespace NoteRocketTests;
public class NotePageTests : BunitTestContext
{
    //    [Test]
    //    public void NotePage_RendersTitle()
    //    {
    //        // Arrange
    //        //var cut = RenderComponent<NotePage>(parameters => parameters);

    //        var cut = RenderComponent<NotePage>(parameters => parameters
    //            .Add(p => p.Id, 1));

    //        // Assert
    //        cut.Find("h1").MarkupMatches("<h1>Shopping list</h1>");
    //    }

    [Test]
    public void NotePage_ClickingClose_NavigatesUserBackToNotesHome()
    {
        // Arrange
        Services.AddSingleton<INotesService>(new NotesService());

        var navManager = Services.GetRequiredService<FakeNavigationManager>();

        // Act
        var cut = RenderComponent<NotePage>(parameters => parameters
            .Add(p => p.Id, 1));

        cut.Find("#save-note-btn").Click();

        // Assert
        Assert.AreEqual(navManager.Uri, "http://localhost/notes");
    }
}
