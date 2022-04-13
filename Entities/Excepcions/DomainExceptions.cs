using System;

namespace BankAcc.Entities.Exceptions
{
  class DomainException : ApplicationException
  {
    public DomainException(string massage) 
        : base(massage)
    {

    }


  }
}