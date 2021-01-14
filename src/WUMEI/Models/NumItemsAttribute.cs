using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WUMEI.Models
{
    /// <summary>
    /// Requires a collection to contain the number of items specified by the Min
    /// and Max properties. Min defaults to 0 if not set, and Max defaults to
    /// int.MaxValue.
    /// <remarks>
    /// This will fail if not placed on a collection property
    /// </remarks>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NumItemsAttribute : ValidationAttribute
    {
        /// <summary>
        /// The maximum number of items that can be contained in this collection
        /// </summary>
        public int Max { get; set; } = int.MaxValue;

        /// <summary>
        /// The minimum number of items that can be contained in this collection
        /// </summary>
        public int Min { get; set; } = 0;

        /// <inheritdoc />
        public override bool IsValid(object value)
        {
            if (value is ICollection collection)
            {
                return collection.Count >= Min && collection.Count <= Max;
            }

            return false;
        }
    }
}