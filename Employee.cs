public class Employee {
    private int id;
    private string name;
    private string gender;
    private string homeAddress;
    private string tel;
    private string email;
    public int Id {
        get { return id; }
    }
    public string Name {
        get { return name; }
    }
    public string Gender {
        get { return gender; }
    }
    public string HomeAddress {
        get { return homeAddress; }
        set { homeAddress = value; }
    }
    public string Tel {
        get { return tel; }
        set { tel = value; }
    }
    public string Email {
        // get; set;
        // get => email;
        // set => email = value;
        get { return email; }
        set { email = value; }
    }
    public Employee(int _Id, string _Name, string _Gender, string _HomeAddress, string _Tel, string _Email) {
        id = _Id;
        name = _Name;
        gender = _Gender;
        HomeAddress = _HomeAddress;
        Tel = _Tel;
        Email = _Email;
    }
    public void Print() {
        string strId = "工号：" + Id + "\n";
        string strName = "姓名：" + Name + "\n";
        string strGender = "性别：" + Gender + "\n";
        string strAddr = "住址：" + HomeAddress + "\n";
        string strTel = "电话：" + Tel + "\n";
        string strEmail = "邮箱：" + Email + "\n";
        Console.WriteLine(strId+strName+strGender+strAddr+strTel+strEmail);
    }
}