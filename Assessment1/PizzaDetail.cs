namespace Assessment1
{
  public class Pizza
        {
           
            private int cheeseToppings;
        private int pepperoniToppings;
        private string size;
        private int hamToppings;


            public int CheeseToppings
            {
                get { return cheeseToppings; }
                set { cheeseToppings = value; }
            }

            public int PepperoniToppings
            {
                get 
               {
                return pepperoniToppings;
                }
                set
            { 
                pepperoniToppings = value; 
            }
            }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public int HamToppings
            {
                get
            { 
                return hamToppings;
            }
                set 
            { 
                hamToppings = value; 
            }
            }

            public Pizza( int cheeseToppings, string size, int pepperoniToppings, int hamToppings)
            {
             
                this.cheeseToppings = cheeseToppings;
            this.size = size;
                  this.pepperoniToppings = pepperoniToppings;
                this.hamToppings = hamToppings;
            }

            public double CalcCost()
            {
                double cost = 0;

                   switch (size)
                {
                          case "Small":
                        cost = 10 + 2 * ( pepperoniToppings + cheeseToppings+ hamToppings);
                        break;
                        case "Medium":
                        cost = 12 + 2 * (pepperoniToppings + cheeseToppings + hamToppings);
                        break;
                    case "Large":
                        cost = 14 + 2 * (pepperoniToppings + cheeseToppings + hamToppings);
                        break;
                    default:
                        break;
                }

                return cost;
            }

            public string GetDescription()
            {
                return $"{size} Pizza with {cheeseToppings} cheese topping, {pepperoniToppings} pepperoni topping, and {hamToppings} ham topping";
            }
        }

    
}