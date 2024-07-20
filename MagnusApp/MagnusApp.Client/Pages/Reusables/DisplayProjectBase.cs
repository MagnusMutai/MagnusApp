﻿using Microsoft.JSInterop;

namespace MagnusApp.Client.Pages.Reusables;

public class DisplayProjectBase : ComponentBase
{
    private bool firstRender = true;
    public string Css { get; set; } = string.Empty;

    [Inject]
    NavigationManager NavigationManager { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeAsync<string>("addEventListener");
        }
    }

    protected async void Clicktoanimate()
    {
        await JSRuntime.InvokeAsync<string>("CallMethod");
    }

    protected void OpenWebsite(string uri)
    {
        NavigationManager.NavigateTo(uri, false);
    }

    [JSInvokable]
    public static void AddAnimation()
    {
        DisplayProjectBase displayProjectBase = new DisplayProjectBase();
        displayProjectBase.Css = "show-animate";
    }


    public async void HelloWorld()
    {
        await JSRuntime.InvokeVoidAsync("HelloWorld");
    }
}
