using System;
using DDD.Domain.Core.Models;

namespace DDD.Domain.Models
{
    /// <summary>
    /// 地址
    /// </summary>
    public class Address:ValueObject<Address>
    {
        //省份
        public string Province { get; private set; }

        //城市
        public string City { get; private set; }

        //区县
        public string County { get; private set; }

        //街道
        public string Street { get; private set; }

        public Address(string province, string city, string county, string street, string zip)
        {
            this.Province = province;
            this.City = city;
            this.County = county;
            this.Street = street;
        }

        protected override bool EqualsCore(Address other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
