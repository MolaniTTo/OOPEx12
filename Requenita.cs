using System;


namespace OOPEx12
{
    public class Requenita : Furniture
    {
        private bool fimosis;

        public bool Fimosis
        {
            get { return fimosis; }
            set { fimosis = value; }
        }

        public Requenita(bool fimosis, float weight, double price, bool set, string name, string material, string colour) : base( weight,  price,  set,  name,  material,  colour)
        {
            Fimosis = fimosis;
        }




        public override string GetInfo() //override
        {
            return base.GetInfo() + $", Fimosis: {Fimosis}";
        }


    }


}
