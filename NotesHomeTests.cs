using NoteRocket.Client.Models;
using NoteRocket.Client.Pages;
using NoteRocket.Client.Services;
using System.Collections.Generic;

namespace NoteRocketTests;
public class NotesHomeTests : BunitTestContext
{
    //[Test]
    //public void NotePage_RendersTitle()
    //{
    //    // Arrange
    //    var cut = RenderComponent<NotesHome>();

    //    // Assert
    //    cut.Find("h1").MarkupMatches("<h1>Notes</h1>");
    //}

    //[Test]
    //public void NotePage_RendersCategoryButtons()
    //{
    //    // Arrange
    //    var cut = RenderComponent<NotesHome>();

    //    // Assert
    //    cut.Find("#button-Personal").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Personal'>Personal</button>");
    //    cut.Find("#button-Learning").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Learning'>Learning</button>");
    //    cut.Find("#button-Scouts").MarkupMatches("<button type='button' class='btn btn-primary' id='button-Scouts'>Scouts</button>");

    //}
    [Test]
    public void NotePage_ClickingNewNote_CreatesNoteAndNavigatesUserToNewNotePage()
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
        var cut = RenderComponent<NotesHome>();

        cut.Find("#new-note-btn").Click();

        // Assert
    }
}
