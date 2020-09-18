using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PIN_Projekt.Models;
using PagedList;


namespace PIN_Projekt.ViewModels
{
    public class ProizvodIndexViewModel
    {
        public IPagedList<Proizvod> Products { get; set; }
        public string Search { get; set; }
        public IEnumerable<CategoryWithCount> CategoriesWithCount { get; set; }
        public string Category { get; set; }
        public string SortBy { get; set; }
        public Dictionary<string, string> Sorts { get; set; }

        public IEnumerable<SelectListItem> CategoryFilterItems
        {
            get
            {
                var allCategories = CategoriesWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCategories;
            }
        }
    }

    public class CategoryWithCount
    {
        public int ProductCount { get; set; }
        public string CategoryName { get; set; }
        public string CatNameWithCount
        {
            get
            {
                return CategoryName + " (" + ProductCount.ToString() + ")";
            }
        }
    }
}