namespace MauiAppLecture5;

public partial class ProcessFiguresData : ContentPage
{
	public ProcessFiguresData()
	{
		InitializeComponent();
	}

    private void CreatreTestData_Clicked(object sender, EventArgs e)
    {
        App.dm.CreateTestData();
    }

    private void ShowDataBtn_Clicked(object sender, EventArgs e)
    {
        infoLbl.Text= App.dm.Print();
    }

    private void SaveDataBtn_Clicked(object sender, EventArgs e)
    {
        App.dm.Save("");
    }

    private void LoadDataBtn_Clicked(object sender, EventArgs e)
    {
        App.dm.Load("");
    }

    private void ResetDataBtn_Clicked(object sender, EventArgs e)
    {
        App.dm.Reset();
    }
}