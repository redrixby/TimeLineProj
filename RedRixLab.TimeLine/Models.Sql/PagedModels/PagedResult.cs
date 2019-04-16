using System.Collections.Generic;

namespace Api.Models.Sql.PagedModels
{
    /// <summary>
    /// Модель результирующей страницы.
    /// </summary>
    /// <typeparam name="T">Обобщенный тип.</typeparam>
    public class PagedResult<T>
    {
        /// <summary>
        /// Массив элементов.
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Суммарное кол-во элементов.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Кол-во элементов на странице.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Пропущенное кол-во элементов.
        /// </summary>
        public int Offset { get; set; }
    }
}
