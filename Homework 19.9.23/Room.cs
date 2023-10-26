using System;

namespace Rooms {
  public class Room {
      public int roomNum;
      public int roomType;
      public int nightReserved;

      public Room(int n, int t, int re)
      {
          roomNum = n;
          roomType = t;
          nightReserved = re;
      }
      public int GetNum()
      {
          return this.roomNum;
      }
      public int GetRoomType()
      {
          return roomType;
      }
      public int GetNightsReserved()
      {
          return this.nightReserved;
      }
      public void SetNightsReserved(int newnights)
      {
          this.nightReserved = newnights;
      }
      public int Income()
      {
          int income = nightReserved * 50 * roomType;
          return income;
      }
  }
}
