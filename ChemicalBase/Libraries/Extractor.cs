using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using ChemicalBase.Libraries;

namespace ChemicalBase.Libraries
{
    class Extractor
    {
        public Extractor() { }

        public Element[] Extract(string path)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XmlElement root = document.DocumentElement;
            int count = root.ChildNodes.Count;
            Element[] elements = new Element[++count];
            for (int i = 0; i < elements.Length; i++)
                elements[i] = new Element();
            int counter = 1;
            foreach (XmlNode item in root)
            {
                foreach (XmlNode element in item.ChildNodes)
                {
                    switch(element.Name)
                    {
                        case "name":
                            elements[counter].SetName(element.InnerText);
                            break;
                        case "symbol":
                            elements[counter].SetSymbol(element.InnerText);
                            break;
                        case "number":
                            elements[counter].SetNumber(int.Parse(element.InnerText));
                            break;
                        case "period":
                            elements[counter].SetPeriod(int.Parse(element.InnerText));
                            break;
                        case "group":
                            elements[counter].SetGroup(int.Parse(element.InnerText));
                            break;
                        case "subgroup":
                            elements[counter].SetSubGroup(element.InnerText);
                            break;
                        case "atomic_mass":
                            elements[counter].SetAtomicMass(element.InnerText);
                            break;
                        case "electronic_configuration":
                            elements[counter].SetElectronicConfiguration(element.InnerText);
                            break;
                        case "element_type":
                            elements[counter].SetElementType(element.InnerText);
                            break;
                        case "latin_name":
                            elements[counter].SetLatinName(element.InnerText);
                            break;
                        case "electronegativity":
                            elements[counter].SetElectronegativity(element.InnerText);
                            break;
                        case "opening_year":
                            elements[counter].SetOpeningYear(int.Parse(element.InnerText));
                            break;
                        case "scientists":
                            elements[counter].SetScientist(element.InnerText);
                            break;
                        case "melting_temperature":
                            elements[counter].SetMeltingTemperature(element.InnerText);
                            break;
                        case "boiling_temperature":
                            elements[counter].SetBoilingTemperature(element.InnerText);
                            break;
                    }

                }
                counter++;
            }
            return elements;
        }
    }
    
}
