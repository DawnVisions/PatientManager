using System;

namespace PatientManager.Patients
{
	public class Room
	{
        public int RoomNumber { get; }

		public bool Available { get; set; }

		public bool ShowerRoom { get; }

        bool _blocked;
		public bool Blocked
		{
			get
			{
                return _blocked;
			}
			set
			{
                _blocked = value;
                Available = _blocked;
			}
		}

		public Room(int number, bool showerRoom)
		{
            this.RoomNumber = number;
            this.ShowerRoom = showerRoom;
            this.Available = true;
            this._blocked = false;
		}

        public override string ToString()
        {
            return RoomNumber.ToString();
        }
    }
}
