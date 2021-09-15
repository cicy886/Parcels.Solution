// using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set ; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Dimension { get; set; }
    public int ShippingCost { get; set; }

    public Parcel (int length, int width, int height, int weight, int dimension = 0, int shippingCost = 0)
    {
      Length = length;                      
      Width = width;                  
      Height = height;
      Weight = weight;
      Dimension = dimension;
    }
    public int Volume()
    {
      return Dimension = Length * Width * Height;
    }
    public int CostToShip()
    {
      if (Weight >0 && Weight <= 5)
      {
        return ShippingCost = 15;
      }
      else if (Weight >5 && Weight <=10)
      {
        return ShippingCost = 40;
      }
      else if (Weight >10 && Weight <=25)
      {
        return ShippingCost = 100;
      }
      else if (Weight >25 && Weight <=50)
      {
        return ShippingCost = 160;
      }else
      {
        return 0;
      }
    }

    public string WrongInput()
    {
      if (Weight > 50)
      {
        return "Weight is over 50lb. We can't ship this parcel. Sorry!";
      }
      else{
        return null;
      }
    }
  } 

}