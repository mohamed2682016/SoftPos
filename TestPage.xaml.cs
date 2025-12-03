namespace SoftPos
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("TestPage initialized!");
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Button clicked! App is working!", "OK");
        }
    }
}
