using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWC_Bills.Models;

public partial class NwcSubscriptionFile
{
    public string NwcSubscriptionFileNo { get; set; } = null!;
    [Required(ErrorMessage = "رقم الهوية مطلوب")]
    [StringLength(10, ErrorMessage = "يجب ألا يتخطي الرقم 10 خانات")]
    public string NwcSubscriptionFileSubscriberCode { get; set; } = null!;
    [ValidateNever]
    public virtual NwcSubscriberFile SubscriberFile { get; set; } = null!;
    public string NwcSubscriptionFileRrealEstateTypesCode { get; set; } = null!;
    [Range(1,99, ErrorMessage = "لا يمكن أن يتعدى الرقم أكثر من 99")]
    public int NwcSubscriptionFileUnitNo { get; set; }

    public bool NwcSubscriptionFileIsThereSanitation { get; set; }

    public int? NwcSubscriptionFileLastReadingMeter { get; set; }

    public string? NwcSubscriptionFileReasons { get; set; }

    public virtual ICollection<NwcInvoice> NwcInvoices { get; set; } = new List<NwcInvoice>();
    [NotMapped]
    public virtual NwcRrealEstateType NwcSubscriptionFileRrealEstateTypesCodeNavigation { get; set; } = null!;
    [NotMapped]
    public virtual NwcSubscriberFile NwcSubscriptionFileSubscriberCodeNavigation { get; set; } = null!;
}
