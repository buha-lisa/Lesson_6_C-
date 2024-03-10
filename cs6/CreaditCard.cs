namespace cs6
{
    class CreditCard
    {
        public string NumberOfCard { get; set; }
        public string PIP { get; set; }
        public int CVC { get; set; }
        public DateOnly? Complite { get; set; }
        public int PineCode { get; set; }

        public decimal Money { get; set; }

        public static CreditCard operator +(CreditCard one, decimal increment)
        {
            return new CreditCard { Money = one.Money + increment };
        }
        public static CreditCard operator -(CreditCard one, decimal increment)
        {
            return new CreditCard { Money = one.Money - increment };
        }

        public static bool operator ==(CreditCard one, CreditCard two)
        {
            return one.CVC == two.CVC;
        }
        public static bool operator !=(CreditCard one, CreditCard two)
        {
            return one.CVC != two.CVC;
        }

        public static bool operator >(CreditCard one, CreditCard two)
        {
            return one.Money > two.Money;
        }
        public static bool operator <(CreditCard one, CreditCard two)
        {
            return one.Money < two.Money;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard other = (CreditCard)obj;
                return this.CVC == other.CVC;
            }
            return false;
        }
    }
}
