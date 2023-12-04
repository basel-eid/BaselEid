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
    /// Interaction logic for Homexaml.xaml
    /// </summary>
    public partial class Homexaml : Page
    {
        EntaMeenEntities db = new EntaMeenEntities();
        public Homexaml(string name)
        {
            InitializeComponent();
            Label1.Content= "welcome " + name;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(combo.SelectedItem != null)
            {
                string data = combo.SelectedItem.ToString().Split(' ').Last();
                if(data == "Name")
                {
                    Entameen1 En = new Entameen1();
                    int id =int.Parse( ID_Txt.Text);
                    DG.ItemsSource = db.Entameen1.Where(x=> x.id == id).Select(x=> new { x.E_Name }).ToList();
                }
                if (data == "DOB")
                {
                    Entameen1 En = new Entameen1();
                    int id = int.Parse(ID_Txt.Text);
                    DG.ItemsSource = db.Entameen1.Where(x => x.id == id).Select(x => new { x.DOB }).ToList();
                }
                if (data == "Address")
                {
                    Entameen1 En = new Entameen1();
                    int id = int.Parse(ID_Txt.Text);
                    DG.ItemsSource = db.Entameen1.Where(x => x.id == id).Select(x => new { x.Addresso }).ToList();
                }

            }
        }

        private void Ref_butt_Click(object sender, RoutedEventArgs e)
        {
            DG = null;
            ID_Txt.Text = "";
            combo.SelectedItem = null;
        }
    }
}
