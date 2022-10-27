public class DataPerson
{
    private string _serchName;
    private string _name;
    private string _fatherName;
    private string _fullName;

    private string _phoneNumber;

    private int _pasportNumber;
    private int _pasportSerial;
    private string _pasportData;

    public DataPerson(string serchN, string name, string fatherN, string phonN, int pasportN, int pasportSer)
    {
        _serchName = serchN;
        _name = name;
        _fatherName = fatherN;
        _phoneNumber = phonN;
        _pasportNumber = pasportN;
        _pasportSerial = pasportSer;

        _fullName = _serchName + " " + _name + " " + _fatherName;
        _pasportData = _pasportSerial + "" + _pasportNumber;
    }

    public string FullName { get => _fullName; set => _fullName = value; }
    public string PasportData { get => _pasportData; set => _pasportData = value; }
    public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
}