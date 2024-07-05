﻿using Syncfusion.Blazor.Popups;

namespace MagnusApp.Client.Pages;

public class HiremeBase : ComponentBase
{
    protected EmailDto ClientModel = new EmailDto();

    protected string Xvalue = "center";
    protected string Yvalue = "center";
    protected bool IsVisible { get; set; } = false;
    protected string Checked { get; set; } = "center center";
    protected int ViewportWidth { get; set; }
    protected int ViewportHeight { get; set; }

    
    protected void OpenDialog()
    {
        this.IsVisible = true;
    }

    protected void CloseDialog()
    {
        this.IsVisible = false;
    }

    public async Task HandleSubmit()
    {
        this.IsVisible = false;
        //ClientModel = new EmailDto();
    }

    public void OverlayModalClickHandler(OverlayModalClickEventArgs Args)
    {
        this.IsVisible = false;
    }

    //public void OnChangeHandler(ChangeArgs<string> arg)
    //{
    //    this.Xvalue = arg.Value.ToString().Split(' ')[0];
    //    this.Yvalue = arg.Value.ToString().Split(' ')[1];
    //    this.StateHasChanged();
    //}
}
