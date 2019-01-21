﻿using LinFx.Infrastructure.Data;
using System;
namespace LinFx.Extensions.Data
using System.Linq;
using System.Linq.Expressions;

namespace LinFx.Extensions.DapperExtensions
{
	internal static class SortingExtensions
    {
        public static Sorting[] ToSorting<T>(this Expression<Func<T, object>>[] sortingExpression, bool ascending = true)
        {
			//Check.NotNullOrEmpty(sortingExpression, nameof(sortingExpression));
			var sortList = new List<Sorting>();
			sortingExpression.ToList().ForEach(sortExpression =>
			{
				var sortProperty = ReflectionUtils.GetProperty(sortExpression);
				sortList.Add(new Sorting { Ascending = ascending, PropertyName = sortProperty.Name });
			});
			return sortList.ToArray();
		}
    }
}
