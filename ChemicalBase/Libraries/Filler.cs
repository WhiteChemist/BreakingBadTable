using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using ChemicalBase.Elements;

namespace ChemicalBase.Libraries
{
    class Filler
    {
        public Filler()
        {
        }

        public void FillForm(MainWindow window, Element[] elements)
        {
            Regex regex = new Regex(@"^[a-z]{7}.[1-9]{1,3}$");
            int counter = 1;
            foreach (FrameworkElement txt in window.maingrid.Children)
            {
                if (txt is TestControl_v2)
                {
                    if(ExtractNumber(txt.Name)==118)
                    {
                        var temp = ExtractNumber(txt.Name);
                        txt.DataContext = elements[--temp];
                    }
                    else
                    {
                        try
                        {
                            txt.DataContext = elements[ExtractNumber(txt.Name)];
                        }
                        catch (System.Exception ex)
                        {

                            throw ex;
                        }
                    }
                }
                counter++;
            }
        }
        public int ExtractNumber(string name)
        {
            int count = 0;
            if (name.Length == 9) { count = int.Parse(name.Substring(8, 1)); }
            else if (name.Length == 10) { count = int.Parse(name.Substring(8, 2)); }
            else if (name.Length == 11) { count = int.Parse(name.Substring(8, 3)); }
            return count;
        }
    }
}


//Border al;
//if (txt != null)
//    al = (Border)txt.FindName("vb1");
//if (txt is TestControl_v2)
//{
//    if (regex.IsMatch(txt.Name) && txt.Name.Contains(counter.ToString()))
//    {

//        var Elem = txt.c;
//        var Numb = (TextBlock)txt.FindName("Numb");
//        Elem.Text = elements[counter].name;
//        Numb.Text = elements[counter].number.ToString();
//    }
//}