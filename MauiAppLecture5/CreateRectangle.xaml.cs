using GeometryClasses;

namespace MauiAppLecture5;

public partial class CreateRectangle : ContentPage
{
    public CreateRectangle()
    {
        InitializeComponent();
    }

        private void CreateRectangleBtn_Clicked(object sender, EventArgs e)
        {
            var r = new Rectangle();
            r.Height = int.Parse(HeightTxt.Text);
            r.Width = int.Parse(WidthTxt.Text);
            App.dm.AddFigure(r);
            InfoLbl.Text = r.ToString();
        }
}