using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        EntaMeenEntities db = new EntaMeenEntities();
        public SignUp()
        {
            InitializeComponent();
        }
        bool ISValid(string pass)
        {
            bool uppper, lower, digit, symbol;
            uppper = lower = digit = symbol = false;
            string Special = "!@#$%^&*()";
            foreach (char c in pass)
            {
                if (c >= 'A' &&  c <= 'Z')
                {
                    uppper = true;
                }
                if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                if (c >= '0' && c <= '9')
                {
                    digit = true;
                }
                else if (Special.Contains(c))
                {
                    symbol = true;
                }
            }
            return uppper && lower && digit && symbol;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if(Pass_Txt.Password.Length > 8 && Regex.IsMatch(Pass_Txt.Password,@"^(?=.*[A-Z])(?=.* \d)(?=.*[!@#$%^&*]) .+$") )
            {
                if (ISValid(Pass_Txt.Password))
                {
                    Entameen1 EN = new Entameen1();
                    EN.E_Name = Name_Txt.Text;
                    EN.Pass = Pass_Txt.Password;
                    EN.DOB = DateTime.Parse(Date_Txt.Text);
                    EN.Addresso = Addr_Txt.Text;
                    db.Entameen1.Add(EN);
                    db.SaveChanges();
                    MessageBox.Show("Data added Successfully");
                    string name = Name_Txt.Text;
                    Homexaml homexamlp = new Homexaml(name);
                    this.NavigationService.Navigate(homexamlp);
                }
                else
                {
                    MessageBox.Show("Must enter lower , uper, sppecil chars, digits");
                }
               
            }
           // else
            {
               
            }
        }
    }
}
