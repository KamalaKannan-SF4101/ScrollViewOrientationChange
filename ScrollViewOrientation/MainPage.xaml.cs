namespace ScrollViewOrientation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

     

        private void Button_Clicked(object sender, EventArgs e)
        {
            scrollView.Orientation = ScrollOrientation.Both;
        }
    }

}
