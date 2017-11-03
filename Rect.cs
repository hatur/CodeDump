class MathHelper
{
  static bool IsInside<T>(T minxmax1, T minmax2, T value)
  {
    if (minmax1 == minmax2)
    {
      if (minmax1 == value)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    else
    { // minmax1 && minmax2 can't be equal
      int min;
      int max;
      
      if (minmax1 > minmax2)
      {
        min = minmax2;
        max = minmax1;
      }
      else
      {
        min = minmax1;
        max = minmax2;
      }
      
      if (value >= min && value <= max)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
