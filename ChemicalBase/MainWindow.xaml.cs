using System;
using System.Collections.Generic;
using System.IO;
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
using ChemicalBase.Libraries;
using ChemicalBase.Elements;

namespace ChemicalBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Element[] elements;
        Filler filler;
        public MainWindow()
        {

            InitializeComponent();
            Extractor extractor = new Extractor();
            filler = new Filler();
            elements = extractor.Extract(Directory.GetCurrentDirectory() + "/Resources/BaseElements.xml");
            filler.FillForm(this, elements);
            InitControls();
        }
        private void InitControls()
        {
            foreach (var item in maingrid.Children)
            {
                if(item is TestControl_v2)
                {
                    ((TestControl_v2)item).MouseDoubleClick += Click;
                }
            }
        }
        private void Click(object sender, MouseButtonEventArgs e)
        {
            ElementWindows window = new ElementWindows(elements[filler.ExtractNumber(((TestControl_v2)sender).Name)]);
            window.Show();
        }
    }
}
