using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public static void WriteJsonPerson(Person person)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{person.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, person);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = ChangeBtn.Location;
            ChangeBtn.Location = AddBtn.Location;
            AddBtn.Location = temp;

            Person person = new Person();
            person.Name = NameMaskedTextBox.Text;
            person.Surname = SurnameMaskedTextBox.Text;
            person.Email = EmailMaskedTextBox.Text;
            person.PhoneNumber = PhoneNumberMaskedTextBox.Text;
            person.BirthDay = BirthDayDateTimePictute.Text;

            WriteJsonPerson(person);
            UserListBox.DisplayMember = nameof(Person.Name);
            UserListBox.Items.Add(person);
            list.Add($"{person.Name}.json");

            NameMaskedTextBox.Text = String.Empty;
            SurnameMaskedTextBox.Text = String.Empty;
            EmailMaskedTextBox.Text = String.Empty;
            PhoneNumberMaskedTextBox.Text = String.Empty;
            BirthDayDateTimePictute.Text = String.Empty;
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            var temp = ChangeBtn.Location;
            ChangeBtn.Location = AddBtn.Location;
            AddBtn.Location = temp;
        }

        private void NameMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            if (JsonFileEnter.Text != null)
            {
                var human = UserListBox.SelectedIndex;

                if (human + ".json" == JsonFileEnter.Text)
                {
                    
                }

            }
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var human = UserListBox.SelectedItem as Person;

            NameMaskedTextBox.Text = human.Name;
            SurnameMaskedTextBox.Text = human.Surname;
            EmailMaskedTextBox.Text = human.Email;
            PhoneNumberMaskedTextBox.Text = human.PhoneNumber;
            BirthDayDateTimePictute.Text = human.BirthDay;
        }
    }
}
