using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

public class MainWindowViewModel : BindableBase
{
    public DelegateCommand RunCommand { get; set; }
    public DelegateCommand StopCommand { get; set; }
    public DelegateCommand VoiceCommand { get; set; }
    public DelegateCommand UpCommand { get; set; }
    public DelegateCommand DownCommand { get; set; }
    public DelegateCommand OutputCommand { get; set; }

    public DelegateCommand DogCommand {  get; set; }
    public DelegateCommand PantherCommand {  get; set; }
    public DelegateCommand TurtleCommand {  get; set; }

    private Animal _animal;
    private string _data = "�������� ��������";
    
    public MainWindowViewModel()
    {
        DogCommand = new DelegateCommand(Dog);
        PantherCommand = new DelegateCommand(Panther);
        TurtleCommand = new DelegateCommand(Turtle);
        RunCommand = new DelegateCommand(Run);
        StopCommand = new DelegateCommand(Stop);
        VoiceCommand = new DelegateCommand(Voice);
        UpCommand = new DelegateCommand(Up);
        DownCommand = new DelegateCommand(Down);
        Data = _data;
    }

    private void Dog()
    {
        _animal = new Dog();
        Data = $"������, ������������ �������� = {_animal.GetMaxSpeed()}";

        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Panther()
    {
        _animal = new Panther();
        Data = $"�������, ������������ �������� = {_animal.GetMaxSpeed()}";
        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Turtle()
    {
        _animal = new Turtle();
        Data = $"��������, ������������ �������� = {_animal.GetMaxSpeed()}";
        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Run()
    {
        if(_animal != null)
        {
            Data = _animal.Go();
        }
        else
        {
            Data = "�������� ��������";
        }
    }

    private void Stop()
    {
        if (_animal != null)
        {
            Data = _animal.Stay();
        }
        else
        {
            Data = "�������� ��������";
        }
    }

    private void Voice()
    {
        if (_animal != null)
        {
            Data = _animal.GetVoice();
        }
        else
        {
            Data = "�������� ��������";
        }
    }

    private void Up()
    {
        if (_animal != null)
        {
            Data = _animal.Up();
        }
        else
        {
            Data = "�������� ��������";
        }
    }

    private void Down()
    {
        if (_animal != null)
        {
            Data = _animal.Down();
        }
        else
        {
            Data = "�������� ��������";
        }
    }

    public string Data
    {
        get => _data;
        set => SetProperty(ref _data, value);
    }
}