namespace CarUnitTest
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licensePlate;

        public Car(int id, string model, int price, string licensePlate)
        {
            ID = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name is null");
                if (value.Length <= 4) throw new ArgumentOutOfRangeException("Name must be at least 4 characters");
                _model = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Price", value, "is out of range");
                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length < 2 || value.Length > 7) throw new ArgumentOutOfRangeException(nameof(value));
                _licensePlate = value;
            }
        }
    }
}