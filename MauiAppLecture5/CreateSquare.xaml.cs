using GeometryClasses;

namespace MauiAppLecture5;

public partial class CreateSquare : ContentPage
{
	public CreateSquare()
	{
		InitializeComponent();
	}

	private Square _square;
    public CreateSquare(Square s)
    {
        InitializeComponent();
        _square = s;
		EdgeTxt.Text = s.Edge.ToString();
		CreateSquareBtn.Text = "Update square";
    }

    private async void CreateSquareBtn_Clicked(object sender, EventArgs e)
    {

        if (_square is null)
        {
            var sq = new Square();
            sq.Edge = int.Parse(EdgeTxt.Text);
            App.dm.AddFigure(sq);
            InfoLbl.Text = sq.ToString();
        }
        else
        {
            _square.Edge = int.Parse(EdgeTxt.Text);
            await Navigation.PopModalAsync();
        }

    }


}