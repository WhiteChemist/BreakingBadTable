using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalBase.Libraries
{
    public class Element
    {
        public Element() {  }
        #region variables
        public string name { get; private set; }
        public string symbol { get; private set; }
        public int number { get; private set; }
        public int period { get; private set; }
        public int group { get; private set; }
        public string subgroup { get; private set; }
        public string atomicmass { get; private set; }
        public string electronicconfiguration { get; private set; }
        public string elementtype { get; private set; }
        public string latinname { get; private set; }
        public string electronegativity { get; private set; }
        public int openingyear { get; private set; }
        public string scientist { get; private set; }
        public string meltingtemperature { get; private set; }
        public string boilingtemperature { get; private set; }
        #endregion
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSymbol(string symbol)
        {
            this.symbol = symbol;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        public void SetPeriod(int period)
        {
            this.period = period;
        }
        public void SetGroup(int group)
        {
            this.group = group;
        }
        public void SetSubGroup(string subgroup)
        {
            this.subgroup = subgroup;
        }
        public void SetAtomicMass(string atomicmass)
        {
            this.atomicmass = atomicmass;
        }
        public void SetElectronicConfiguration(string electonicconf)
        {
            this.electronicconfiguration = electonicconf;
        }
        public void SetElementType(string elementtype)
        {
            this.elementtype = elementtype;
        }
        public void SetLatinName(string latinname)
        {
            this.latinname = latinname;
        }
        public void SetElectronegativity(string electronegativity)
        {
            this.electronegativity = electronegativity;
        }
        public void SetOpeningYear(int year)
        {
            this.openingyear = year;
        }
        public void SetScientist(string scientist)
        {
            this.scientist = scientist;
        }
        public void SetMeltingTemperature(string temperature)
        {
            this.meltingtemperature = temperature;
        }
        public void SetBoilingTemperature(string temperature)
        {
            this.boilingtemperature = temperature;
        }
    }
}
