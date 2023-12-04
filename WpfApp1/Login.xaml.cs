using System;
using System.Collections.Generic;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        EntaMeenEntities db = new EntaMeenEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = Name_Txt.Text;
                Entameen1 En = new Entameen1();
                En = db.Entameen1.First(x => x.E_Name == Name_Txt.Text && x.Pass == Pass_Txt.Password);
                Homexaml homexamlp = new Homexaml(name);
                this.NavigationService.Navigate(homexamlp);

            }
            catch
            {
                MessageBox.Show("Wrong input");
            }



        }

        private void Hyperlink_RequestNavigate_1(object sender, RequestNavigateEventArgs e)
        {

        }
    }
}
