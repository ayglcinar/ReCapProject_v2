using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }

    }
}
