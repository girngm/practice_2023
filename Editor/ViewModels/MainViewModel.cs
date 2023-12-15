namespace Editor.ViewModels
{
    public class MainViewModel
    {
        public ECNViewModel ECN { get; set; } = new ECNViewModel();
        public SHVNNasosViewModel SHVNNasos { get; set; } = new SHVNNasosViewModel();
        public MotorsViewModel Motors { get; set; } = new MotorsViewModel();
        public MakersViewModel Makers { get; set; } = new MakersViewModel();
    }
}
