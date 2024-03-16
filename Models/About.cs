namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://youtu.be/YJHzoLBLY8g?si=KIwLRARGjFKoJ931";
    public string Message => "Это приложение для написания записей и заметок.\nА если нажать на кнопку, то вы перейдете на прикольный плейлист песень \"Russian Circles\".";
}
