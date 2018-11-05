using System;
namespace DDD.Domain.Core.Models
{
    /// <summary>
    /// 定义领域实体基类
    /// </summary>
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        /// <summary>
        /// 重写方法 相等运算
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:DDD.Domain.Core.Models.Entity"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current
        /// <see cref="T:DDD.Domain.Core.Models.Entity"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo))
                return true;
            if (ReferenceEquals(null, compareTo))
                return false;

            return Id.Equals(compareTo.Id);
        }

        /// <summary>
        /// 重写方法 实体比较==
        /// </summary>
        /// <param name="a">The first <see cref="DDD.Domain.Core.Models.Entity"/> to compare.</param>
        /// <param name="b">The second <see cref="DDD.Domain.Core.Models.Entity"/> to compare.</param>
        /// <returns><c>true</c> if <c>a</c> and <c>b</c> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator == (Entity a,Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        /// <summary>
        /// 重写方法 实体比较!=
        /// </summary>
        /// <param name="a">The first <see cref="DDD.Domain.Core.Models.Entity"/> to compare.</param>
        /// <param name="b">The second <see cref="DDD.Domain.Core.Models.Entity"/> to compare.</param>
        /// <returns><c>true</c> if <c>a</c> and <c>b</c> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 获取哈希
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        /// <summary>
        /// 输出领域对象的状态
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DDD.Domain.Core.Models.Entity"/>.</returns>
        public override string ToString()
        {
            return GetType().Name + "[Id=" + Id + "]";
        }
    }
}
