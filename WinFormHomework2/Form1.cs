using System.Text.RegularExpressions;
using System.Text.Json;

namespace WinFormHomework2
{

    public partial class Form1 : Form
    {


        class Person
        {
            public Person(string name, string surname, string email, string country, string city, string phone, bool male, bool female, string birthday)
            {
                Name = name;
                Surname = surname;
                Email = email;
                Country = country;
                City = city;
                Phone = phone;
                Male = male;
                Female = female;
                Birthday = birthday;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public bool Male { get; set; }
            public bool Female { get; set; }
            public string Birthday { get; set; }

        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        List<Person> ankets = new List<Person>();

        private void button1_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            if (File.Exists("ankets.json"))
            {
                string anketJson2 = File.ReadAllText("ankets.json");
                var ankets2 = JsonSerializer.Deserialize<List<Person>>(anketJson2);

                ankets = ankets2;
            }

            string pattern = @"(^\+994) \((055|050|070|077|010|099)\)\s(\d{3})\s(\d{2})\s(\d{2})$";


            if (nameTextBox.Text.Length >= 3 && surnameTextBox.Text.Length >= 5 && countryTextBox.Text.Length >= 5 &&
                cityTextBox.Text.Length >= 3 && Regex.IsMatch(phoneTextBox.Text, pattern) == true &&
                (maleRadioButton.Checked == true || femaleRadioButton.Checked == true) && (emailTextBox.Text.EndsWith("@gmail.com") || emailTextBox.Text.EndsWith("@mail.ru") == true))
            {
                int checkEmail = 0;
                for (int i = 0; i < ankets.Count; i++)
                {
                    if (ankets[i].Email == emailTextBox.Text)
                    {
                        informationLabel.Visible = true;
                        informationLabel.Text = "Invalid email!!!Bu emaile sahib insan var";
                        informationLabel.ForeColor = Color.Red;
                        checkEmail++;
                    }
                }

                if (checkEmail == 0)
                {
                    Person newPerson = new Person(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, countryTextBox.Text, cityTextBox.Text, phoneTextBox.Text, maleRadioButton.Checked, femaleRadioButton.Checked, birthdayDateTime.Text);
                    ankets.Add(newPerson);
                    informationLabel.Text = "";
                    MessageBox.Show("Sizin melumatlarinizin hamsi duz olduguna gore qeydiyyatiniz ugurla alindi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(1000);
                    nameTextBox.Text = "";
                    surnameTextBox.Text = "";
                    emailTextBox.Text = "";
                    countryTextBox.Text = "";
                    cityTextBox.Text = "";
                    cityTextBox.Text = "";
                    phoneTextBox.Text = "";
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = false;
                    birthdayDateTime.Text = "";


                    var anketJson = JsonSerializer.Serialize(ankets);
                    File.WriteAllText("ankets.json", anketJson);
                }

            }
            else if (nameTextBox.Text.Length < 3)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid name!!!Sizin adiniz minumum 3 herf olmalidir";
                informationLabel.ForeColor = Color.Red;
            }
            else if (surnameTextBox.Text.Length < 5)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid surname!!!Sizin soyadiniz minumum 5 herf olmalidir";
                informationLabel.ForeColor = Color.Red;
            }

            else if ((emailTextBox.Text.EndsWith("@gmail.com") || emailTextBox.Text.EndsWith("@mail.ru") == false))
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid email!!!Sizin emailiniz sonu @gmail.comla yada @mail.ruyla bitmelidir";
                informationLabel.ForeColor = Color.Red;
            }

            else if (countryTextBox.Text.Length < 5)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid country!!!Sizin country adiniz minumum 5 herf olmalidir";
                informationLabel.ForeColor = Color.Red;
            }
            else if (cityTextBox.Text.Length < 3)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid city!!!Sizin city adiniz minumum 3 herf olmalidir";
                informationLabel.ForeColor = Color.Red;
            }

            else if (Regex.IsMatch(phoneTextBox.Text, pattern) == false)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid phone!!!Sizin nomreniz duzgun qaydada deyil";
                informationLabel.ForeColor = Color.Red;
            }

            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                informationLabel.Visible = true;
                informationLabel.Text = "Invalid gender!!!Siz gender secmelisiniz";
                informationLabel.ForeColor = Color.Red;
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            string anketJson2 = File.ReadAllText("ankets.json");
            var ankets2 = JsonSerializer.Deserialize<List<Person>>(anketJson2);

            informationLabel.Text = "";
            int check = 0;
            for (int i = 0; i < ankets2.Count; i++)
            {
                if (checkTextBox.Text == ankets2[i].Email)
                {
                    nameTextBox.Text = ankets2[i].Name;
                    surnameTextBox.Text = ankets2[i].Surname;
                    emailTextBox.Text = ankets2[i].Email;
                    countryTextBox.Text = ankets2[i].Country;
                    cityTextBox.Text = ankets2[i].City;
                    cityTextBox.Text = ankets2[i].City;
                    phoneTextBox.Text = ankets2[i].Phone;
                    maleRadioButton.Checked = ankets2[i].Male;
                    femaleRadioButton.Checked = ankets2[i].Female;
                    birthdayDateTime.Text = ankets2[i].Birthday;

                    saveButton.Enabled = false;
                    check++;
                }
            }

            if (check == 0) 
            {
                MessageBox.Show("Bu emaile sahib anket tapila bilinmir\nZehemet olmasa duzgun email yazin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkTextBox.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkTextBox.Text = "";
            informationLabel.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            cityTextBox.Text = "";
            phoneTextBox.Text = "";
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            birthdayDateTime.Text = "";
            saveButton.Enabled = true;
        }
    }
}