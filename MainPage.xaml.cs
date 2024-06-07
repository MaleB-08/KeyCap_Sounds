namespace KeyCap_Sounds
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var CustomFileType =
                new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<String>>
                {
                    {DevicePlatform.WinUI, new [] {".mp3"}}
                });

            var FilePicked = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = CustomFileType
            });

            if (FilePicked != null)
            {
                ButtonRemane 
            }
        }

    }
}
