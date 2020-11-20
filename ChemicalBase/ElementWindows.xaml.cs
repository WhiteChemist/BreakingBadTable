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
using System.Windows.Shapes;
using ChemicalBase.Libraries;

namespace ChemicalBase
{
    /// <summary>
    /// Логика взаимодействия для ElementWindows.xaml
    /// </summary>
    public partial class ElementWindows : Window
    {
        public ElementWindows()
        {
            InitializeComponent();
        }
        public ElementWindows(ChemicalBase.Libraries.Element element)
        {
            InitializeComponent();
            FillForm(element);
        }
        private void FillForm(ChemicalBase.Libraries.Element element)
        {
            name.Text = element.name;
            symbol.Text = element.symbol;
            number.Text = element.number.ToString();
            period.Text = element.period.ToString();
            group.Text = element.group.ToString();
            subgroup.Text = element.subgroup;
            atomicmass.Text = element.atomicmass.ToString();
            electro.Text = element.electronicconfiguration;
            elementtype.Text = element.elementtype;
            latinname.Text = element.latinname;
            electroneg.Text = element.electronegativity;
            year.Text = element.openingyear.ToString();
            scientist.Text = element.scientist;
            melttemp.Text = element.meltingtemperature;
            boiltemp.Text = element.boilingtemperature;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
