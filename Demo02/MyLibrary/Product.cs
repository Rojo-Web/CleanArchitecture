

namespace MyLibrary;

    public class Product(int id, string name, decimal unitPrice, int unitsInStock)
    {
        //Propiedades
        public int Id => Id;
        public string Name => Name;
        public decimal UnitPrice => UnitPrice;
        public decimal unitsInStock => unitsInStock;
        public bool Discontinued { get; set; }
        public void SetDiscontinued() => Discontinued = true;
        public bool GetStatus() => Discontinued;
    }

