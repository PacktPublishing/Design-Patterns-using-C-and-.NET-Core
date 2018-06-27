using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface ICardsService
    {
        IEnumerable<Card> FetchCards();
    }
}
