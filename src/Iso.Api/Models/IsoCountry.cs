﻿using Iso.Api.DataAnnotations;

namespace Iso.Api.Models
{
  public class IsoCountry : BaseModel
  {
    public IsoCountry(string name, string isoAlpha2Code, string isoAlpha3Code, string isoNumericCode) : 
      base(name, isoAlpha3Code, isoNumericCode)
    {
      IsoAlpha2Code = isoAlpha2Code;
    }

    [AbsoluteLength(2)] public string IsoAlpha2Code { get; }
  }
}