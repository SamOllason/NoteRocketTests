using NoteRocket.Client.Components;
using NoteRocket.Client.Models;
using NoteRocket.Client.Services;
using System.Collections.Generic;

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
        var storageServiceMock = new StorageService();

        var sampleNotes = new List<Note>()
        {
            new Note {  Id = 1, Title = "Note 1", Body = "this is the body of note1!", Category = Category.Learning},
            new Note {  Id = 2, Title = "Note2", Body = "second note!", Category = Category.Personal},
        };
        storageServiceMock.Notes = sampleNotes;

        Services.AddSingleton<IStorageService>(storageServiceMock);
        Services.AddSingleton<INotesService>(new NotesService(storageServiceMock));

        var navManager = Services.GetRequiredService<FakeNavigationManager>();

        // Act
        var cut = RenderComponent<NotePage>(parameters => parameters
            .Add(p => p.Id, 1));

        cut.Find("#save-note-btn").Click();

        // Assert
        Assert.AreEqual(navManager.Uri, "http://localhost/notes");
    }
}
