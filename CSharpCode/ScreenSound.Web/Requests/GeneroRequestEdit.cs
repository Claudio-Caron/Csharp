namespace ScreenSound.API.Requests
{
    public record GeneroRequestEdit(string Name, string Description, int Id) :
        GeneroRequest(Name, Description);

}
