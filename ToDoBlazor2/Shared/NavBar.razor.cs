using Microsoft.AspNetCore.Components;

namespace ToDoBlazor2.Shared
{
    public partial class NavBar
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;
    }
}
