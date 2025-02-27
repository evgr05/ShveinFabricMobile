namespace MauiApp1;

public partial class PageMain : ContentPage
{
    public PageMain()
    {
        InitializeComponent();
    }
    void OnTextCompleted(object sender, EventArgs e)
    {
        loginLbl.Text = loginEntry.Text;
    }

    void OnStatusChanged(object sender, ToggledEventArgs e)
    {
        saveLbl.Text = saveSwitch.On ? "Данные сохранены" : "Данные не сохранены";
    }

    private void EntryCell_Completed(object sender, EventArgs e)
    {
        telephoneLbl.Text = telephoneEntry.Text;
    }

    private void EntryCell_Completed_1(object sender, EventArgs e)
    {
        danLbl.Text = danEntry.Text;
    }
}