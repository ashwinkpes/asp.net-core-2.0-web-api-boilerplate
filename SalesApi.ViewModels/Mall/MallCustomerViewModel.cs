﻿using Infrastructure.Features.Common;

namespace SalesApi.ViewModels.Mall
{
    public class MallCustomerViewModel : EntityBase
    {
        public int SubAreaId { get; set; }
        public int? MallGroupId { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string Pinyin { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}