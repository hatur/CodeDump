class MathHelper
{
  static bool IsInline<T>(T minxmax1, T minmax2, T value)
  {
    if (minmax1 == minmax2 == value)
    {
      return true;
    }
    else
    {
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
