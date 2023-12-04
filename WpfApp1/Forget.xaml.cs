using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Forget.xaml
    /// </summary>
    public partial class Forget : Page
    {
        EntaMeenEntities db = new EntaMeenEntities();
        public Forget()
        {
            InitializeComponent();
        }
       
        bool IsValid(string pass)
        {
            bool upper, lower, digit, symbol;
            upper = lower = digit = symbol = false;
            string Special = "!@#$%^&*()";
            foreach (char c in pass)
            {
                if(c >= '0' && c <= '9')
                { digit = true; }
                if (c >= 'A' && c <= 'Z')
                { upper = true; }
                if (c >= 'a' && c <= 'z')
                { lower = true; }
                if (Special.Contains(c))
                {
                    symbol = true;
                }
            }
            return upper && lower && digit && symbol;
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (IsValid(Pass_Txt.Password))
                {
                    Entameen1 En = new Entameen1();
                    string name = Name_Txt.Text;
                    En = db.Entameen1.First(x => x.E_Name == Name_Txt.Text);
                    if(Pass_Txt.Password == con_Txt.Password)
                    {
                        En.Pass = Pass_Txt.Password;
                        db.Entameen1.AddOrUpdate(En);
                        db.SaveChanges();
                        MessageBox.Show("Pass Changed");
                        Homexaml homexamlp = new Homexaml(name);
                        this.NavigationService.Navigate(homexamlp);
                    }
                    else
                    {
                        MessageBox.Show("Pass must be as confirm");
                    }
                }
                else
                {
                    MessageBox.Show("Must enter lower , uper, sppecil chars, digits");
                }
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }
    }
}
