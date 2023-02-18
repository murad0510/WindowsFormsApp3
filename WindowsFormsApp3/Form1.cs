using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        List<Person> list = new List<Person>();
        List<Person> list2 = new List<Person>();
        public static void WriteJsonNewPerson(Person person)
        {
            var serializer = new JsonSerializer();


            using (var sw = new StreamWriter($"{person.FileName}.json"))
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                  Color.FromArgb(23, 42, 58),
                                                                  Color.FromArgb(117, 221, 221),
                                                                  90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
            person.FileName = person.Name;
            list2.Add(person);

            UserListBox.DisplayMember = nameof(Person.Name);
            UserListBox.Items.Add(person);

            NameMaskedTextBox.Text = String.Empty;
            SurnameMaskedTextBox.Text = String.Empty;
            EmailMaskedTextBox.Text = String.Empty;
            PhoneNumberMaskedTextBox.Text = String.Empty;
            BirthDayDateTimePictute.Text = String.Empty;
        }


        public bool IsEnter { get; set; } = true;

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            var temp = ChangeBtn.Location;
            ChangeBtn.Location = AddBtn.Location;
            AddBtn.Location = temp;
            var human = UserListBox.SelectedItem as Person;
            if (IsEnter)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name + ".json" == JsonFileEnter.Text)
                    {
                        list[i].Name = NameMaskedTextBox.Text;
                        list[i].Surname = SurnameMaskedTextBox.Text;
                        list[i].Email = EmailMaskedTextBox.Text;
                        list[i].PhoneNumber = PhoneNumberMaskedTextBox.Text;
                        list[i].BirthDay = BirthDayDateTimePictute.Text;

                        WriteJsonNewPerson(list[i]);
                    }
                }
            }
            else
            {
                human.Name = NameMaskedTextBox.Text;
                human.Surname = SurnameMaskedTextBox.Text;
                human.Email = EmailMaskedTextBox.Text;
                human.PhoneNumber = PhoneNumberMaskedTextBox.Text;
                human.BirthDay = BirthDayDateTimePictute.Text;

                WriteJsonNewPerson(human);
            }

            NameMaskedTextBox.Text = String.Empty;
            SurnameMaskedTextBox.Text = String.Empty;
            EmailMaskedTextBox.Text = String.Empty;
            PhoneNumberMaskedTextBox.Text = String.Empty;
            BirthDayDateTimePictute.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.AddRange(list2);
            for (int i = 0; i < list.Count; i++)
            {
                WriteJsonNewPerson(list[i]);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            IsEnter = false;
            if (JsonFileEnter.Text != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].FileName + ".json" == JsonFileEnter.Text)
                    {
                        NameMaskedTextBox.Text = list[i].Name;
                        SurnameMaskedTextBox.Text = list[i].Surname;
                        EmailMaskedTextBox.Text = list[i].Email;
                        PhoneNumberMaskedTextBox.Text = list[i].PhoneNumber;
                        BirthDayDateTimePictute.Text = list[i].BirthDay;
                    }
                }
            }
            IsEnter = !IsEnter;
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