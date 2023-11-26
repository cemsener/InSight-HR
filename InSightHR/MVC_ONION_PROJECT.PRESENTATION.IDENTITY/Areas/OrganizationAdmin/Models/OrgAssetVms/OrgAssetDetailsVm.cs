﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_ONION_PROJECT.DOMAIN.ENUMS;
using System.ComponentModel;

namespace MVC_ONION_PROJECT.PRESENTATION.IDENTITY.Areas.OrganizationAdmin.Models.OrgAssetVms
{
    public class OrgAssetDetailsVm
    {
        public Guid Id { get; set; }

        [DisplayName("Seri No")]
        public string SerialNumber { get; set; }

        [DisplayName("Demirbaş Adı")]
        public string Name { get; set; }

        [DisplayName("Fiyatı")]
        public float Price { get; set; }

        [DisplayName("Alım Tarihi")]
        public DateTime PurchaseDate { get; set; }

        [DisplayName("Kategori")]
        public string CategoryName { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Durumu")]
        public AssetStatus AssetStatus { get; set; }
    }
}
