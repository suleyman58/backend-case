using System;
using System.Collections.Generic;

namespace backend_case.Models;

public partial class Product
{

    public long Id { get; set; }

    public long ProductStatusId { get; set; }

    public string ProductStatusName { get; set; } = null!;

    public string ProductUrl { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string TitleDomestic { get; set; } = null!;

    public string DescriptionDomestic { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public string OtherCode { get; set; } = null!;

    public int Stock { get; set; }

    public string CurrencyName { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal PriceDiscountedDomestic { get; set; }

    public decimal PriceDiscounted { get; set; }

    public bool IsFeatured { get; set; }

    public bool IsElonkyFeatured { get; set; }

    public bool HasVideo { get; set; }

    public bool HasPersonalization { get; set; }

    public bool IsTaxable { get; set; }

    public string WhenMade { get; set; } = null!;

    public string WhoMade { get; set; } = null!;

    public string PersonalizationDescription { get; set; } = null!;

    public bool? IsDigital { get; set; }
}
