using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManager.Patients
{
	public class Room
	{
        int _roomNumber;
        bool _available;
        bool _showerRoom;
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
                    _available = false;
                }
			}
		}

		public Room(int number, bool showerRoom)
		{
            this._roomNumber = number;
            this._showerRoom = showerRoom;
            this._available = true;
            this._blocked = false;
		}
	}
}
