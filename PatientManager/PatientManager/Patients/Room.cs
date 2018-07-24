using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class Room
	{
        bool _blocked;

        public int RoomNumber { get; }

		public bool Available { get; set; }

		public bool ShowerRoom { get; }

		public bool Blocked
		{
			get
			{
                return _blocked;
			}
			set
			{
                _blocked = value;
                if (_blocked == true)
                {
                    Available = false;
                }
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
