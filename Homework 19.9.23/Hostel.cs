using System;

namespace Rooms {
  public class Hostel {

      public Room[] Allrooms = new Room[200];

      public Hostel() {
        for (int i = 0;i<Allrooms.Length;i++) {
          Allrooms[i] = new Room(i+100, i/100, 0);
        }
      }

      public int[] FloorIncome()
      {
          int[] income = new int[3];
          for (int i = 0; i <Allrooms.Length ; i++)
          {
              int Floor = Allrooms[i].GetNum() / 100;
              income[Floor - 1] += Allrooms[i].Income();
          }
          return income;
      }
      public int OrderRoom(int type,int nights)
      {
          for (int i = 0; i < Allrooms.Length; i++)
          {
              if (Allrooms[i].GetRoomType() == type && Allrooms[i].GetNightsReserved() == 0)
              {
                  Allrooms[i].SetNightsReserved(nights);
                  return Allrooms[i].GetNum();
              }
          }
          return -1;
      }
  }
}
