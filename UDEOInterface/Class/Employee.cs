using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDEOInterface.Class
{
    public class Employee : BusinessObjectBase
    {
        private string _id;
        private string _name;
        private Decimal parkingId;

        public Employee() : this(string.Empty, 0) { }
        public Employee(string name) : this(name, 0) { }

        public Employee(string name, Decimal parkingId) : base()
        {
            this._id = System.Guid.NewGuid().ToString();

            this.Name = name;
            this.ParkingID = parkingId;
        }

        public string ID
        {
            get { return _id; }
        }

        const string NAME = "Name";
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(NAME);
                }
            }
        }

        const string PARKING_ID = "Salary";
        public Decimal ParkingID
        {
            get { return parkingId; }
            set
            {
                if (parkingId != value)
                {
                    parkingId = value;
                    OnPropertyChanged(PARKING_ID);
                }
            }
        }
    }
}
