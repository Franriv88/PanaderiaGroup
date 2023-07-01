using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería
{
    public class RawMaterial
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public int unit { get; set; }

        public RawMaterial() { }

        public RawMaterial(int id, string name, int amount)
        {
            this.id = id;
            this.name = name.ToUpper();
            this.amount = amount;
        }

        public RawMaterial(string name, string unit)
        {
            this.name = name.ToUpper();
            this.amount = 0;
            this.unit = RawMaterial.getUnitType(unit);
        }

        public RawMaterial(int id, string name, int amount, int unit) {
            this.id = id;
            this.name = name.ToUpper();
            this.amount = amount;
            this.unit = unit;
        }

        private static string getUnitTypeText(int unit)
        {
            switch (unit) {
                case 1:
                    return "Kg";
                case 2:
                    return "Unitary";
                case 3:
                    return "Liters";
                default:
                    return "...";

            }
        }
        private static int getUnitType(string unit)
        {
            switch (unit)
            {
                case "Kg":
                    return 1;
                case "Unitary":
                    return 2;
                case "Liters":
                    return 3;
                default:
                    return 0;

            }
        }

        public string[] toArray()
        {
            return new string[] {
                this.id.ToString(),
                this.name.ToUpper(),
                this.amount.ToString(),
                RawMaterial.getUnitTypeText(this.unit)
            };
        }
    }
}
