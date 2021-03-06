﻿using Iso.Api.DataAnnotations;

namespace Iso.Api.Models
{
  public abstract class BaseModel
  {
    protected BaseModel(string name, string isoAlpha3Code, string isoNumericCode)
    {
      Name = name;
      IsoAlpha3Code = isoAlpha3Code;
      IsoNumericCode = isoNumericCode;
    }
    
    public string Name { get; }

    [AbsoluteLength(3)] public string IsoAlpha3Code { get; }

    [AbsoluteLength(3)] public string IsoNumericCode { get; }
  }
}
