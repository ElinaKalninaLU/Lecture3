using GeometryClasses;

namespace MauiAppLecture5;

public partial class EditFigures : ContentPage
{
	public EditFigures()
	{
		InitializeComponent();
		FiguresLst.ItemsSource = App.dm.FigureList;

    }

    public void RefreshList()
    {
        FiguresLst.ItemsSource = null;
       FiguresLst.ItemsSource = App.dm.FigureList;

    }

    private async void FiguresLst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (IsEditingChx.IsChecked)
        {
            //edit mode
            if (FiguresLst.SelectedItem != null)
            {
                if (FiguresLst.SelectedItem is Square)
                { 
                    Square s = (Square)FiguresLst.SelectedItem;
                    await Navigation.PushModalAsync(new CreateSquare(s));
                }
            }
        }
        else
        { 
            //delete mode
        if (FiguresLst.SelectedItem != null)
        {
            Figure f = (Figure)FiguresLst.SelectedItem;
            bool answer = await DisplayAlert("Deletion?", "Would you like to delete figure: " + f.ToString, "Yes", "No");
            if (answer)
            {
                App.dm.FigureList.Remove(f);
                RefreshList();
            }
        }
    }
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        RefreshList();
    }
}