﻿using Machine.Specifications;

namespace Example.Random
{
  public class TestAssemblyContext : IAssemblyContext
  {
    public static bool OnAssemblyStartRun;
    public static bool OnAssemblyCompleteRun;

    public void OnAssemblyStart()
    {
      OnAssemblyStartRun = true;
    }

    public void OnAssemblyComplete()
    {
      OnAssemblyCompleteRun = true;
    }
  }
}