using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWC_Bills.Models;

public partial class NwcInvoice
{
    [Key]
    [Required(ErrorMessage = "رقم الفاتورة مطلوب")]
    [StringLength(10, ErrorMessage = "يجب ألا يتعدى الرقم 10 خانات")]
    public string NwcInvoicesNo { get; set; } = null!;

    public string NwcInvoicesYear { get; set; } = null!;

    public string NwcInvoicesRrealEstateTypes { get; set; } = null!;
    [Required(ErrorMessage = "رقم الاشتراك مطلوب")]
    [StringLength(10, ErrorMessage = "يجب ألا يتخطي الرقم 10 خانات")]
    public string NwcInvoicesSubscriptionNo { get; set; } = null!;
    [ValidateNever]
    public virtual NwcSubscriptionFile SubscriptionFile { get; set; } = null!;

    public string NwcInvoicesSubscriberNo { get; set; } = null!;
    [ValidateNever]
    public virtual NwcSubscriberFile SubscriberFile { get; set; } = null!;

    public DateTime NwcInvoicesDate { get; set; }

    public DateTime NwcInvoicesFrom { get; set; }

    public DateTime NwcInvoicesTo { get; set; }
    public int NwcInvoicesPreviousConsumptionAmount { get; set; }
    [Required(ErrorMessage = "رقم الاشتراك مطلوب")]
    [Range(1, 10, ErrorMessage = "يجب ألا يتخطي الرقم 10 خانات")]
    public int NwcInvoicesCurrentConsumptionAmount { get; set; } 

    public int NwcInvoicesAmountConsumption { get; set; } 
    public decimal NwcInvoicesServiceFee { get; set; }
    public decimal NwcInvoicesTaxRate { get; set; }

    public bool NwcInvoicesIsThereSanitation { get; set; }

    public decimal NwcInvoicesConsumptionValue { get; set; }

    public decimal NwcInvoicesWastewaterConsumptionValue { get; set; }

    public decimal NwcInvoicesTotalInvoice { get; set; }

    public decimal NwcInvoicesTaxValue { get; set; }

    public string NwcInvoicesTotalBill { get; set; } = null!;

    public string? NwcInvoicesTotalReasons { get; set; }
    [NotMapped]
    public virtual NwcRrealEstateType NwcInvoicesRrealEstateTypesNavigation { get; set; } = null!;
    [NotMapped]

    public virtual NwcSubscriberFile NwcInvoicesSubscriberNoNavigation { get; set; } = null!;
    [NotMapped]

    public virtual NwcSubscriptionFile NwcInvoicesSubscriptionNoNavigation { get; set; } = null!;
}
