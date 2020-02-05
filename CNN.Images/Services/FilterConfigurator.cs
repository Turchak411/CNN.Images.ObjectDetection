﻿using System.Collections.Generic;
using CNN.Images.Model;

namespace CNN.Images.Services
{
    public class FilterConfigurator
    {
        public FilterConfig GetReliefFilter()
        {
            return new FilterConfig
            {
                Name = FilterName.Relief,
                Matrix = new double[,]
                {
                    { -2, 1, 0 },
                    { -1, 1, 1 },
                    {  0, 1, 2 }
                }
            };
        }

        public FilterConfig GetBlurFilter()
        {
            return new FilterConfig
            {
                Name = FilterName.Blur,
                Matrix = new double[,]
                {
                    { 1, 1, 1 },
                    { 1, 1, 1 },
                    { 1, 1, 1 }
                }
            };
        }

        public FilterConfig GetClarityFilter()
        {
            return new FilterConfig
            {
                Name = FilterName.Clarity,
                Matrix = new double[,]
                {
                    { -1, -1, -1 },
                    { -1,  9, -1 },
                    { -1, -1, -1}
                }
            };
        }

        public List<FilterConfig> GetAllFilters()
        {
            List<FilterConfig> filters = new List<FilterConfig>();

            filters.Add(GetReliefFilter());
            filters.Add(GetBlurFilter());
            filters.Add(GetClarityFilter());

            return filters;
        }
    }
}
